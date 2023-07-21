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

namespace BOS.OrderItemDataEntity
{
	/// <summary>
	/// Represents data. Contains metadata that facilitates validation and advanced databinding.
	/// </summary>
	[DataContract]
	public class OrderItemEntity : AB_BusinessObjectEntityBase
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
			AB_BusinessObjectEntityBase.am_GetPropertyInfo(typeof(OrderItemEntity), typeof(BOS.EasyBuyCycles.Properties.MessageResource), typeof(MessageResource), typeof(BOS.EasyBuyCycles.Properties.DescriptionResource), typeof(DescriptionResource), out _EntityInfo); 
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

		[AB_ReceivedBroadcastDataMember("InternalID")]
		[Display(Name="ORDERINTERNALID", ResourceType=typeof(DescriptionResource))]
		[AB_Length(9)]
		[DataMember]
		public int? OrderInternalID //Map Field: OrderInternalID
		{
			get { return am_GetPropertyValue(OrderInternalIDProperty); }
			set {  am_SetPropertyValue(OrderInternalIDProperty, value); }
		}
		public static AB_PropertyMetadata<int?> OrderInternalIDProperty = am_CreatePropertyMetaData<int?>("OrderInternalID", DescriptionResource.ORDERINTERNALID, null); 

		[AB_ReceivedBroadcastDataMember("InternalID")]
		[Display(Name="PRODUCTINTERNALID", ResourceType=typeof(DescriptionResource))]
		[AB_Length(9)]
		[DataMember]
		public int? ProductInternalID //Map Field: ProductInternalID
		{
			get { return am_GetPropertyValue(ProductInternalIDProperty); }
			set {  am_SetPropertyValue(ProductInternalIDProperty, value); }
		}
		public static AB_PropertyMetadata<int?> ProductInternalIDProperty = am_CreatePropertyMetaData<int?>("ProductInternalID", DescriptionResource.PRODUCTINTERNALID, null); 

		[Display(Name="QUANTITY", ResourceType=typeof(DescriptionResource))]
		[AB_Length(4)]
		[DataMember]
		public int? Quantity //Map Field: Quantity
		{
			get { return am_GetPropertyValue(QuantityProperty); }
			set {  am_SetPropertyValue(QuantityProperty, value); }
		}
		public static AB_PropertyMetadata<int?> QuantityProperty = am_CreatePropertyMetaData<int?>("Quantity", DescriptionResource.QUANTITY, null); 

		[Display(Name="UNITPRICE", ResourceType=typeof(DescriptionResource))]
		[AB_Length(8)]
		[DataMember]
		public decimal? UnitPrice //Map Field: UnitPrice
		{
			get { return am_GetPropertyValue(UnitPriceProperty); }
			set {  am_SetPropertyValue(UnitPriceProperty, value); }
		}
		public static AB_PropertyMetadata<decimal?> UnitPriceProperty = am_CreatePropertyMetaData<decimal?>("UnitPrice", DescriptionResource.UNITPRICE, null); 

		[Display(Name="DISCOUNTPERCENT", ResourceType=typeof(DescriptionResource))]
		[AB_Length(4)]
		[DataMember]
		public decimal? DiscountPercent //Map Field: DiscountPercent
		{
			get { return am_GetPropertyValue(DiscountPercentProperty); }
			set {  am_SetPropertyValue(DiscountPercentProperty, value); }
		}
		public static AB_PropertyMetadata<decimal?> DiscountPercentProperty = am_CreatePropertyMetaData<decimal?>("DiscountPercent", DescriptionResource.DISCOUNTPERCENT, null); 

		[Display(Name="MEMO", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string Memo //Map Field: Memo
		{
			get { return am_GetPropertyValue(MemoProperty); }
			set {  am_SetPropertyValue(MemoProperty, value); }
		}
		public static AB_PropertyMetadata<string> MemoProperty = am_CreatePropertyMetaData<string>("Memo", DescriptionResource.MEMO, null); 

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

		[AB_DropdownDisplay("~/Views/Order/_OrderDropdown.cshtml", new string[] { "Source: InternalID ,Target: OrderInternalID" }, ap_ShowNewButton = true, ap_ShowOpenButton = true, ap_ShowSearchButton = true)]
		[Display(Name="INTERNALID1", ResourceType=typeof(DescriptionResource))]
		[AB_Length(9)]
		[DataMember]
		public int? InternalID1 //Map Field: Order.InternalID
		{
			get { return am_GetPropertyValue(InternalID1Property); }
			set {  am_SetPropertyValue(InternalID1Property, value); }
		}
		public static AB_PropertyMetadata<int?> InternalID1Property = am_CreatePropertyMetaData<int?>("InternalID1", DescriptionResource.INTERNALID1, null); 

		[AB_DropdownDisplay("~/Views/Product/_ProductDropdown.cshtml", new string[] { "Source: InternalID ,Target: ProductInternalID" }, ap_ShowNewButton = true, ap_ShowOpenButton = true, ap_ShowSearchButton = true)]
		[Display(Name="INTERNALID11", ResourceType=typeof(DescriptionResource))]
		[AB_Length(9)]
		[DataMember]
		public int? InternalID11 //Map Field: Product.InternalID
		{
			get { return am_GetPropertyValue(InternalID11Property); }
			set {  am_SetPropertyValue(InternalID11Property, value); }
		}
		public static AB_PropertyMetadata<int?> InternalID11Property = am_CreatePropertyMetaData<int?>("InternalID11", DescriptionResource.INTERNALID11, null); 

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
					return "Order Item - ";
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
		static OrderItemEntity()
		{
			RG_DoStaticInit();
		}
		
	   
	}
}