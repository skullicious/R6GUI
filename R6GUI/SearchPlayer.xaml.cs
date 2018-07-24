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
using Newtonsoft.Json;

namespace R6GUI
{
    /// <summary>
    /// Interaction logic for Platform.xaml
    /// </summary>
    public partial class SearchPlayer : Window
    {
        public SearchPlayer()
      

       {

           InitializeComponent();

       }


        


        public void SearchButton_Click(object sender, RoutedEventArgs e)
        {



            ClassCollections.AppConfig.selectedName = this.SearchText.Text;

       ClassCollections.AppObject player = new ClassCollections.AppObject();

           




            if (Engine.IsPlayerUnique())
                {
                    MessageBox.Show("Name unique!");

                      Engine.CreatePlayerObject(player);

                        if (Engine.PlayerIsRanked(player))
                         {

                              double regionMmr = Engine.GetRegionMmr(player, ClassCollections.AppConfig.selectedRegion);

                             string calculatedRank = Engine.CalculateRank(regionMmr);

                              MessageBox.Show(calculatedRank);

                             DisplayRank displayRankWindow = new DisplayRank();
                              displayRankWindow.Show();
                                this.Close();

                         }

                }

                else

                {
                    MessageBox.Show("Name Not Unique!");
                    PickPlayer pickPlayerWindow = new PickPlayer();
                    pickPlayerWindow.Show();
                    this.Close();
                                                    
                }
                                  
                     
        }
    }

    
 


    public static class Engine

    {
        
        public static bool IsPlayerUnique()
        {
            // Check against web service
            string output = HTTPConnector.HttpClientConnector.TestMethod(ClassCollections.AppConfig.selectedName, ClassCollections.AppConfig.selectedPlatform);

            //Deserialize into list object

            var listRecoveredPlayer = JsonConvert.DeserializeObject<List<ClassCollections.RootObject>>(output);

            if (listRecoveredPlayer.Count == 1)
            {
             //   MessageBox.Show("Player is unique.. Continuing...");
                return true;
            }

            else
            {
                // MessageBox.Show("Please enter your name exactly as it is shown in uPlay...");
                
                return false;
            }
        }              

        public static void CreatePlayerObject(ClassCollections.AppObject player)

         {
            string output = HTTPConnector.HttpClientConnector.TestMethod(ClassCollections.AppConfig.selectedName, ClassCollections.AppConfig.selectedPlatform);

            var listPlayer = JsonConvert.DeserializeObject<List<ClassCollections.RootObject>>(output);

            //Copy required items from rootobject into player object

            foreach (var item in listPlayer)
         {

                player.apacRank = Convert.ToInt32(item.ranks.apac.mmr);
                player.emeaRank  = Convert.ToInt32(item.ranks.emea.mmr);
                player.ncsaRank  = Convert.ToInt32(item.ranks.ncsa.mmr);
                player.level = item.level;
                player.name = item.name;
                              
             }
            
        }

        public static bool PlayerIsRanked(ClassCollections.AppObject player)
        {
            {

                if (player.level <= 20)
                {
                    MessageBox.Show("Player level too low for ranked...");
                    return false;
                }

                MessageBox.Show("Player is ranked...");
                return true;

            }

        }
                                        
        public static double GetRegionMmr(ClassCollections.AppObject player, string selectedRegion)

        {

            if (ClassCollections.AppConfig.selectedRegion == "emea")
            {

                return player.emeaRank;
                
            }
            else if (ClassCollections.AppConfig.selectedRegion == "apac")
            {

                Console.WriteLine("Rank: " + player.apacRank);
                return player.apacRank;
            }
            else if (ClassCollections.AppConfig.selectedRegion == "ncsa")
            {

                Console.WriteLine("Rank: " + player.ncsaRank);
                return player.ncsaRank;
            }
            else
            {
                //catch all to ignore error
                return 0;

            }


        

        }
              
        public static string CalculateRank(double mmr)

            {

                string calculatedRank;


                if (mmr == 0)
                {
                    calculatedRank = "Player not found or no elo found for this region!";
                }

                else if (mmr < 1399)
                {
                    calculatedRank = "Copper IV";
                }
                else if (mmr <= 1499)
                {
                    calculatedRank = "Copper III";
                }
                else if (mmr <= 1599)
                {
                    calculatedRank = "Copper II";
                }

                else if (mmr <= 1699)
                {
                    calculatedRank = "Copper I";
                }
                else if (mmr <= 1799)
                {
                    calculatedRank = "Bronze IV";
                }
                else if (mmr <= 1899)
                {
                    calculatedRank = "Bronze III";
                }
                else if (mmr <= 1999)
                {
                    calculatedRank = "Bronze II";
                }
                else if (mmr <= 2099)
                {
                    calculatedRank = "Bronze I";
                }
                else if (mmr <= 2199)
                {
                    calculatedRank = "Silver IV";
                }
                else if (mmr <= 2299)
                {
                    calculatedRank = "Silver III";
                }
                else if (mmr <= 2399)
                {
                    calculatedRank = "Silver II";
                }
                else if (mmr <= 2499)
                {
                    calculatedRank = "Silver I";
                }
                else if (mmr <= 2699)
                {
                    calculatedRank = "Gold IV";
                }
                else if (mmr <= 2899)
                {
                    calculatedRank = "Gold III";
                    
                }
                else if (mmr <= 3099)
                {
                    calculatedRank = "Gold II";
                }
                else if (mmr <= 3299)
                {
                    calculatedRank = "Gold I";
                }
                else if (mmr <= 3699)
                {
                    calculatedRank = "Platinum III";
                }
                else if (mmr <= 4099)
                {
                    calculatedRank = "Platinum II";
                }
                else if (mmr <= 4499)
                {
                    calculatedRank = "Platinum I";
                }
                else
                {
                    calculatedRank = "Diamond";
                }

                return calculatedRank;
            
        }


    }
}


