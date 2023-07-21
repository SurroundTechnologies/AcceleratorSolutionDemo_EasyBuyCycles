//===============================================================================================
// <A4DN_GeneratedInformation>
// This code was generated using the Accelerator for .Net Code Generator.
// <A4DN_Template Name="BOS.Module.DataMaps.t4" Version="8.0.0.75" GeneratedDate="7/21/2023" />
// </A4DN_GeneratedInformation>
//===============================================================================================
using System.Collections.Generic;
using A4DN.Core.BOS.Base;
using SharedSystemProperties = BOS.EasyBuyCycles.Shared.Properties;
using BOS.ProductDataEntity;

namespace BOS.ProductDataMaps
{
	public class ProductMaps : AB_DataMaps
	{
		private const string ProductPrimaryTableName = "Product";

		public ProductMaps() : base() { }
		public ProductMaps(string qualifier) : base(qualifier) { }
		  
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
		 
			return relationshipMap;
		}
		

		/// <summary>
		/// Defines the maps for the Data Source Field Names and Entity Properties for module.
		/// </summary>
		public override Dictionary<string,AB_DataSourcePropertyReference> am_LoadFieldMaps(string qualifier)
		{	
			// Set the Primary File Name, Foreign fields will have to be mapped on a case-by-case basis
			ap_PrimaryTable = ProductPrimaryTableName;
			//Create a dictionary to hold the maps
			var maps = new AB_DataMapsDictionary(ap_PrimaryTable, qualifier);
		 
			maps.am_AddDataMap("InternalID", ProductEntity.InternalIDProperty);
			maps.am_AddDataMap("Code", ProductEntity.CodeProperty);
			maps.am_AddDataMap("Name", ProductEntity.NameProperty);
			maps.am_AddDataMap("Description", ProductEntity.DescriptionProperty);
			maps.am_AddDataMap("Category", ProductEntity.CategoryProperty);
			maps.am_AddDataMap("StandardCost", ProductEntity.StandardCostProperty);
			maps.am_AddDataMap("ListPrice", ProductEntity.ListPriceProperty);
			maps.am_AddDataMap("ReorderLevel", ProductEntity.ReorderLevelProperty);
			maps.am_AddDataMap("TargetLevel", ProductEntity.TargetLevelProperty);
			maps.am_AddDataMap("MinimumReorderQuantity", ProductEntity.MinimumReorderQuantityProperty);
			maps.am_AddDataMap("Discontinued", ProductEntity.DiscontinuedProperty);
			maps.am_AddDataMap("Memo", ProductEntity.MemoProperty);
			maps.am_AddDataMap("ImagePath", ProductEntity.ImagePathProperty);
			maps.am_AddDataMap("CreatedAt", ProductEntity.CreatedAtProperty);
			maps.am_AddDataMap("CreatedBy", ProductEntity.CreatedByProperty);
			maps.am_AddDataMap("CreatedWith", ProductEntity.CreatedWithProperty);
			maps.am_AddDataMap("LastModifiedAt", ProductEntity.LastModifiedAtProperty);
			maps.am_AddDataMap("LastModifiedBy", ProductEntity.LastModifiedByProperty);
			maps.am_AddDataMap("LastModifiedWith", ProductEntity.LastModifiedWithProperty);

			//TODO: ProductMaps Real Field Example
			//maps.am_AddDataMap("<Field Name>", ProductEntity.<Property Name>);
			//TODO: ProductMaps Virtual Field Example
			//maps.am_AddDataMap("<Field Name>", ProductEntity.<Property Name>, isVirtual: true);
			//TODO: ProductMaps Foreign Field Example
			//maps.am_AddDataMap(string.Format("{0}.{1}", "<Target Table Name>", "<Field Name>"), ProductEntity.<Property Name>, targetTable: "<Target Table Name>"); 
		  
			return maps.am_ToDictionary();
		}

	}
}