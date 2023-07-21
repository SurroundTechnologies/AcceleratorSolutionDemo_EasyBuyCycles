//===============================================================================================
// <A4DN_GeneratedInformation>
// This code was generated using the Accelerator for .Net Code Generator.
// <A4DN_Template Name="MVC.System.Global.asax.t4" Version="8.0.0.75" GeneratedDate="7/21/2023" />
// </A4DN_GeneratedInformation>
//===============================================================================================

using A4DN.Core.BOS.Base;
using A4DN.Core.MVC.LOB.Controllers;
using A4DN.Core.MVC.LOB.Models;
using A4DN.Core.MVC.Shared.Infrastructure.Attributes.Action;
using A4DN.Core.MVC.Shared.Infrastructure.Extensions;
using A4DN.AM.BOS.PC_PropertyCodeValueDataEntity;
using A4DN.AM.BOS.PC_PropertyCodeValueDataMaps;
using A4DN.AM.BOS.PC_PropertyCodeValueViewModel;
using System.Web.Mvc;
using A4DN.Core.BOS.ViewModel;

namespace A4DN.AM.MVC.AcceleratorMaintenance.Controllers
{
	/// <summary>
    /// Class PC_PropertyCodeValueController.
    /// </summary>
    [Authorize]
    [AB_CompressContent]
    public class PC_PropertyCodeValueController : AB_ModuleController<PC_PropertyCodeValueEntity, PC_PropertyCodeValueVM, PC_PropertyCodeValueMaps>
    {
        /// <summary>
        /// Gets the module explorer HTML view.
        /// </summary>
        /// <param name="moduleExplorerModel">The module explorer model.</param>
        /// <returns>JsonResult.</returns>
        [HttpGet]
        public JsonResult GetModuleExplorerHtmlView(AB_ModuleExplorerModel moduleExplorerModel)
        {
			// Setting to control how the am_SetUpVisualModelForContent method is called in the viewmodel. By default, this method will not be called.
			// moduleExplorerModel.ap_SelectionChangedAjaxTrigger = AB_SelectionChangedAjaxTrigger.OnSelectionChanged;
            am_SetModuleExplorerModelProperties(moduleExplorerModel);

            var markup = this.am_RenderView(moduleExplorerModel.ap_PartialView_ModuleExplorer, moduleExplorerModel);
            return this.AB_JsonResult(resultCode: moduleExplorerModel.ap_ReturnCode, message: moduleExplorerModel.ap_MessageString, markup: markup);
        }

        /// <summary>
        /// Gets the module detail HTML view.
        /// </summary>
        /// <param name="moduleDetailModel">The module detail model.</param>
        /// <returns>JsonResult.</returns>
        [HttpGet]
        public JsonResult GetModuleDetailHtmlView(AB_ModuleDetailModel moduleDetailModel)
        {
            if (_TryGetPropertyCodeTableId(moduleDetailModel.ap_ModuleNumber) != null)
            {
                // Custom Property Table Explorer - Get property Code table ID
                if (moduleDetailModel.ap_CommandID == AB_CommonCommandIDs.New || moduleDetailModel.ap_CommandID == AB_CommonCommandIDs.SaveAndNew)
                {
                    moduleDetailModel.ap_CommandID = AB_CommonCommandIDs.NewFor;
                    moduleDetailModel.ap_ParentKeys = @"{""PropertyCodeTableId"":" + _TryGetPropertyCodeTableId(moduleDetailModel.ap_ModuleNumber) + "}";
                   
                }
            }

            // Setting to control how the am_OnCurrentEntityPropertyChanged method is called in the viewmodel. By default, this method will not be called. 
            // moduleDetailModel.ap_PropertyChangedAjaxTrigger = AB_PropertyChangedAjaxTrigger.OnInputControlChangedDelayedWait;
            am_SetModuleDetailModelProperties(moduleDetailModel);
            
			if (moduleDetailModel.ap_ReturnCode == "OK")
            {              
                var markup = this.am_RenderView(moduleDetailModel.ap_PartialView_ModuleDetail, moduleDetailModel);
                return this.AB_JsonResult(resultCode: moduleDetailModel.ap_ReturnCode, message: moduleDetailModel.ap_MessageString, markup: markup);
            }

            return this.AB_JsonResult(resultCode: moduleDetailModel.ap_ReturnCode, message: moduleDetailModel.ap_MessageString);
        }

        /// <summary>
        /// Search.
        /// </summary>
        /// <param name="moduleSearchModel">The module search model.</param>
        /// <param name="entity">The entity.</param>
        /// <returns>JsonResult.</returns>
        [AB_AjaxOnly]
        public JsonResult Search(AB_ModuleSearchModel moduleSearchModel, PC_PropertyCodeValueEntity entity)
        {
            entity.PropertyCodeTableId  = _TryGetPropertyCodeTableId(moduleSearchModel.ap_ModuleNumber);

            var retArgs = am_Select(moduleSearchModel, entity);

            if (moduleSearchModel.ap_ReturnSearchCountOnly)
            {
                return this.AB_JsonResult(output: new { RecordCount = retArgs.ap_RecordCount });
            }

			if (moduleSearchModel.ap_ReturnExcelUrlOnly)
            {
                return this.AB_JsonResult(output: new { ExcelUrl = am_ExportToExcel(moduleSearchModel.ap_ViewColumns, moduleSearchModel.ap_ModuleNumber, retArgs.ap_OutputRecords) });
            }

            // Create Json Data Output
            var jsonResult = Json(am_CreateTableDataFromOutputUsingViewDisplayColumns(moduleSearchModel.ap_ViewName, moduleSearchModel.ap_ModuleNumber, moduleSearchModel.ap_OutputRecords, Request.Params["search[value]"], moduleSearchModel.ap_DrawCount, moduleSearchModel.ap_TotalCount, moduleSearchModel.ap_ReturnCode, moduleSearchModel.ap_MessageString), JsonRequestBehavior.AllowGet);
            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }

        private int? _TryGetPropertyCodeTableId(int moduleNumber)
        {
            var modEntity = ap_FrameworkHelper.am_GetModuleByModuleNumber(moduleNumber);
            if (modEntity.ExplorerComponent == "AB_PropertyTableExplorer")
            {
                // Custom Property Table Explorer - Get property Code table ID
                return int.TryParse(modEntity.ModuleExplorers[0].Path, out var tableID)
                    ? int.Parse(modEntity.ModuleExplorers[0].Path) as int?
                    : null;
            }

            return null;
        }

        /// <summary>
        /// Fetches using the unique key.
        /// </summary>
        /// <param name="moduleDetailModel">The module detail model.</param>
        /// <returns>JsonResult.</returns>
        [HttpGet]
        public JsonResult FetchWithUniqueKey(AB_ModuleDetailModel moduleDetailModel)
        {
            var retArgs = am_FetchWithUniqueKey(moduleDetailModel);

            if (moduleDetailModel.ap_ReturnTableData)
            {  // Return Table Data format
                return this.AB_JsonResult(resultCode: moduleDetailModel.ap_ReturnCode, message: moduleDetailModel.ap_MessageString, output: am_CreateTableDataFromOutputUsingViewDisplayColumns(moduleDetailModel.ap_ViewName, moduleDetailModel.ap_ModuleNumber, retArgs.ap_OutputEntity, moduleDetailModel.ap_ReturnCode, moduleDetailModel.ap_MessageString).data);
            }
            var test = am_SerializeEntitytoJsonString(retArgs.ap_OutputEntity, moduleDetailModel.ap_TitleMode, moduleDetailModel.ap_ModuleName);
            // Return entity as a json object
            return this.AB_JsonResult(resultCode: moduleDetailModel.ap_ReturnCode, message: moduleDetailModel.ap_MessageString, output: am_SerializeEntitytoJsonString(retArgs.ap_OutputEntity, moduleDetailModel.ap_TitleMode, moduleDetailModel.ap_ModuleName));
        }

        /// <summary>
        /// Updates the specified entity model.
        /// </summary>
        /// <param name="moduleDetailModel">The module detail model.</param>
        /// <param name="entity">The entity.</param>
        /// <returns>JsonResult.</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Update(AB_ModuleDetailModel moduleDetailModel, PC_PropertyCodeValueEntity entity)
        {
            am_SetModuleDetailModelUpdateProperties(moduleDetailModel, entity);

            if (ModelState.IsValid)
            {
                var retArgs = am_Update(moduleDetailModel, entity);

                if (retArgs.ap_IsSuccess)
                {
                    ModelState.Clear();
                    return GetModuleDetailHtmlView(moduleDetailModel);
                }
            }

            return moduleDetailModel.ap_ReturnCode == AB_ReturnCodes.OK.ToString()
                ? this.AB_JsonResult(resultCode: moduleDetailModel.ap_ReturnCode, message: moduleDetailModel.ap_MessageString, markup: this.am_RenderView(moduleDetailModel.ap_PartialView_ModuleDetail, moduleDetailModel))
                : this.AB_JsonErrorResult(moduleDetailModel.ap_MessageString);
        }

        /// <summary>
        /// Inserts the specified entity model.
        /// </summary>
        /// <param name="moduleDetailModel">The module detail model.</param>
        /// <param name="entity">The entity.</param>
        /// <returns>JsonResult.</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Insert(AB_ModuleDetailModel moduleDetailModel, PC_PropertyCodeValueEntity entity)
        {
            am_SetModuleDetailModelInsertProperties(moduleDetailModel, entity);

            if (ModelState.IsValid)
            {
                var retArgs = am_Insert(moduleDetailModel, entity);

                if (retArgs.ap_IsSuccess)
                {
                    return GetModuleDetailHtmlView(moduleDetailModel);
                }
            }

            return moduleDetailModel.ap_ReturnCode == AB_ReturnCodes.OK.ToString()
                ? this.AB_JsonResult(resultCode: moduleDetailModel.ap_ReturnCode, message: moduleDetailModel.ap_MessageString, markup: this.am_RenderView(moduleDetailModel.ap_PartialView_ModuleDetail, moduleDetailModel))
                : this.AB_JsonErrorResult(moduleDetailModel.ap_MessageString);
        }

        /// <summary>
        /// Deletes using the unique key.
        /// </summary>
        /// <param name="moduleDetailModel">The module detail model.</param>
        /// <returns>JsonResult.</returns>
        [HttpPost]
        public JsonResult DeleteWithUniqueKey(AB_ModuleDetailModel moduleDetailModel)
        {
            var retArgs = am_DeleteWithUniqueKey(moduleDetailModel);

            return retArgs.ap_IsSuccess 
                ?  this.AB_JsonResult(resultCode: moduleDetailModel.ap_ReturnCode, message: moduleDetailModel.ap_MessageString, output: new { UniqueKey = moduleDetailModel.ap_UniqueKey })
                : this.AB_JsonErrorResult(moduleDetailModel.ap_MessageString);
        }
    }
}