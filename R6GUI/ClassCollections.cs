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
    public partial class ClassCollections : Window
    {

        // All app classes listed here..

        public class LastPlayed

        // NullValueHandling configured to ignore errors in desiralization when no games have been played in ranked/casual
        {
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public int? casual { get; set; }
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public int? ranked { get; set; }
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public DateTime? last_played { get; set; }
        }

        public class Apac
        {
            public double mmr { get; set; }
            public int rank { get; set; }
        }

        public class Emea
        {
            public double mmr { get; set; }
            public int rank { get; set; }
        }

        public class Ncsa
        {
            public double mmr { get; set; }
            public int rank { get; set; }
        }

        public class Ranks
        {
            public Apac apac { get; set; }
            public Emea emea { get; set; }
            public Ncsa ncsa { get; set; }
        }

        public class Alias
        {

            public string name { get; set; }
            public DateTime created_at { get; set; }
        }

        public class Aliases
        {

            public string name { get; set; }
            public DateTime created_at { get; set; }
        }

        public class RootObject
        {

            public string id { get; set; }
            public string userId { get; set; }
            public string platform { get; set; }
            public object flair { get; set; }
            public int level { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
            public LastPlayed lastPlayed { get; set; }
            public string name { get; set; }
            public Ranks ranks { get; set; }
            public List<Alias> aliases { get; set; }

        }

        public class AppObject
        {
            public string name { get; set; }
            public string id { get; set; }
            public double apacRank { get; set; }
            public double emeaRank { get; set; }
            public double ncsaRank { get; set; }
            public int level { get; set; }
           

        }

        public static class AppConfig
        {
            public static string selectedRegion { get; set; }
            public static string selectedPlatform { get; set; }
            public static string selectedName { get; set; }
        }

        public class NameObjects
        {
            public string name { get; set; }
        }
    }
    
}
