using A4DN.CF.SchemaEntities;
using A4DN.Core.BOS.Base;
using A4DN.Core.BOS.FrameworkEntity;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using A4DN.CF.WizardShared;

namespace GenerationWizardPlugin
{
    public class EasyBuyModernWizardDefaults : WizardDefaults
    {
        public override void am_Initialize(AB_GenerationWizardShared generationWizardShared)
        {
            // Relationships are pulled from the database access routes.
            // If no relationships are defined on the database, you can define the relationships in the _GetDatabaseRelationships method.
            generationWizardShared.ap_DatabaseRelationships = _GetDatabaseRelationships();

            base.am_Initialize(generationWizardShared);
        }

        internal override void SetModuleRulesBeforeColumnRules(WizardDefaults.Mode mode, AB_GenerationModuleEntity moduleEntity)
        {
            AuditStamps = new Dictionary<string, AB_AuditStampTypes>()
                {
                    {"CreatedAt", AB_AuditStampTypes.Undefined}, // Needs a CreateDateTime Audit Stamp Type
                    {"CreatedBy", AB_AuditStampTypes.CreateUser},
                    {"CreatedWith", AB_AuditStampTypes.Undefined},
                    //{"CRJN", AB_AuditStampTypes.Undefined},  // Not sure if Job Number is included in above
                    {"LastModifiedAt", AB_AuditStampTypes.Undefined}, // Needs a LastChangeDateTime Audit Stamp Type
                    {"LastModifiedBy", AB_AuditStampTypes.LastChangeUser},
                    {"LasModifiedWith", AB_AuditStampTypes.Undefined},
                    //{"LCJN", AB_AuditStampTypes.Undefined}, // Not sure if Job Number is included in above
                };

            ExtendedContentWindowField = new List<string>
                {
                    "ParentInternalID",
                    "ParentRelationship"
                };

            ExtendedSearchField = new List<string>
                {
                    "ParentInternalID",
                    "ParentRelationship"
                };

            DetailTitleField = new List<string>
                {
                    "Name",
                    "ContactLastName",
                    "ContactFirstName"
                };

            base.SetModuleRulesBeforeColumnRules(mode, moduleEntity);

            switch (mode)
            {
                case Mode.InitialSetup:
                    // Set Module Name.  This will also set the image name
                    moduleEntity.ModuleName = FormatModuleName(moduleEntity.FileDescription);
                    break;

                case Mode.ColumnsChanged:
                    break;
            }
        }

        internal override void SetColumnRules(Mode mode, AB_GenerationModuleEntity moduleEntity, AB_GenerationViewColumnEntity viewColumnEntity)
        {
            base.SetColumnRules(mode, moduleEntity, viewColumnEntity);

            switch (mode)
            {
                case Mode.InitialSetup:

                    // This is done to eliminate conflicts with having the Internal ID referenced multiple times in a file
                    if (viewColumnEntity.EntityPropertyName.ToUpper() == "INTERNALID")
                    {
                        viewColumnEntity.EntityPropertyName = moduleEntity.ModuleName.Replace(" ", "") + "InternalID";
                        viewColumnEntity.ColumnDescription = moduleEntity.ModuleName + " Internal ID";
                    }

                    // Set Numeric(8) date fields as Property Type of DateTime and Field Visualization of Date
                    if ((viewColumnEntity.Name.Substring(viewColumnEntity.Name.Length - 2) == "DT") && ((viewColumnEntity.Type == "NUMERIC(8)") || viewColumnEntity.Type == "DATE(4)"))
                    {
                        viewColumnEntity.PropertyType = AB_PropertyTypes.DateTime;
                        viewColumnEntity.FieldVisualization = AB_FieldVisualizations.AB_DatePicker;

                        if ((viewColumnEntity.Type == "NUMERIC(8)"))
                        {
                            viewColumnEntity.AdditionalDataMapParameters = "databaseFieldType: AB_EntityFieldType.Decimal";
                        }
                    }

                    // Set Numeric(6) Time fields as Property Type of TimeSpan and Field Visualization of Time
                    if ((viewColumnEntity.Name.Substring(viewColumnEntity.Name.Length - 2) == "TM") && (viewColumnEntity.Type == "NUMERIC(6)"))
                    {
                        viewColumnEntity.PropertyType = AB_PropertyTypes.TimeSpan;
                        viewColumnEntity.FieldVisualization = AB_FieldVisualizations.AB_TimePicker;
                        viewColumnEntity.AdditionalDataMapParameters = "databaseFieldType: AB_EntityFieldType.Decimal";
                    }

                    // SetAdd Attribute [AB_AutoIncremented] to Identity Field
                    if (IsIdentityField(viewColumnEntity))
                    {
                        viewColumnEntity.IsIdentity = false;
                        if (viewColumnEntity.Type == "NUMERIC(8)")
                        {
                            viewColumnEntity.IsAutoIncrementedInCode = true;
                        }
                    }

                    // Uncheck Memo Field from Content Window and Search Explorer Bar
                    if (viewColumnEntity.ViewField.EndsWith("Memo") && viewColumnEntity.FieldLength == 100)
                    {
                        viewColumnEntity.IsContentWindowField = false;
                        viewColumnEntity.IsExplorerBarField = false;
                    }

                    // Uncheck Image Path from Search Explorer Bar
                    if (viewColumnEntity.ViewField.EndsWith("ImagePath") && viewColumnEntity.FieldLength == 256)
                    {
                        viewColumnEntity.IsExplorerBarField = false;
                    }

                    // Uncheck Warehouse ID and Sales Person ID Fields from Content Window, Search Explorer Bar and Detail
                    if (viewColumnEntity.ViewField.EndsWith("WarehouseInternalID") || viewColumnEntity.ViewField.EndsWith("SalesPersonInternalID"))
                    {
                        viewColumnEntity.IsContentWindowField = false;
                        viewColumnEntity.IsExplorerBarField = false;
                        viewColumnEntity.IsDetailField = false;
                        viewColumnEntity.IsAuditStampField = false;
                    }

                    // Set Nick Name Field to Visible False in Content Window
                    if (viewColumnEntity.ViewField.EndsWith("ContactNickName") && viewColumnEntity.FieldLength == 50)
                    {
                        viewColumnEntity.Visible = false;
                    }

                    // Set Fields in Title Required
                    if (viewColumnEntity.IsTitleField && !viewColumnEntity.IsIdentity)
                    {
                        viewColumnEntity.IsRequiredField = true;
                    }
                    else
                    {
                        viewColumnEntity.IsRequiredField = false;
                    }

                    // Set Any Fields that are not audit stamps but end in "At" or "DateTime" as Detail Title Fields
                    if ((viewColumnEntity.ViewField.ToUpper().EndsWith("AT") || viewColumnEntity.ViewField.ToUpper().EndsWith("DATETIME")) && !IsAuditTabField(viewColumnEntity))
                    {
                        viewColumnEntity.IsTitleField = true;
                    }

                    var requiredField = new List<string>
                {
                    "Name","ContactLastName","ContactFirstName","BillingAddress1","BillingAddress2","BillingAddress3","PostalCode","BillingPostalCode","Country","BillingCountry","Telephone","Email","OrderInternalID","ProductInternalID","Quantity","InternalID","CustomerInternalID","OrderDateTime","ShippingAddressInternalID","Status","PurchaseOrderNumber","Code","ListPrice"
                };
                    // Set Required Fields
                    if (requiredField.Any(x => viewColumnEntity.ViewField.ToUpper().EndsWith(x.ToUpper())))
                    {
                        viewColumnEntity.IsRequiredField = true;
                    }

                    break;

                case Mode.ColumnsChanged:

                    break;
            }

            if (!viewColumnEntity.IsTitleField)
            {
                //If not a title field, then hide on small devices
                viewColumnEntity.WebMarkupTHDataAttributes = "data-hide=\"phone,tablet\"";
            }
        }

        internal override void SetModuleRulesAfterColumnRules(WizardDefaults.Mode mode, AB_GenerationModuleEntity moduleEntity)
        {
            switch (mode)
            {
                case Mode.InitialSetup:

                    // Set the Default View
                    _defaultViewSet = false;
                    if (moduleEntity.GenerationModuleExplorers[0] != null &&
                        moduleEntity.GenerationModuleExplorers[0].GenerationModuleExplorerViews != null)
                    {
                        foreach (
                            var view in moduleEntity.GenerationModuleExplorers[0].GenerationModuleExplorerViews.OrderBy(x => x.ViewName)
                            )
                        {
                            _SetDefaultView(view, moduleEntity);
                        }
                    }

                    break;

                case Mode.ColumnsChanged:
                    break;
            }

            base.SetModuleRulesAfterColumnRules(mode, moduleEntity);
        }

        private bool _defaultViewSet;

        /// <summary>
        /// Set Default View
        /// </summary>
        /// <param name="viewEntity">View Entity</param>
        /// <param name="moduleEntity">Module Entity</param>
        /// <returns></returns>
        private void _SetDefaultView(AB_GenerationModuleExplorerViewEntity viewEntity,
                                      AB_GenerationModuleEntity moduleEntity)
        {
            const string defaultViewSuffix = "LF1";

            if (viewEntity.ViewName.ToUpper().EndsWith(defaultViewSuffix.ToUpper()) && viewEntity.Description.ToUpper().Contains("NAME"))
            {
                if (!_defaultViewSet)
                {
                    WizardShared.am_SetDefaultView(viewEntity, moduleEntity);
                    _defaultViewSet = true;
                }
            }
        }

        #region Relationships

        private ObservableCollection<AB_SchemaRelationshipEntity> _GetDatabaseRelationships()
        {
            var relationships = new ObservableCollection<AB_SchemaRelationshipEntity>();

            // Customers have One to Many Orders
            relationships.Add(_AddRelationship("Customer", "InternalID", "Order", "CustomerInternalID", SchemaRelationshipType.OneToMany));
            // Customers have One to Many Shipping Addresses
            relationships.Add(_AddRelationship("Customer", "InternalID", "ShippingAddress", "CustomerInternalID", SchemaRelationshipType.OneToMany));
            // Customers have Customer
            relationships.Add(_AddRelationship("Customer", "InternalID", "Customer", "ParentInternalID", SchemaRelationshipType.OneToMany));
            // Orders have One to Many Order Items
            relationships.Add(_AddRelationship("Order", "InternalID", "OrderItem", "OrderInternalID", SchemaRelationshipType.OneToMany));
            // Products have One to Many Order Items
            relationships.Add(_AddRelationship("Product", "InternalID", "OrderItem", "ProductInternalID", SchemaRelationshipType.OneToMany));
            // Shipping Addresses have One to Many Order
            relationships.Add(_AddRelationship("ShippingAddress", "InternalID", "Order", "ShippingAddressInternalID", SchemaRelationshipType.OneToMany));

            return relationships;
        }

        private AB_SchemaRelationshipEntity _AddRelationship(string primaryTable, string primaryKeyColumn, string foreignTable, string foreignKeyColumn, SchemaRelationshipType relationshipType)
        {
            return new AB_SchemaRelationshipEntity()
            {
                PrimaryTable = primaryTable,
                PrimaryKeyColumn = primaryKeyColumn,
                ForeignTable = foreignTable,
                ForeignKeyColumn = foreignKeyColumn,
                RelationshipType = relationshipType,
            };
        }

        #endregion Relationships
    }
}