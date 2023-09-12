using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenjualanWingsApp.Repository
{
    class ModelPublic
    {
        public static string SessionRole { get; set; }
        public static string SessionUserID { get; set; }
        public static string SessionUsername { get; set; }
        public static Dictionary<string, int> Checkout { get; set; }
        public static Dictionary<string, double> PriceList { get; set; }
        public static double TotalHarga { get; set; }
        public static Dictionary<string, double> CheckoutFixed { get; set; }
        
        // Constructor to initialize the Checkout dictionary
        public ModelPublic()
        {
            Checkout = new Dictionary<string, int>();
            CheckoutFixed = new Dictionary<string, double>();
            PriceList = new Dictionary<string, double>();
        }
    }
}
