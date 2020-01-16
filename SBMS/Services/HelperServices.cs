using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SBMS.Services
{
    class HelperServices
    {

        public Dictionary<string, string> SeperateBarCodeIntoCodes(string barcode)
        {

          
            try
            {

                

                Dictionary<string, string> final = new Dictionary<string, string>();

                final.Add("CC", barcode.Substring(0,2));
                final.Add("DC", barcode.Substring(2,3));
                final.Add("SS", barcode.Substring(5,3));
       
                return final;

            }

            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }

            return null;
        }



    }
}
