using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace CarConfigurator
{
    public class Functii
    {
        public static bool isRadioBtnChecked(RadioButton rdo1, RadioButton rdo2, RadioButton rdo3)
        {
            if (rdo1.Checked == true || rdo2.Checked == true || rdo3.Checked == true)

            {
                return true;
            }
            return false;
        }

        public static bool isDieselSelected(RadioButton rdo1, RadioButton rdo2)
        {
            if (rdo1.Checked == true || rdo2.Checked == true)
            {
                return true;
            }
            return false;
        }

        public static bool isColorSelected(ComboBox cmb1)
        {
           if (cmb1.SelectedIndex == -1)//SelectedIndex starts from 0
                //if it`s -1, means none of them is selected
            {
                return false;

            }
            return true;
        }
        public static bool adresaEmpty(TextBox txt1)
        {
            return txt1.Text.Equals("Introduceti adresa...") == true;
        }

        public static void resetSelection(RadioButton rdo1, RadioButton rdo2, RadioButton rdo3)
        {
            rdo1.Checked = false;
            rdo2.Checked = false;
            rdo3.Checked = false;
        }
        public static void resetTwoSelection(RadioButton rdo1, RadioButton rdo2)
        {
            rdo1.Checked = false;
            rdo2.Checked = false;
        }
        public static void resetColor(ComboBox cmb1)
        {
            cmb1.SelectedIndex = -1;
        }


        public static void resetResultsLabel(Label labelResults)
        {
            labelResults.Visible = false;
        }

        public static void deleteText(TextBox adresa)
        {
            adresa.Text = "";
           
        }

        
    }
}
