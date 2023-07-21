//===============================================================================================
// <A4DN_GeneratedInformation>
// This code was generated using the Accelerator for .Net Code Generator.
// <A4DN_Template Name="BOS.Module.DataMaps.t4" Version="8.0.0.75" GeneratedDate="7/21/2023" />
// </A4DN_GeneratedInformation>
//===============================================================================================
using System.Collections.Generic;
using A4DN.Core.BOS.Base;
using SharedSystemProperties = BOS.EasyBuyCycles.Shared.Properties;
using BOS.CustomerDataEntity;

namespace BOS.CustomerDataMaps
{
    public class CustomerMaps : AB_DataMaps
    {
        private const string CustomerPrimaryTableName = "Customer";
        private const string CustomerTableName = "Customer";
        private const string CustomerTableAlias_b = "b";

        public CustomerMaps() : base() { }
        public CustomerMaps(string qualifier) : base(qualifier) { }

        /// <summary>
        /// Loads maps to join two database files.
        /// </summary>
        public override Dictionary<string, AB_RelationshipMap> am_LoadRelationshipMaps()
        {
            var relationshipMap = new AB_RelationshipMapsDictionary(ap_PrimaryTable);

            // TODO: Table Relationships Step 1 - Define and relationships and join conditions for each file and add relationships (Change 0 to 1, 2, ... n for each new file map)
            // AB_RelationshipMap map0 = new AB_RelationshipMap("PrimaryFile", "SecondaryFile", JoinType.LeftOuter);  // Create a map to a single file
            // TODO: Table Relationships Step 2 - Add Joins for each relationship
            // Two field Relationship 
            // map0.ap_JoinConditions.Add(new AB_JoinCondition(new AB_QueryField("FileName", "FieldName"), "=", new AB_QueryField("FileName", "FieldName")));
            // Single Field to Constant Relationship
            // map0.ap_JoinConditions.Add(new AB_JoinCondition(new AB_QueryField("FileName", "FieldName"), "=", new AB_QueryConstant("ConstantValue")));
            // relationshipMap.Add("Y06T", map0); // Add to the relationship Dictionary keyed by Secondary File

            relationshipMap.am_AddRelationshipMap(CustomerTableName, useDistinctJoins: false, joinTableAlias: CustomerTableAlias_b)
            .am_JoinWhere(primaryTableField: "ParentInternalID", joinTableField: "InternalID");

            return relationshipMap;
        }


        /// <summary>
        /// Defines the maps for the Data Source Field Names and Entity Properties for module.
        /// </summary>
        public override Dictionary<string, AB_DataSourcePropertyReference> am_LoadFieldMaps(string qualifier)
        {
            // Set the Primary File Name, Foreign fields will have to be mapped on a case-by-case basis
            ap_PrimaryTable = CustomerPrimaryTableName;
            //Create a dictionary to hold the maps
            var maps = new AB_DataMapsDictionary(ap_PrimaryTable, qualifier);

            maps.am_AddDataMap("InternalID", CustomerEntity.InternalIDProperty);
            maps.am_AddDataMap("ParentInternalID", CustomerEntity.ParentInternalIDProperty);
            maps.am_AddDataMap("ParentRelationship", CustomerEntity.ParentRelationshipProperty);
            maps.am_AddDataMap("Name", CustomerEntity.NameProperty);
            maps.am_AddDataMap("LegalName", CustomerEntity.LegalNameProperty);
            maps.am_AddDataMap("ContactLastName", CustomerEntity.ContactLastNameProperty);
            maps.am_AddDataMap("ContactFirstName", CustomerEntity.ContactFirstNameProperty);
            maps.am_AddDataMap("ContactMiddleName", CustomerEntity.ContactMiddleNameProperty);
            maps.am_AddDataMap("ContactNickName", CustomerEntity.ContactNickNameProperty);
            maps.am_AddDataMap("BillingAddress1", CustomerEntity.BillingAddress1Property);
            maps.am_AddDataMap("BillingAddress2", CustomerEntity.BillingAddress2Property);
            maps.am_AddDataMap("BillingAddress3", CustomerEntity.BillingAddress3Property);
            maps.am_AddDataMap("BillingPostalCode", CustomerEntity.BillingPostalCodeProperty);
            maps.am_AddDataMap("BillingCountry", CustomerEntity.BillingCountryProperty);
            maps.am_AddDataMap("Telephone", CustomerEntity.TelephoneProperty);
            maps.am_AddDataMap("Email", CustomerEntity.EmailProperty);
            maps.am_AddDataMap("Memo", CustomerEntity.MemoProperty);
            maps.am_AddDataMap("PurchasePoints", CustomerEntity.PurchasePointsProperty);
            maps.am_AddDataMap("CreatedAt", CustomerEntity.CreatedAtProperty);
            maps.am_AddDataMap("CreatedBy", CustomerEntity.CreatedByProperty);
            maps.am_AddDataMap("CreatedWith", CustomerEntity.CreatedWithProperty);
            maps.am_AddDataMap("LastModifiedAt", CustomerEntity.LastModifiedAtProperty);
            maps.am_AddDataMap("LastModifiedBy", CustomerEntity.LastModifiedByProperty);
            maps.am_AddDataMap("LastModifiedWith", CustomerEntity.LastModifiedWithProperty);
            maps.am_AddDataMap(string.Format("{0}.{1}", CustomerTableAlias_b, "InternalID"), CustomerEntity.InternalID1Property, targetTable: CustomerTableAlias_b);

            //TODO: CustomerMaps Real Field Example
            //maps.am_AddDataMap("<Field Name>", CustomerEntity.<Property Name>);
            //TODO: CustomerMaps Virtual Field Example
            //maps.am_AddDataMap("<Field Name>", CustomerEntity.<Property Name>, isVirtual: true);
            //TODO: CustomerMaps Foreign Field Example
            //maps.am_AddDataMap(string.Format("{0}.{1}", "<Target Table Name>", "<Field Name>"), CustomerEntity.<Property Name>, targetTable: "<Target Table Name>"); 

            return maps.am_ToDictionary();
        }

    }
}