//===============================================================================================
// <A4DN_GeneratedInformation>
// This code was generated using the Accelerator for .Net Code Generator.
// <A4DN_Template Name="WPF.Module.ContentWindow.t4" Version="8.0.0.75" GeneratedDate="7/21/2023" />
// </A4DN_GeneratedInformation>
//===============================================================================================
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using A4DN.Core.WPF.Base;
using A4DN.Core.BOS.DataController;
using A4DN.Core.BOS.ViewModel;
using BOS.OrderViewModel;
using BOS.OrderDataEntity;
using BOS.OrderDataMaps;

namespace WPF.Order
{
	/// <summary>
	/// Content Window for the module. Contains areas to handle commands before and after the parent has handled them. Interacts with the ViewModel.
	/// </summary>
	public partial class  OrderExpContent : AB_ContentWindowBase
	{
		OrderVM _ViewModel; 

		/// <summary>
		/// Type initializer / static constructor
		/// </summary>
		static OrderExpContent()
		{
			RG_StaticInit();
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public OrderExpContent(AB_VisualComponentInitializationArgs initializationArgs)
			: base(initializationArgs) {  }


		/// <summary>
		/// Initializes static members
		/// </summary>
		private static void RG_StaticInit()
		{
			// Enroll Culture Resource
			AB_SystemController.ap_SystemPropertyMethods.am_EnrollResourceCultureInfo(typeof(OrderExpContent), WPF.EasyBuyCycles.Views.Properties.Resources.Culture);
		}
		
		/// <summary>
		/// Sets properties to change the parent initialization. This method is called during the parent's constructor.
		/// If it is necessary to override what is set here or set additional parent properties, use <c>am_SetParentProperties</c>.
		/// </summary>
		private void RG_SetParentProperties()
		{
			// Call Initialize Component im order to access XAML objects in Code Behind
			InitializeComponent();
			
			ap_DataMaps = new OrderMaps().ap_FieldMaps;
			_ViewModel = FindResource("OrderVM") as OrderVM;
			ap_ViewModel = _ViewModel;
			ap_MainDetailType = typeof(OrderDetail);
		}
		
		/// <summary>
		/// This method is called during the parent's constructor. Set properties to change the parent initialization.
		/// </summary>
		protected override void am_SetParentProperties()
		{
			RG_SetParentProperties();
		}

		/// <summary>
		/// This method is called after the Loaded event. At this point the XAML objects can be accessed.
		/// </summary>
		protected override void am_OnInitialized()
		{
			base.am_OnInitialized();
		   
		}
		
		/// <summary>
		/// This method is called before the base object has processed the command.
		/// </summary>
		protected override void am_BeforeProcessCommand(AB_Command command, RoutedEventArgs e)
		{
			// Access the Current Selected Entity
		    //var selectedEntity = ap_SelectedEntity as OrderEntity;
            //if (selectedEntity != null)
            //{
            //    var myVariable = selectedEntity.<Property>;
            //}

			switch (command.ap_CommandID)
			{
				//case "<CommandID>":

                //    Do Something ...

              	//    set e.Handled to true to prevent the higher level from executing its command click logic and to prevent further processing by the Detail.
                //    e.Handled = true;
                
                //    break;

				default:
					break;
			}
			
		}

		/// <summary>
		/// This method is called after the base object has processed the command.
		/// </summary>
		protected override void am_AfterProcessCommand(AB_Command command, RoutedEventArgs e)
		{
			
			switch (command.ap_CommandID)
			{
				//case "<CommandID>":

                //    Do Something ...

              	//	  set e.Handled to true to prevent further processing by the Detail.
                //    e.Handled = true;
                
                //    break;

				default:
					break;
			}
			
		}
	}
}