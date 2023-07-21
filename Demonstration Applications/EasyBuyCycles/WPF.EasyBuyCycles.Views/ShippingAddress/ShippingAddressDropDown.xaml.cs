//===============================================================================================
// <A4DN_GeneratedInformation>
// This code was generated using the Accelerator for .Net Code Generator.
// <A4DN_Template Name="WPF.Module.DropDown.t4" Version="8.0.0.75" GeneratedDate="7/21/2023" />
// </A4DN_GeneratedInformation>
//===============================================================================================
using System;
using System.Windows;
using A4DN.Core.WPF.Base;
using BOS.ShippingAddressViewModel;
using BOS.ShippingAddressDataEntity;
using BOS.ShippingAddressDataMaps;

namespace WPF.ShippingAddress
{
	/// <summary>
	/// Interaction logic for ShippingAddressDropDown.xaml
	/// </summary>
	public partial class  ShippingAddressDropDown : AB_DropDownBase
	{
		/// <summary>
		/// Dependency Property for Binding of foreign keys.  As this property is updated, a fetch will occur to load the drop down appropriately
		/// </summary>
 
		public static readonly DependencyProperty InternalIDProperty = DependencyProperty.Register("InternalID", typeof(int?), typeof(ShippingAddressDropDown), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new PropertyChangedCallback(AB_DropDownBase.IdChanged)));

        [AB_DropdownKeyProperty]
		public int? InternalID
		{
			get { return (int?)GetValue(InternalIDProperty); }
			set { SetValue(InternalIDProperty, value); }
		}
		/// <summary>
		/// Sets properties to change the parent initialization. This method is called during the parent's constructor.
		/// </summary>
		protected override void am_SetParentProperties()
		{
			InitializeComponent();
			
			// The SB Interface ID used to get a handle to the module entity in order show a Detail or Search and Select window
			ap_SbInterfaceReferenceID = "ShippingAddressDropDown";
			
			// An instance of the module-specific Busiess Process for performing IO to load the drop down
			ap_ViewModel = new ShippingAddressVM();
			
			// The type of detail to open if the user clicks the open button
			ap_DetailType = typeof(ShippingAddressDetail);

			// The default view to use when loading the drop down with multiple records
			ap_CurrentView = "ShippingAddress";
			
			//The name of the property that should be displayed in the Drop Down
			ap_ComboBoxDisplayMemberPath = ShippingAddressEntity.InternalIDProperty.ap_PropertyName;
			
			// The type of entity that will be loaded in this drop down
			ap_EntityType = typeof(ShippingAddressEntity);

			//Default Max Count
			ap_MaxCount = 25;

			//Pass references of all Dependency Properties to base class so they can be managed there.
			
			// Setting dependency property lists directly has been replaced with applying [AB_Dropdown*Property] attributes on property definitions
			//ap_KeyDependencyProperties = new DependencyProperty[] { InternalIDProperty};     
	

			// Set to true when there are multiple properties in ap_KeyDependencyProperties. 
			// If any are optional, set ap_IsOptionalForFetch flag in [AB_DropdownKeyProperty] attribute.
			ap_RequireAllKeysFilledForFetch = ap_KeyDependencyProperties.Length > 1;

			// Set to false when entire collection can load into the combo box popup
			// ap_StartLoadingFromSelectedItem = false;
		}

		
		/// <summary>
		/// This method is for setting keys via code behind.  If there are multiple keys in the file, a fetch will be done each time a key is 
		/// set unless this method is called. ap_RequireAllKeysFilledForFetch only helps when the keys are empty, not when they're changing non-null values.
		/// </summary>
		public void SetValue(int? InternalID)    
		{
			// Turn off property change event triggers
			ap_KeysPopulating = true;

			this.InternalID = InternalID;   
		
			// Turn on property change event triggers, and fire an event to respond to the changed keys.
			ap_KeysPopulating = false;
			am_OnIdChanged(new DependencyPropertyChangedEventArgs(ap_KeyDependencyProperties[0], null, ap_KeyDependencyProperties[0].Name));
		}
	}
}