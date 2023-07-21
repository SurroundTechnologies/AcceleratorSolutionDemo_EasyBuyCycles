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

namespace BOS.OrderDataEntity
{
	/// <summary>
	/// Represents data. Contains metadata that facilitates validation and advanced databinding.
	/// </summary>
	[DataContract]
	public class OrderEntity : AB_BusinessObjectEntityBase
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
			AB_BusinessObjectEntityBase.am_GetPropertyInfo(typeof(OrderEntity), typeof(BOS.EasyBuyCycles.Properties.MessageResource), typeof(MessageResource), typeof(BOS.EasyBuyCycles.Properties.DescriptionResource), typeof(DescriptionResource), out _EntityInfo); 
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
		[Display(Name="CUSTOMERINTERNALID", ResourceType=typeof(DescriptionResource))]
		[AB_Length(9)]
		[DataMember]
		public int? CustomerInternalID //Map Field: CustomerInternalID
		{
			get { return am_GetPropertyValue(CustomerInternalIDProperty); }
			set {  am_SetPropertyValue(CustomerInternalIDProperty, value); }
		}
		public static AB_PropertyMetadata<int?> CustomerInternalIDProperty = am_CreatePropertyMetaData<int?>("CustomerInternalID", DescriptionResource.CUSTOMERINTERNALID, null); 

		[Display(Name="ORDERDATETIME", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public TimeSpan? OrderDateTime //Map Field: OrderDateTime
		{
			get { return am_GetPropertyValue(OrderDateTimeProperty); }
			set {  am_SetPropertyValue(OrderDateTimeProperty, value); }
		}
		public static AB_PropertyMetadata<TimeSpan?> OrderDateTimeProperty = am_CreatePropertyMetaData<TimeSpan?>("OrderDateTime", DescriptionResource.ORDERDATETIME, null); 

		[Display(Name="PURCHASEORDERNUMBER", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string PurchaseOrderNumber //Map Field: PurchaseOrderNumber
		{
			get { return am_GetPropertyValue(PurchaseOrderNumberProperty); }
			set {  am_SetPropertyValue(PurchaseOrderNumberProperty, value); }
		}
		public static AB_PropertyMetadata<string> PurchaseOrderNumberProperty = am_CreatePropertyMetaData<string>("PurchaseOrderNumber", DescriptionResource.PURCHASEORDERNUMBER, null); 

		[Display(Name="WAREHOUSEINTERNALID", ResourceType=typeof(DescriptionResource))]
		[AB_Length(9)]
		[DataMember]
		public int? WarehouseInternalID //Map Field: WarehouseInternalID
		{
			get { return am_GetPropertyValue(WarehouseInternalIDProperty); }
			set {  am_SetPropertyValue(WarehouseInternalIDProperty, value); }
		}
		public static AB_PropertyMetadata<int?> WarehouseInternalIDProperty = am_CreatePropertyMetaData<int?>("WarehouseInternalID", DescriptionResource.WAREHOUSEINTERNALID, null); 

		[Display(Name="WAREHOUSENAME", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string WarehouseName //Map Field: WarehouseName
		{
			get { return am_GetPropertyValue(WarehouseNameProperty); }
			set {  am_SetPropertyValue(WarehouseNameProperty, value); }
		}
		public static AB_PropertyMetadata<string> WarehouseNameProperty = am_CreatePropertyMetaData<string>("WarehouseName", DescriptionResource.WAREHOUSENAME, null); 

		[Display(Name="DELIVERYMEMO", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string DeliveryMemo //Map Field: DeliveryMemo
		{
			get { return am_GetPropertyValue(DeliveryMemoProperty); }
			set {  am_SetPropertyValue(DeliveryMemoProperty, value); }
		}
		public static AB_PropertyMetadata<string> DeliveryMemoProperty = am_CreatePropertyMetaData<string>("DeliveryMemo", DescriptionResource.DELIVERYMEMO, null); 

		[AB_ReceivedBroadcastDataMember("InternalID")]
		[Display(Name="SHIPPINGADDRESSINTERNALID", ResourceType=typeof(DescriptionResource))]
		[AB_Length(9)]
		[DataMember]
		public int? ShippingAddressInternalID //Map Field: ShippingAddressInternalID
		{
			get { return am_GetPropertyValue(ShippingAddressInternalIDProperty); }
			set {  am_SetPropertyValue(ShippingAddressInternalIDProperty, value); }
		}
		public static AB_PropertyMetadata<int?> ShippingAddressInternalIDProperty = am_CreatePropertyMetaData<int?>("ShippingAddressInternalID", DescriptionResource.SHIPPINGADDRESSINTERNALID, null); 

		[Display(Name="ORDERMEMO", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string OrderMemo //Map Field: OrderMemo
		{
			get { return am_GetPropertyValue(OrderMemoProperty); }
			set {  am_SetPropertyValue(OrderMemoProperty, value); }
		}
		public static AB_PropertyMetadata<string> OrderMemoProperty = am_CreatePropertyMetaData<string>("OrderMemo", DescriptionResource.ORDERMEMO, null); 

		[Display(Name="STATUS", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string Status //Map Field: Status
		{
			get { return am_GetPropertyValue(StatusProperty); }
			set {  am_SetPropertyValue(StatusProperty, value); }
		}
		public static AB_PropertyMetadata<string> StatusProperty = am_CreatePropertyMetaData<string>("Status", DescriptionResource.STATUS, null); 

		[Display(Name="SALESPERSONINTERNALID", ResourceType=typeof(DescriptionResource))]
		[AB_Length(9)]
		[DataMember]
		public int? SalesPersonInternalID //Map Field: SalesPersonInternalID
		{
			get { return am_GetPropertyValue(SalesPersonInternalIDProperty); }
			set {  am_SetPropertyValue(SalesPersonInternalIDProperty, value); }
		}
		public static AB_PropertyMetadata<int?> SalesPersonInternalIDProperty = am_CreatePropertyMetaData<int?>("SalesPersonInternalID", DescriptionResource.SALESPERSONINTERNALID, null); 

		[Display(Name="SALESPERSONNAME", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string SalesPersonName //Map Field: SalesPersonName
		{
			get { return am_GetPropertyValue(SalesPersonNameProperty); }
			set {  am_SetPropertyValue(SalesPersonNameProperty, value); }
		}
		public static AB_PropertyMetadata<string> SalesPersonNameProperty = am_CreatePropertyMetaData<string>("SalesPersonName", DescriptionResource.SALESPERSONNAME, null); 

		[Display(Name="PURCHASEPOINTS", ResourceType=typeof(DescriptionResource))]
		[AB_Length(8)]
		[DataMember]
		public int? PurchasePoints //Map Field: PurchasePoints
		{
			get { return am_GetPropertyValue(PurchasePointsProperty); }
			set {  am_SetPropertyValue(PurchasePointsProperty, value); }
		}
		public static AB_PropertyMetadata<int?> PurchasePointsProperty = am_CreatePropertyMetaData<int?>("PurchasePoints", DescriptionResource.PURCHASEPOINTS, null); 

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

		[AB_DropdownDisplay("~/Views/Customer/_CustomerDropdown.cshtml", new string[] { "Source: InternalID ,Target: CustomerInternalID" }, ap_ShowNewButton = true, ap_ShowOpenButton = true, ap_ShowSearchButton = true)]
		[Display(Name="INTERNALID1", ResourceType=typeof(DescriptionResource))]
		[AB_Length(9)]
		[DataMember]
		public int? InternalID1 //Map Field: Customer.InternalID
		{
			get { return am_GetPropertyValue(InternalID1Property); }
			set {  am_SetPropertyValue(InternalID1Property, value); }
		}
		public static AB_PropertyMetadata<int?> InternalID1Property = am_CreatePropertyMetaData<int?>("InternalID1", DescriptionResource.INTERNALID1, null); 

		[AB_DropdownDisplay("~/Views/ShippingAddress/_ShippingAddressDropdown.cshtml", new string[] { "Source: InternalID ,Target: ShippingAddressInternalID" }, ap_ShowNewButton = true, ap_ShowOpenButton = true, ap_ShowSearchButton = true)]
		[Display(Name="INTERNALID11", ResourceType=typeof(DescriptionResource))]
		[AB_Length(9)]
		[DataMember]
		public int? InternalID11 //Map Field: ShippingAddress.InternalID
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
					return "Order - ";
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
		static OrderEntity()
		{
			RG_DoStaticInit();
		}
		
	   
	}
}