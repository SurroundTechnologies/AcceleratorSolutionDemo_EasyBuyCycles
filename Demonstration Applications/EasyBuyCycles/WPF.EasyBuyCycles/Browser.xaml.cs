//===============================================================================================
// <A4DN_GeneratedInformation>
// This code was generated using the Accelerator for .Net Code Generator.
// <A4DN_Template Name="WPF.System.Browser.t4" Version="8.0.0.75" GeneratedDate="7/21/2023" />
// </A4DN_GeneratedInformation>
//===============================================================================================
using System.Windows;
using A4DN.Core.WPF.Base;
using A4DN.Core.BOS.ViewModel;
using WPF.EasyBuyCycles;

namespace WPF.EasyBuyCycles
{
	/// <summary>
	/// Interaction logic for Browser.xaml
	/// </summary>
	public partial class Browser : AB_Browser
	{
		public Browser()
		{
			// Set the Splash Window Type
			ap_SplashWindowType = typeof(Splash);

			// TODO: Image for Wallpaper used as background when there are not any Module Explorer Tabs open
			// Set the image name and any other settings to get the desired look.
			// ap_WallpaperImageName = "MyWallPaper.jpg";
			// ap_Wallpaper.Margin = new Thickness(50, 0, 50, 0);
			// ap_Wallpaper.Width = ...;		   

			InitializeComponent();

		}        
		
		// Before Command Clicked
		// *** This method is called before the Base object has processed the command.
		//=============================================================
		protected override void am_BeforeProcessCommand(AB_Command command, RoutedEventArgs e)
		{
			
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


		// After Command Clicked
		// *** This method is called After the Base object has processed the command.
		//=============================================================
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