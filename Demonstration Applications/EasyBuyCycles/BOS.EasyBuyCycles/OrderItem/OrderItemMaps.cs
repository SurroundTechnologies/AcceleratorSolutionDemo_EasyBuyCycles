//===============================================================================================
// <A4DN_GeneratedInformation>
// This code was generated using the Accelerator for .Net Code Generator.
// <A4DN_Template Name="BOS.Module.DataMaps.t4" Version="8.0.0.75" GeneratedDate="7/21/2023" />
// </A4DN_GeneratedInformation>
//===============================================================================================
using System.Collections.Generic;
using A4DN.Core.BOS.Base;
using SharedSystemProperties = BOS.EasyBuyCycles.Shared.Properties;
using BOS.OrderItemDataEntity;

namespace BOS.OrderItemDataMaps
{
	public class OrderItemMaps : AB_DataMaps
	{
		private const string OrderItemPrimaryTableName = "OrderItem";
		private const string OrderTableName = "Order";
		private const string ProductTableName = "Product";

		public OrderItemMaps() : base() { }
		public OrderItemMaps(string qualifier) : base(qualifier) { }
		  
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
		 
            relationshipMap.am_AddRelationshipMap(OrderTableName, useDistinctJoins: false)
			.am_JoinWhere(primaryTableField:"OrderInternalID", joinTableField:"InternalID");

            relationshipMap.am_AddRelationshipMap(ProductTableName, useDistinctJoins: false)
			.am_JoinWhere(primaryTableField:"ProductInternalID", joinTableField:"InternalID");

			return relationshipMap;
		}
		

		/// <summary>
		/// Defines the maps for the Data Source Field Names and Entity Properties for module.
		/// </summary>
		public override Dictionary<string,AB_DataSourcePropertyReference> am_LoadFieldMaps(string qualifier)
		{	
			// Set the Primary File Name, Foreign fields will have to be mapped on a case-by-case basis
			ap_PrimaryTable = OrderItemPrimaryTableName;
			//Create a dictionary to hold the maps
			var maps = new AB_DataMapsDictionary(ap_PrimaryTable, qualifier);
		 
			maps.am_AddDataMap("InternalID", OrderItemEntity.InternalIDProperty);
			maps.am_AddDataMap("OrderInternalID", OrderItemEntity.OrderInternalIDProperty);
			maps.am_AddDataMap("ProductInternalID", OrderItemEntity.ProductInternalIDProperty);
			maps.am_AddDataMap("Quantity", OrderItemEntity.QuantityProperty);
			maps.am_AddDataMap("UnitPrice", OrderItemEntity.UnitPriceProperty);
			maps.am_AddDataMap("DiscountPercent", OrderItemEntity.DiscountPercentProperty);
			maps.am_AddDataMap("Memo", OrderItemEntity.MemoProperty);
			maps.am_AddDataMap("CreatedAt", OrderItemEntity.CreatedAtProperty);
			maps.am_AddDataMap("CreatedBy", OrderItemEntity.CreatedByProperty);
			maps.am_AddDataMap("CreatedWith", OrderItemEntity.CreatedWithProperty);
			maps.am_AddDataMap("LastModifiedAt", OrderItemEntity.LastModifiedAtProperty);
			maps.am_AddDataMap("LastModifiedBy", OrderItemEntity.LastModifiedByProperty);
			maps.am_AddDataMap("LastModifiedWith", OrderItemEntity.LastModifiedWithProperty);
			maps.am_AddDataMap(string.Format("{0}.{1}", OrderTableName, "InternalID"), OrderItemEntity.InternalID1Property, targetTable: OrderTableName);
			maps.am_AddDataMap(string.Format("{0}.{1}", ProductTableName, "InternalID"), OrderItemEntity.InternalID11Property, targetTable: ProductTableName);

			//TODO: OrderItemMaps Real Field Example
			//maps.am_AddDataMap("<Field Name>", OrderItemEntity.<Property Name>);
			//TODO: OrderItemMaps Virtual Field Example
			//maps.am_AddDataMap("<Field Name>", OrderItemEntity.<Property Name>, isVirtual: true);
			//TODO: OrderItemMaps Foreign Field Example
			//maps.am_AddDataMap(string.Format("{0}.{1}", "<Target Table Name>", "<Field Name>"), OrderItemEntity.<Property Name>, targetTable: "<Target Table Name>"); 
		  
			return maps.am_ToDictionary();
		}

	}
}