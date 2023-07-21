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

namespace BOS.CustomerDataEntity
{
	/// <summary>
	/// Represents data. Contains metadata that facilitates validation and advanced databinding.
	/// </summary>
	[DataContract]
	public class CustomerEntity : AB_BusinessObjectEntityBase
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
			AB_BusinessObjectEntityBase.am_GetPropertyInfo(typeof(CustomerEntity), typeof(BOS.EasyBuyCycles.Properties.MessageResource), typeof(MessageResource), typeof(BOS.EasyBuyCycles.Properties.DescriptionResource), typeof(DescriptionResource), out _EntityInfo); 
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
		[Display(Name="PARENTINTERNALID", ResourceType=typeof(DescriptionResource))]
		[AB_Length(9)]
		[DataMember]
		public int? ParentInternalID //Map Field: ParentInternalID
		{
			get { return am_GetPropertyValue(ParentInternalIDProperty); }
			set {  am_SetPropertyValue(ParentInternalIDProperty, value); }
		}
		public static AB_PropertyMetadata<int?> ParentInternalIDProperty = am_CreatePropertyMetaData<int?>("ParentInternalID", DescriptionResource.PARENTINTERNALID, null); 

		[Display(Name="PARENTRELATIONSHIP", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string ParentRelationship //Map Field: ParentRelationship
		{
			get { return am_GetPropertyValue(ParentRelationshipProperty); }
			set {  am_SetPropertyValue(ParentRelationshipProperty, value); }
		}
		public static AB_PropertyMetadata<string> ParentRelationshipProperty = am_CreatePropertyMetaData<string>("ParentRelationship", DescriptionResource.PARENTRELATIONSHIP, null); 

		[Display(Name="NAME", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string Name //Map Field: Name
		{
			get { return am_GetPropertyValue(NameProperty); }
			set {  am_SetPropertyValue(NameProperty, value); }
		}
		public static AB_PropertyMetadata<string> NameProperty = am_CreatePropertyMetaData<string>("Name", DescriptionResource.NAME, null); 

		[Display(Name="LEGALNAME", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string LegalName //Map Field: LegalName
		{
			get { return am_GetPropertyValue(LegalNameProperty); }
			set {  am_SetPropertyValue(LegalNameProperty, value); }
		}
		public static AB_PropertyMetadata<string> LegalNameProperty = am_CreatePropertyMetaData<string>("LegalName", DescriptionResource.LEGALNAME, null); 

		[Display(Name="CONTACTLASTNAME", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string ContactLastName //Map Field: ContactLastName
		{
			get { return am_GetPropertyValue(ContactLastNameProperty); }
			set {  am_SetPropertyValue(ContactLastNameProperty, value); }
		}
		public static AB_PropertyMetadata<string> ContactLastNameProperty = am_CreatePropertyMetaData<string>("ContactLastName", DescriptionResource.CONTACTLASTNAME, null); 

		[Display(Name="CONTACTFIRSTNAME", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string ContactFirstName //Map Field: ContactFirstName
		{
			get { return am_GetPropertyValue(ContactFirstNameProperty); }
			set {  am_SetPropertyValue(ContactFirstNameProperty, value); }
		}
		public static AB_PropertyMetadata<string> ContactFirstNameProperty = am_CreatePropertyMetaData<string>("ContactFirstName", DescriptionResource.CONTACTFIRSTNAME, null); 

		[Display(Name="CONTACTMIDDLENAME", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string ContactMiddleName //Map Field: ContactMiddleName
		{
			get { return am_GetPropertyValue(ContactMiddleNameProperty); }
			set {  am_SetPropertyValue(ContactMiddleNameProperty, value); }
		}
		public static AB_PropertyMetadata<string> ContactMiddleNameProperty = am_CreatePropertyMetaData<string>("ContactMiddleName", DescriptionResource.CONTACTMIDDLENAME, null); 

		[Display(Name="CONTACTNICKNAME", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string ContactNickName //Map Field: ContactNickName
		{
			get { return am_GetPropertyValue(ContactNickNameProperty); }
			set {  am_SetPropertyValue(ContactNickNameProperty, value); }
		}
		public static AB_PropertyMetadata<string> ContactNickNameProperty = am_CreatePropertyMetaData<string>("ContactNickName", DescriptionResource.CONTACTNICKNAME, null); 

		[Display(Name="BILLINGADDRESS1", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string BillingAddress1 //Map Field: BillingAddress1
		{
			get { return am_GetPropertyValue(BillingAddress1Property); }
			set {  am_SetPropertyValue(BillingAddress1Property, value); }
		}
		public static AB_PropertyMetadata<string> BillingAddress1Property = am_CreatePropertyMetaData<string>("BillingAddress1", DescriptionResource.BILLINGADDRESS1, null); 

		[Display(Name="BILLINGADDRESS2", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string BillingAddress2 //Map Field: BillingAddress2
		{
			get { return am_GetPropertyValue(BillingAddress2Property); }
			set {  am_SetPropertyValue(BillingAddress2Property, value); }
		}
		public static AB_PropertyMetadata<string> BillingAddress2Property = am_CreatePropertyMetaData<string>("BillingAddress2", DescriptionResource.BILLINGADDRESS2, null); 

		[Display(Name="BILLINGADDRESS3", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string BillingAddress3 //Map Field: BillingAddress3
		{
			get { return am_GetPropertyValue(BillingAddress3Property); }
			set {  am_SetPropertyValue(BillingAddress3Property, value); }
		}
		public static AB_PropertyMetadata<string> BillingAddress3Property = am_CreatePropertyMetaData<string>("BillingAddress3", DescriptionResource.BILLINGADDRESS3, null); 

		[Display(Name="BILLINGPOSTALCODE", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string BillingPostalCode //Map Field: BillingPostalCode
		{
			get { return am_GetPropertyValue(BillingPostalCodeProperty); }
			set {  am_SetPropertyValue(BillingPostalCodeProperty, value); }
		}
		public static AB_PropertyMetadata<string> BillingPostalCodeProperty = am_CreatePropertyMetaData<string>("BillingPostalCode", DescriptionResource.BILLINGPOSTALCODE, null); 

		[Display(Name="BILLINGCOUNTRY", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string BillingCountry //Map Field: BillingCountry
		{
			get { return am_GetPropertyValue(BillingCountryProperty); }
			set {  am_SetPropertyValue(BillingCountryProperty, value); }
		}
		public static AB_PropertyMetadata<string> BillingCountryProperty = am_CreatePropertyMetaData<string>("BillingCountry", DescriptionResource.BILLINGCOUNTRY, null); 

		[Display(Name="TELEPHONE", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string Telephone //Map Field: Telephone
		{
			get { return am_GetPropertyValue(TelephoneProperty); }
			set {  am_SetPropertyValue(TelephoneProperty, value); }
		}
		public static AB_PropertyMetadata<string> TelephoneProperty = am_CreatePropertyMetaData<string>("Telephone", DescriptionResource.TELEPHONE, null); 

		[Display(Name="EMAIL", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string Email //Map Field: Email
		{
			get { return am_GetPropertyValue(EmailProperty); }
			set {  am_SetPropertyValue(EmailProperty, value); }
		}
		public static AB_PropertyMetadata<string> EmailProperty = am_CreatePropertyMetaData<string>("Email", DescriptionResource.EMAIL, null); 

		[Display(Name="MEMO", ResourceType=typeof(DescriptionResource))]
		[DataMember]
		public string Memo //Map Field: Memo
		{
			get { return am_GetPropertyValue(MemoProperty); }
			set {  am_SetPropertyValue(MemoProperty, value); }
		}
		public static AB_PropertyMetadata<string> MemoProperty = am_CreatePropertyMetaData<string>("Memo", DescriptionResource.MEMO, null); 

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

		[AB_DropdownDisplay("~/Views/Customer/_CustomerDropdown.cshtml", new string[] { "Source: InternalID ,Target: ParentInternalID" }, ap_ShowNewButton = true, ap_ShowOpenButton = true, ap_ShowSearchButton = true)]
		[Display(Name="INTERNALID1", ResourceType=typeof(DescriptionResource))]
		[AB_Length(9)]
		[DataMember]
		public int? InternalID1 //Map Field: Customer.InternalID
		{
			get { return am_GetPropertyValue(InternalID1Property); }
			set {  am_SetPropertyValue(InternalID1Property, value); }
		}
		public static AB_PropertyMetadata<int?> InternalID1Property = am_CreatePropertyMetaData<int?>("InternalID1", DescriptionResource.INTERNALID1, null); 

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
					return "Customer - ";
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
		static CustomerEntity()
		{
			RG_DoStaticInit();
		}
		
	   
	}
}