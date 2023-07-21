//===============================================================================================
// <A4DN_GeneratedInformation>
// This code was generated using the Accelerator for .Net Code Generator.
// <A4DN_Template Name="BOS.Module.DataMaps.t4" Version="8.0.0.75" GeneratedDate="7/21/2023" />
// </A4DN_GeneratedInformation>
//===============================================================================================
using System.Collections.Generic;
using A4DN.Core.BOS.Base;
using SharedSystemProperties = BOS.EasyBuyCycles.Shared.Properties;
using BOS.ShippingAddressDataEntity;

namespace BOS.ShippingAddressDataMaps
{
	public class ShippingAddressMaps : AB_DataMaps
	{
		private const string ShippingAddressPrimaryTableName = "ShippingAddress";
		private const string CustomerTableName = "Customer";

		public ShippingAddressMaps() : base() { }
		public ShippingAddressMaps(string qualifier) : base(qualifier) { }
		  
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
		 
            relationshipMap.am_AddRelationshipMap(CustomerTableName, useDistinctJoins: false)
			.am_JoinWhere(primaryTableField:"CustomerInternalID", joinTableField:"InternalID");

			return relationshipMap;
		}
		

		/// <summary>
		/// Defines the maps for the Data Source Field Names and Entity Properties for module.
		/// </summary>
		public override Dictionary<string,AB_DataSourcePropertyReference> am_LoadFieldMaps(string qualifier)
		{	
			// Set the Primary File Name, Foreign fields will have to be mapped on a case-by-case basis
			ap_PrimaryTable = ShippingAddressPrimaryTableName;
			//Create a dictionary to hold the maps
			var maps = new AB_DataMapsDictionary(ap_PrimaryTable, qualifier);
		 
			maps.am_AddDataMap("InternalID", ShippingAddressEntity.InternalIDProperty);
			maps.am_AddDataMap("CustomerInternalID", ShippingAddressEntity.CustomerInternalIDProperty);
			maps.am_AddDataMap("Name", ShippingAddressEntity.NameProperty);
			maps.am_AddDataMap("ContactLastName", ShippingAddressEntity.ContactLastNameProperty);
			maps.am_AddDataMap("ContactFirstName", ShippingAddressEntity.ContactFirstNameProperty);
			maps.am_AddDataMap("ContactMiddleName", ShippingAddressEntity.ContactMiddleNameProperty);
			maps.am_AddDataMap("ContactNickName", ShippingAddressEntity.ContactNickNameProperty);
			maps.am_AddDataMap("Address1", ShippingAddressEntity.Address1Property);
			maps.am_AddDataMap("Address2", ShippingAddressEntity.Address2Property);
			maps.am_AddDataMap("Address3", ShippingAddressEntity.Address3Property);
			maps.am_AddDataMap("PostalCode", ShippingAddressEntity.PostalCodeProperty);
			maps.am_AddDataMap("Country", ShippingAddressEntity.CountryProperty);
			maps.am_AddDataMap("Telephone", ShippingAddressEntity.TelephoneProperty);
			maps.am_AddDataMap("Email", ShippingAddressEntity.EmailProperty);
			maps.am_AddDataMap("Memo", ShippingAddressEntity.MemoProperty);
			maps.am_AddDataMap("PurchasePoints", ShippingAddressEntity.PurchasePointsProperty);
			maps.am_AddDataMap("CreatedAt", ShippingAddressEntity.CreatedAtProperty);
			maps.am_AddDataMap("CreatedBy", ShippingAddressEntity.CreatedByProperty);
			maps.am_AddDataMap("CreatedWith", ShippingAddressEntity.CreatedWithProperty);
			maps.am_AddDataMap("LastModifiedAt", ShippingAddressEntity.LastModifiedAtProperty);
			maps.am_AddDataMap("LastModifiedBy", ShippingAddressEntity.LastModifiedByProperty);
			maps.am_AddDataMap("LastModifiedWith", ShippingAddressEntity.LastModifiedWithProperty);
			maps.am_AddDataMap(string.Format("{0}.{1}", CustomerTableName, "InternalID"), ShippingAddressEntity.InternalID1Property, targetTable: CustomerTableName);

			//TODO: ShippingAddressMaps Real Field Example
			//maps.am_AddDataMap("<Field Name>", ShippingAddressEntity.<Property Name>);
			//TODO: ShippingAddressMaps Virtual Field Example
			//maps.am_AddDataMap("<Field Name>", ShippingAddressEntity.<Property Name>, isVirtual: true);
			//TODO: ShippingAddressMaps Foreign Field Example
			//maps.am_AddDataMap(string.Format("{0}.{1}", "<Target Table Name>", "<Field Name>"), ShippingAddressEntity.<Property Name>, targetTable: "<Target Table Name>"); 
		  
			return maps.am_ToDictionary();
		}

	}
}