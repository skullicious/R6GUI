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
using System.Windows.Shapes;

namespace R6GUI
{
    /// <summary>
    /// Interaction logic for Platform.xaml
    /// </summary>
    public partial class Platform : Window
    {
        public Platform()
        {
            InitializeComponent();
        }

        public void PCButton_Click(object sender, RoutedEventArgs e)
        {

            ClassCollections.AppConfig.selectedPlatform = "pc";
            SearchPlayer searchPlayerWindow = new SearchPlayer();
            searchPlayerWindow.Show();
            this.Close();

        }

        public void XBOXButton_Click(object sender, RoutedEventArgs e)
        {
            ClassCollections.AppConfig.selectedPlatform = "xbox";
            SearchPlayer searchPlayerWindow = new SearchPlayer();
            searchPlayerWindow.Show();
            this.Close();

        }

        public void PSXButton_Click(object sender, RoutedEventArgs e)
        {
            ClassCollections.AppConfig.selectedPlatform = "ps";
            SearchPlayer searchPlayerWindow = new SearchPlayer();
            searchPlayerWindow.Show();
            this.Close();

        }
                  
        
    }
}
