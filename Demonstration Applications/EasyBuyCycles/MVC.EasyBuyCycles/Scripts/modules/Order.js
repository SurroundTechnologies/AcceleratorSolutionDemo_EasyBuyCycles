//===============================================================================================
// <A4DN_GeneratedInformation>
// This code was generated using the Accelerator for .Net Code Generator.
// <A4DN_Template Name="MVC.Module.javascript.js.t4" Version="8.0.0.75" GeneratedDate="7/21/2023" />
// </A4DN_GeneratedInformation>
//===============================================================================================

// Order Comand Call Back Functions: Order.js

OrderExplorerComandCallBackFunctions = {
    afterPageLoad: function (guid) {
        // console.debug("afterPageLoad_OrderExplorer_" + guid);
        // Called by a4dn.core.mvc.am_SetupModuleExplorer. No return values expected.
    }, 

    beforeProcessCommand: function (guid, commandID, $command, table, $row, $selectedRows) {
        // console.debug("beforeProcessCommand_OrderExplorer_" + guid, commandID);

        switch (commandID) {
            //case "<commandID>":

            //    return true; // Handled
            //    return false; // Continue Processing
        }

        // Can return either true/false or an object. Must set 'handled' property to true/false. Others are optional:
        // return { handled: ..., commandID: ..., overrideUrl: ..., successCallback: ..., errorCallback: ... };
    },

    afterProcessCommand: function (guid, commandID, $command) {
        // console.debug("afterProcessCommand_OrderExplorer_" + guid, commandID);

        switch (commandID) {
            //case "<commandID>":
            //    return;
        }

        // No return value expected
    },

    beforeDataGridAjaxProcessRequestPost: function (guid, $table, $row, commandID, data) {
        // console.debug("beforeDataGridAjaxProcessRequestPost_OrderExplorer_" + guid, $table, $row, commandID, data);
        // Called by am_DataGridAjaxProcessRequestPostRequest
        // Can return either true/false or an object. Must set 'handled' property to true/false. Others are optional:
        // return { handled: ..., commandID: ..., overrideUrl: ... };
    },

    beforeShowModalSearch: function ($modal, guid) {
        // console.debug("afterShowModalSearch_OrderExplorer_" + guid, $modal);
        // Called by am_ShowModalSearch
        // No return value expected
    },

    afterShowModalSearch: function ($modal, guid) {
        // console.debug("afterShowModalSearch_OrderExplorer_" + guid, $modal);
        // Called by am_ShowModalSearch

        // Set up an AB_FormModel for the search dialog, to allow client-side logic
        // let $module = a4dn.core.mvc.am_Get$Module(guid),
        //     moduleNumber = a4dn.core.mvc.am_GetModuleNumber($module),
        //     model = a4dn.core.mvc.am_GetFormModel($modal, { $module: $module });

        // window.SearchFormModel_Order = model;   // For console runtime access
        // OrderExplorerFunctions.initializeSearchExplorer(model);

        // No return value expected
    }
};

OrderDetailComandCallBackFunctions = {
    beforePreview: function (tableGuid, table, $row, url) {
        // console.debug("beforePreview_OrderDetail", tableGuid, table, $row, url);

        // Called by am_FetchDetailDataForPreview
        // Can return true/false or an object. 'handled' property is required:
        // return { handled: ..., overrideUrl: ... };
    },

    afterPageLoad: function (guid, commandID) {
        // console.debug("afterPageLoad_OrderDetail_" + guid, commandID);
        // Called by a4dn.core.mvc.am_SetupModuleDetail, am_DetailAjaxPostRequest, am_FetchDetailDataForPreview.

        // Set up an AB_FormModel for the detail form, to allow client-side logic, custom validation, etc
        // let $form = ardn.core.mvc.am_Get$Form(guid),
        //     model = a4dn.core.mvc.am_GetFormModel($form, { guid: guid, commandID: commandID });

        // $form.data('AB_FormModel', model);          // Save model for Detail Command callback handlers
        // window.FormModel_Order = model; // For console runtime access

        // switch (commandID) 
        // {
        //     case "OPEN":
        //     case "DISPLAY":
        //     case "NEW":
        //     case "NEWFOR":
        //     case "COPY":
        //     case "COPYFOR":
        //         OrderDetailFunctions.initializePage(model);
        //         break;
        //
        //     case "PREVIEW":
        //         break;
        // }

        // No return values expected.
    }, 

    beforeProcessCommand: function (guid, commandID, $command) {
        // console.debug("beforeProcessCommand_OrderDetail_" + guid, commandID);

        switch (commandID) {
            //case "<commandID>":

            //    return true; // Handled
            //    return false; // Continue Processing
        }

        // Can return either true/false or an object. Must set 'handled' property to true/false. Others are optional:
        // return new { handled: ..., commandID: ..., overrideUrl: ..., successCallback: ..., errorCallback: ... };
    },

    afterProcessCommand: function (guid, commandID, $command) {
        // console.debug("afterProcessCommand_OrderDetail_" + guid, commandID);

        switch (commandID) {
            //case "<commandID>":
            //    return;
        }

        // No return value expected
    }
};

// DataTables Callback functions
// refer to documentation here https://datatables.net/reference/option/
// All functions called from a4dn.datatables.js

OrderDataTablesCallBackFunctions = {
    setOptions: function (options) {
        // console.debug('setOptions_Order', options);
    },

    ajaxCallStarted: function (guid, e, settings, data) {
        // console.debug('ajaxCallStarted_Order', guid, e, settings, data);
    },

    ajaxCallCompleted: function (guid, e, settings, json, xhr) {
        // console.debug('ajaxCallCompleted_Order', guid, e, settings, json, xhr);
    },

    preDrawCallback: function (guid) {
        // console.debug('preDrawCallback_Order', guid);
    },

    rowCallback: function (guid, nRow) {
        // console.debug('rowCallback_Order', guid, nRow);
    },

    createdRow: function (guid, row, data, dataIndex, $table) {
        // console.debug('createdRow_Order', guid, row, data, dataIndex, $table);
    },

    createdCell: function (guid, td, cellData, rowData, row, col) {
        // console.debug('createdCell_Order', guid, td, cellData, rowData, row, col);
    },

    renderedCell: function (data, type, full, meta) {
        // console.debug('renderedCell_Order', data, type, full, meta);

        return data;
    },

    headerCallback: function (guid, thead, data, start, end, display) {
        // console.debug('headerCallback_Order', guid, thead, data, start, end, display);
    },

    footerCallback: function (guid, tfoot, data, start, end, display) {
        // console.debug('footerCallback_Order', guid, tfoot, data, start, end, display);
    },

    formatNumber: function (guid, toFormat) {
        // console.debug('formatNumber_Order', toFormat);

		return toFormat;
    },

    infoCallback: function (guid, settings, start, end, max, total, pre) {
        // console.debug('infoCallback_Order', guid, settings, start, end, max, total, pre);
		
		return pre;
    },

    drawCallback: function (guid, settings) {
        // console.debug('drawCallback_Order', guid, settings);
    },

    initComplete: function (guid, settings, json) {
        // console.debug('initComplete_Order', guid, settings, json);
    }
};



// Module-specific Explorer client-side logic functions

OrderExplorerFunctions = {
    initializeSearchExplorer: function (model) {
        // Use model to set am_PropChanged handler functions on fields, initialize states, etc.
        // model.{FieldName}.am_PropChanged = function (e, name, model) { ... };
    }
};



// Module-specific Detail client-side logic functions

OrderDetailFunctions = {
    initializePage: function (model) {
        // Use model to set am_PropChanged handler functions on fields, initialize states, etc.
    }
};