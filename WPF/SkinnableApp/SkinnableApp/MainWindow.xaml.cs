using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace SkinnableApp
{
	public partial class MainWindow : Window
    {
        public MainWindow()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("CTOR Exception: " + ex.Message);
            }


            //this.DataContext = new //

			// Load the default skin.
			Grid mainGrid = this.Content as Grid;

			MenuItem item = mainGrid.ContextMenu.Items[2] as MenuItem;
            this.ApplySkinFromMenuItem(item);
        }

		void OnMenuItemClick(object sender, RoutedEventArgs e)
		{
		//	MenuItem item = e.OriginalSource as MenuItem;
            MenuItem item2 = (MenuItem)e.OriginalSource ;

            if (item2 != null)
            {
                // Update the checked state of the menu items.
                Grid mainGrid = this.Content as Grid;
                if (mainGrid != null)
                {
                    foreach (MenuItem mi in mainGrid.ContextMenu.Items)
                    {
                        mi.IsChecked = (mi == item2);
                    }
                    // Load the selected skin.
                    this.ApplySkinFromMenuItem(item2);
                }
            }
		}

		private void ApplySkinFromMenuItem(MenuItem item)
		{
			// Get a relative path to the ResourceDictionary which
			// contains the selected skin.
			string skinDictPath = item.Tag as string;
			Uri skinDictUri = new Uri(skinDictPath, UriKind.Relative);


            // Tell the Application to load the skin resources.

            DemoApp app = Application.Current as DemoApp;
			app.ApplySkin(skinDictUri);
		}
    }
}