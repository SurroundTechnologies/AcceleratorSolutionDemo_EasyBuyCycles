//===============================================================================================
// <A4DN_GeneratedInformation>
// This code was generated using the Accelerator for .Net Code Generator.
// <A4DN_Template Name="BOS.Module.DataMaps.t4" Version="8.0.0.75" GeneratedDate="7/21/2023" />
// </A4DN_GeneratedInformation>
//===============================================================================================
using System.Collections.Generic;
using A4DN.Core.BOS.Base;
using SharedSystemProperties = BOS.EasyBuyCycles.Shared.Properties;
using BOS.OrderDataEntity;

namespace BOS.OrderDataMaps
{
	public class OrderMaps : AB_DataMaps
	{
		private const string OrderPrimaryTableName = "Order";
		private const string ShippingAddressTableName = "ShippingAddress";
		private const string CustomerTableName = "Customer";

		public OrderMaps() : base() { }
		public OrderMaps(string qualifier) : base(qualifier) { }
		  
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
		 
            relationshipMap.am_AddRelationshipMap(ShippingAddressTableName, useDistinctJoins: false)
			.am_JoinWhere(primaryTableField:"ShippingAddressInternalID", joinTableField:"InternalID");

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
			ap_PrimaryTable = OrderPrimaryTableName;
			//Create a dictionary to hold the maps
			var maps = new AB_DataMapsDictionary(ap_PrimaryTable, qualifier);
		 
			maps.am_AddDataMap("InternalID", OrderEntity.InternalIDProperty);
			maps.am_AddDataMap("CustomerInternalID", OrderEntity.CustomerInternalIDProperty);
			maps.am_AddDataMap("OrderDateTime", OrderEntity.OrderDateTimeProperty);
			maps.am_AddDataMap("PurchaseOrderNumber", OrderEntity.PurchaseOrderNumberProperty);
			maps.am_AddDataMap("WarehouseInternalID", OrderEntity.WarehouseInternalIDProperty);
			maps.am_AddDataMap("WarehouseName", OrderEntity.WarehouseNameProperty);
			maps.am_AddDataMap("DeliveryMemo", OrderEntity.DeliveryMemoProperty);
			maps.am_AddDataMap("ShippingAddressInternalID", OrderEntity.ShippingAddressInternalIDProperty);
			maps.am_AddDataMap("OrderMemo", OrderEntity.OrderMemoProperty);
			maps.am_AddDataMap("Status", OrderEntity.StatusProperty);
			maps.am_AddDataMap("SalesPersonInternalID", OrderEntity.SalesPersonInternalIDProperty);
			maps.am_AddDataMap("SalesPersonName", OrderEntity.SalesPersonNameProperty);
			maps.am_AddDataMap("PurchasePoints", OrderEntity.PurchasePointsProperty);
			maps.am_AddDataMap("CreatedAt", OrderEntity.CreatedAtProperty);
			maps.am_AddDataMap("CreatedBy", OrderEntity.CreatedByProperty);
			maps.am_AddDataMap("CreatedWith", OrderEntity.CreatedWithProperty);
			maps.am_AddDataMap("LastModifiedAt", OrderEntity.LastModifiedAtProperty);
			maps.am_AddDataMap("LastModifiedBy", OrderEntity.LastModifiedByProperty);
			maps.am_AddDataMap("LastModifiedWith", OrderEntity.LastModifiedWithProperty);
			maps.am_AddDataMap(string.Format("{0}.{1}", CustomerTableName, "InternalID"), OrderEntity.InternalID1Property, targetTable: CustomerTableName);
			maps.am_AddDataMap(string.Format("{0}.{1}", ShippingAddressTableName, "InternalID"), OrderEntity.InternalID11Property, targetTable: ShippingAddressTableName);

			//TODO: OrderMaps Real Field Example
			//maps.am_AddDataMap("<Field Name>", OrderEntity.<Property Name>);
			//TODO: OrderMaps Virtual Field Example
			//maps.am_AddDataMap("<Field Name>", OrderEntity.<Property Name>, isVirtual: true);
			//TODO: OrderMaps Foreign Field Example
			//maps.am_AddDataMap(string.Format("{0}.{1}", "<Target Table Name>", "<Field Name>"), OrderEntity.<Property Name>, targetTable: "<Target Table Name>"); 
		  
			return maps.am_ToDictionary();
		}

	}
}