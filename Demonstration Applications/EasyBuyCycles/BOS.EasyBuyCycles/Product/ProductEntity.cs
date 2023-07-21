//===============================================================================================
// <A4DN_GeneratedInformation>
// This code was generated using the Accelerator for .Net Code Generator.
// <A4DN_Template Name="BOS.Module.Entity.t4" Version="8.0.0.75" GeneratedDate="7/21/2023" />
// </A4DN_GeneratedInformation>
//===============================================================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using A4DN.Core.BOS.Base;
using BOS.EasyBuyCycles.Shared.Properties;
#if !SILVERLIGHT
using A4DN.Core.BOS.ValidationAttributes;  // Custom validation attributes
#endif

namespace BOS.ProductDataEntity
{
	/// <summary>
	/// Represents data. Contains metadata that facilitates validation and advanced databinding.
	/// </summary>
	[DataContract]
	public class ProductEntity : AB_BusinessObjectEntityBase
	{
		/// <summary>
		/// Entity information is defined in the lower level entity to maximize performance by making it static
		/// </summary>
		private static AB_EntityInfo _EntityInfo;
		/// <summary>
		/// Gets metadata information about the entity
		/// </summary>
		public override AB_EntityInfo ap_EntityInfo
		{
			get
			{
				return _EntityInfo;
			}

		}
				   
		/// <summary>
		/// Initializes static members
		/// </summary>				   
		static private void RG_DoStaticInit()
		{
			// Set Message and Description Primary and Secondary Resources. 
			AB_BusinessObjectEntityBase.am_GetPropertyInfo(typeof(ProductEntity), typeof(BOS.EasyBuyCycles.Properties.MessageResource), typeof(MessageResource), typeof(BOS.EasyBuyCycles.Properties.DescriptionResource), typeof(DescriptionResource), out _EntityInfo); 
		}  
		
		#region Properties

		[AB_Key]
		[AB_DoNotCopy]
		[AB_RequiredField]
		[Display(Name="INTERNALID", ResourceType=typeof(DescriptionResource))]
		[AB_Length(9)]
		[DataMember]
		public int? InternalID //Map Field: InternalID
		{
			get { return am_GetPropertyValue(InternalIDProperty); }
			set {  am_SetPropertyValue(InternalIDProperty, value); }
		}
		public static AB_PropertyMetadata<int?> InternalIDProperty = am_CreatePropertyMetaData<int?>("InternalID", DescriptionResource.INTERNALID, null); 

		[Display(Name="CODE", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string Code //Map Field: Code
		{
			get { return am_GetPropertyValue(CodeProperty); }
			set {  am_SetPropertyValue(CodeProperty, value); }
		}
		public static AB_PropertyMetadata<string> CodeProperty = am_CreatePropertyMetaData<string>("Code", DescriptionResource.CODE, null); 

		[Display(Name="NAME", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string Name //Map Field: Name
		{
			get { return am_GetPropertyValue(NameProperty); }
			set {  am_SetPropertyValue(NameProperty, value); }
		}
		public static AB_PropertyMetadata<string> NameProperty = am_CreatePropertyMetaData<string>("Name", DescriptionResource.NAME, null); 

		[Display(Name="DESCRIPTION", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string Description //Map Field: Description
		{
			get { return am_GetPropertyValue(DescriptionProperty); }
			set {  am_SetPropertyValue(DescriptionProperty, value); }
		}
		public static AB_PropertyMetadata<string> DescriptionProperty = am_CreatePropertyMetaData<string>("Description", DescriptionResource.DESCRIPTION, null); 

		[Display(Name="CATEGORY", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string Category //Map Field: Category
		{
			get { return am_GetPropertyValue(CategoryProperty); }
			set {  am_SetPropertyValue(CategoryProperty, value); }
		}
		public static AB_PropertyMetadata<string> CategoryProperty = am_CreatePropertyMetaData<string>("Category", DescriptionResource.CATEGORY, null); 

		[Display(Name="STANDARDCOST", ResourceType=typeof(DescriptionResource))]
		[AB_Length(10)]
		[DataMember]
		public decimal? StandardCost //Map Field: StandardCost
		{
			get { return am_GetPropertyValue(StandardCostProperty); }
			set {  am_SetPropertyValue(StandardCostProperty, value); }
		}
		public static AB_PropertyMetadata<decimal?> StandardCostProperty = am_CreatePropertyMetaData<decimal?>("StandardCost", DescriptionResource.STANDARDCOST, null); 

		[Display(Name="LISTPRICE", ResourceType=typeof(DescriptionResource))]
		[AB_Length(10)]
		[DataMember]
		public decimal? ListPrice //Map Field: ListPrice
		{
			get { return am_GetPropertyValue(ListPriceProperty); }
			set {  am_SetPropertyValue(ListPriceProperty, value); }
		}
		public static AB_PropertyMetadata<decimal?> ListPriceProperty = am_CreatePropertyMetaData<decimal?>("ListPrice", DescriptionResource.LISTPRICE, null); 

		[Display(Name="REORDERLEVEL", ResourceType=typeof(DescriptionResource))]
		[AB_Length(4)]
		[DataMember]
		public int? ReorderLevel //Map Field: ReorderLevel
		{
			get { return am_GetPropertyValue(ReorderLevelProperty); }
			set {  am_SetPropertyValue(ReorderLevelProperty, value); }
		}
		public static AB_PropertyMetadata<int?> ReorderLevelProperty = am_CreatePropertyMetaData<int?>("ReorderLevel", DescriptionResource.REORDERLEVEL, null); 

		[Display(Name="TARGETLEVEL", ResourceType=typeof(DescriptionResource))]
		[AB_Length(4)]
		[DataMember]
		public int? TargetLevel //Map Field: TargetLevel
		{
			get { return am_GetPropertyValue(TargetLevelProperty); }
			set {  am_SetPropertyValue(TargetLevelProperty, value); }
		}
		public static AB_PropertyMetadata<int?> TargetLevelProperty = am_CreatePropertyMetaData<int?>("TargetLevel", DescriptionResource.TARGETLEVEL, null); 

		[Display(Name="MINIMUMREORDERQUANTITY", ResourceType=typeof(DescriptionResource))]
		[AB_Length(4)]
		[DataMember]
		public int? MinimumReorderQuantity //Map Field: MinimumReorderQuantity
		{
			get { return am_GetPropertyValue(MinimumReorderQuantityProperty); }
			set {  am_SetPropertyValue(MinimumReorderQuantityProperty, value); }
		}
		public static AB_PropertyMetadata<int?> MinimumReorderQuantityProperty = am_CreatePropertyMetaData<int?>("MinimumReorderQuantity", DescriptionResource.MINIMUMREORDERQUANTITY, null); 

		[Display(Name="DISCONTINUED", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string Discontinued //Map Field: Discontinued
		{
			get { return am_GetPropertyValue(DiscontinuedProperty); }
			set {  am_SetPropertyValue(DiscontinuedProperty, value); }
		}
		public static AB_PropertyMetadata<string> DiscontinuedProperty = am_CreatePropertyMetaData<string>("Discontinued", DescriptionResource.DISCONTINUED, null); 

		[Display(Name="MEMO", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string Memo //Map Field: Memo
		{
			get { return am_GetPropertyValue(MemoProperty); }
			set {  am_SetPropertyValue(MemoProperty, value); }
		}
		public static AB_PropertyMetadata<string> MemoProperty = am_CreatePropertyMetaData<string>("Memo", DescriptionResource.MEMO, null); 

		[Display(Name="IMAGEPATH", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string ImagePath //Map Field: ImagePath
		{
			get { return am_GetPropertyValue(ImagePathProperty); }
			set {  am_SetPropertyValue(ImagePathProperty, value); }
		}
		public static AB_PropertyMetadata<string> ImagePathProperty = am_CreatePropertyMetaData<string>("ImagePath", DescriptionResource.IMAGEPATH, null); 

		[Display(Name="CREATEDAT", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public TimeSpan? CreatedAt //Map Field: CreatedAt
		{
			get { return am_GetPropertyValue(CreatedAtProperty); }
			set {  am_SetPropertyValue(CreatedAtProperty, value); }
		}
		public static AB_PropertyMetadata<TimeSpan?> CreatedAtProperty = am_CreatePropertyMetaData<TimeSpan?>("CreatedAt", DescriptionResource.CREATEDAT, null); 

		[Display(Name="CREATEDBY", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string CreatedBy //Map Field: CreatedBy
		{
			get { return am_GetPropertyValue(CreatedByProperty); }
			set {  am_SetPropertyValue(CreatedByProperty, value); }
		}
		public static AB_PropertyMetadata<string> CreatedByProperty = am_CreatePropertyMetaData<string>("CreatedBy", DescriptionResource.CREATEDBY, null); 

		[Display(Name="CREATEDWITH", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string CreatedWith //Map Field: CreatedWith
		{
			get { return am_GetPropertyValue(CreatedWithProperty); }
			set {  am_SetPropertyValue(CreatedWithProperty, value); }
		}
		public static AB_PropertyMetadata<string> CreatedWithProperty = am_CreatePropertyMetaData<string>("CreatedWith", DescriptionResource.CREATEDWITH, null); 

		[Display(Name="LASTMODIFIEDAT", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public TimeSpan? LastModifiedAt //Map Field: LastModifiedAt
		{
			get { return am_GetPropertyValue(LastModifiedAtProperty); }
			set {  am_SetPropertyValue(LastModifiedAtProperty, value); }
		}
		public static AB_PropertyMetadata<TimeSpan?> LastModifiedAtProperty = am_CreatePropertyMetaData<TimeSpan?>("LastModifiedAt", DescriptionResource.LASTMODIFIEDAT, null); 

		[Display(Name="LASTMODIFIEDBY", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string LastModifiedBy //Map Field: LastModifiedBy
		{
			get { return am_GetPropertyValue(LastModifiedByProperty); }
			set {  am_SetPropertyValue(LastModifiedByProperty, value); }
		}
		public static AB_PropertyMetadata<string> LastModifiedByProperty = am_CreatePropertyMetaData<string>("LastModifiedBy", DescriptionResource.LASTMODIFIEDBY, null); 

		[Display(Name="LASTMODIFIEDWITH", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string LastModifiedWith //Map Field: LastModifiedWith
		{
			get { return am_GetPropertyValue(LastModifiedWithProperty); }
			set {  am_SetPropertyValue(LastModifiedWithProperty, value); }
		}
		public static AB_PropertyMetadata<string> LastModifiedWithProperty = am_CreatePropertyMetaData<string>("LastModifiedWith", DescriptionResource.LASTMODIFIEDWITH, null); 

		#endregion //Properties
					 
		#region Property Overrides
		
		// Title
		public override string ap_Title
		{
			get
			{
				if (string.IsNullOrEmpty(base.ap_Title))
				{
					StringBuilder title = new StringBuilder();
					switch (ap_TitleMode)
					{
						case AB_TitleMode.New:
						case AB_TitleMode.NewFor:
						case AB_TitleMode.Copy:
							title.AppendFormat("{0}", MessageResource.TITLENEW);
							break;
						case AB_TitleMode.Display:
							title.AppendFormat("{0}", MessageResource.TITLEDISPLAY);
							break;
						case AB_TitleMode.Open:
							title.AppendFormat("{0}", MessageResource.TITLEOPEN);
							break;
						case AB_TitleMode.Subbrowser:
							title.AppendFormat("{0}", MessageResource.TITLESUBBROWSER);
							break;
						case AB_TitleMode.Default:
							title.AppendFormat("{0} ", MessageResource.TITLEOPEN);
							break;
					}
 
					if (InternalID.HasValue)
					{
						title.AppendFormat(" - {0}", InternalID.Value);
					}
  
					return title.ToString();
				}
				return base.ap_Title;
			}
			set
			{
				base.ap_Title = value;
			}
		}

		// Message Field
		public override string ap_MessageField
		{
			get
			{
				if (string.IsNullOrEmpty(base.ap_MessageField))
				{
					return "\"" + ap_Title + "\"";
				}

				return base.ap_MessageField;
			}
			set
			{
				base.ap_MessageField = value;
			}
		}
		
		// Unique Name
		public override string ap_UniqueName
		{
			get
			{
				if (string.IsNullOrEmpty(base.ap_UniqueName))
				{
					return "Product - ";
				}

				return base.ap_UniqueName;
			}
			set
			{
				base.ap_UniqueName = value;
			}
		}
		
		#endregion //Property Overrides
		
		/// <summary>
		/// Static constructor
		/// </summary>
		static ProductEntity()
		{
			RG_DoStaticInit();
		}
		
	   
	}
}