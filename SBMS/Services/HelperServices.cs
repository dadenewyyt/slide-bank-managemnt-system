using System;
using System.Collections.Generic;
using System.Windows;

namespace SBMS.Services
{
    class HelperServices
    {

        public Dictionary<string, string> SeperateBarCodeIntoCodes(string barcode)
        {
            //DSDSDS

            try
            {



                Dictionary<string, string> final = new Dictionary<string, string>();

                String donorCode = "";
                String seqCode = "";
                final.Add("CC", barcode.Substring(0, 2));
                //collect donor sequence

                donorCode += barcode.Substring(2, 1);
                donorCode += barcode.Substring(4, 1);
                donorCode += barcode.Substring(6, 1);

                //MessageBox.Show(donorCode);
                final.Add("DC", donorCode);
                seqCode += barcode.Substring(3, 1);
                seqCode += barcode.Substring(5, 1);
                seqCode += barcode.Substring(7, 1);

                final.Add("SS", seqCode);

                return final;

            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }

            return null;
        }



    }
}
