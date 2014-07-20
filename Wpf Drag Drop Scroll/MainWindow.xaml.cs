using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_Drag_Drop_Scroll
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Ellipse1_OnMouseDown(object sender, MouseButtonEventArgs e)
		{
			if( e.ButtonState== MouseButtonState.Pressed)
				DragDrop.DoDragDrop((DependencyObject) sender, "abc", DragDropEffects.All);
			
		}

	    private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
	    {
	        foreach (TreeViewItem it in this.treeView1.Items)
	        {
	            ExpandIt(it);
	        }
	    }

	    private void ExpandIt(TreeViewItem it)
	    {
            if (it != null)
            {
                it.IsExpanded = true;
                foreach (TreeViewItem item in it.Items)
                {
                    ExpandIt(item);
                }
            }
	        
	    }
	}
}
