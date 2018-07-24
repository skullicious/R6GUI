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



namespace R6GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }
              
        
        public void EmeaButton_Click(object sender, RoutedEventArgs e)
        {

            ClassCollections.AppConfig.selectedRegion = "emea";
            Platform platformWindow = new Platform();
            platformWindow.Show();           
            this.Close();
            
        }

        public void ApacButton_Click(object sender, RoutedEventArgs e)
        {
            ClassCollections.AppConfig.selectedRegion = "apac";
            Platform platformWindow = new Platform();
            platformWindow.Show();
            this.Close();

        }

        public void NcsaButton_Click(object sender, RoutedEventArgs e)
        {
            ClassCollections.AppConfig.selectedRegion = "ncsa";
            Platform platformWindow = new Platform();
            platformWindow.Show();
            this.Close();

            
        }

        
        
    }
}
