using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spire.Xls;

namespace azmoun
{
    public static class class_device_info
    {
        public static int device_ID=-1;

        public static int refence_ID=-1;

        public static string category=String.Empty;

        public static int colibrationID = -1;

        public static int step = -1;

        public static string mode = String.Empty;

        public static int number_of_reads = 0;

        public static Worksheet values = null;

        public static Image chart=null;

        public static string category_insert = String.Empty;

        public static void reset()
        {
         device_ID = -1;

         refence_ID = -1;

         category =String.Empty;

         step = -1;

         mode = String.Empty;

         number_of_reads = 0;

         values = null;

         chart = null;
        }


    }
}
