using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Security.RightsManagement;

namespace 期中專題_線上點餐系統
{
    internal class GlobalVar
    {
        public static string strDBconnectionString = "";

        public static bool isLogin = false;
        public static bool isEmployee = false;
        public static int userID = 0;
        public static string username = "";
        public static int point = 0;
       
        public static int permission = 0;
        public static bool isChecked = false;
        public static int flavorID = 0;
        public static bool isTakeout = false;
        public static int table = 0;

        //customer form
        public static List<Tuple<string, string, int, int>> orderQuantity = new List<Tuple<string, string, int, int>>();

        //cart form
        public static List<Tuple<int, string, string>> cartFlavorList = new List<Tuple<int, string, string>>();
        public static List<int> subtotalList = new List<int>();
        public static List<int> quantityList = new List<int>();       
        public static List<List<Tuple<string, string, int, int>>> cartList = new List<List<Tuple<string, string, int, int>>>();

        //detail form
        public static int detailOrderID = 0;
        public static string detailTime = "";
        public static int detailPrice = 0;

    }
}
