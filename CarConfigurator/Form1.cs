using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CarConfigurator.Functii;


namespace CarConfigurator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1Calculeaza_Click(object sender, EventArgs e)
        {
            if (isRadioBtnChecked(rdoBtnDacia, rdoBtnVolvo, rdoBtnSkoda) == false)
            {
                MessageBox.Show("Pick a car!");
            }
            else if (isColorSelected(cmbBoxCuloare) == false)
            {
                MessageBox.Show("Pick a color!");
            }
            else if (adresaEmpty(txtBoxAdresa) == true)
            {
                MessageBox.Show("Enter an customer name!");
            }
            else if (isDieselSelected(rdoBtnDiesel, rdoBtnBenzina) == false)
            {

                MessageBox.Show("Pick a combustion!");

            }
            else
            {
                int suma = 0;
                string combustie = "";
                string masina = "";
                String solutie = "Dear " + txtBoxAdresa.Text + ", Total price for configured car ";
                int culoare = 0;
                int pretCombustie = 0;

                if (rdoBtnDacia.Checked == true)
                {
                    suma += 1000;
                    solutie += rdoBtnDacia.Text;

                }
                if (rdoBtnVolvo.Checked == true)
                {
                    suma += 2000;
                    solutie += rdoBtnVolvo.Text;
                }
                if (rdoBtnSkoda.Checked == true)
                {
                    suma += 3000;
                    solutie += rdoBtnSkoda.Text;
                }
                masina += "Car " + suma;


                switch (cmbBoxCuloare.SelectedIndex)
                {

                    case 0://rosu
                        suma += 200;
                        culoare = 200;
                        break;
                    case 1://alb
                        suma += 500;
                        culoare = 500;
                        break;

                    case 2:
                        suma += 700;
                        culoare = 700;
                        break;

                }


                if (rdoBtnBenzina.Checked == true)
                {
                    /*Dear cusotmer,For the car selected, total price is: 2500 euro.
                     * Options selected: car 1000euro
                     * Color: red 300 euro
                     * Engine: Diesel 500 euro.
                     */
                    suma += 100;
                    combustie += rdoBtnBenzina.Text ;
                    pretCombustie = 100;
                }
                if (rdoBtnDiesel.Checked == true)
                {
                    suma += 500;
                    combustie += rdoBtnDiesel.Text;
                    pretCombustie = 500;

                }

                solutie += " is: " + suma + " euro\n";
                solutie += "Options selected: " + masina+"\n";
                solutie += "Color " + cmbBoxCuloare.Text+' '+ + culoare+"\n";
                solutie += "Combustion: " + combustie +  ' '+ pretCombustie;

                lbl1Rezultate.Text = solutie;
                lbl1Rezultate.Visible = true;

            }

        }

        private void txtBoxAdresa_TextChanged(object sender, EventArgs e)
        {
            String name = "";
            name += "Name: " + txtBoxAdresa + "\n";
            lbl1Rezultate.Text = name;
        }

        private void btn2Calculate_Click(object sender, EventArgs e)
        {
            resetSelection(rdoBtnDacia, rdoBtnVolvo, rdoBtnSkoda);
            resetTwoSelection(rdoBtnBenzina, rdoBtnDiesel);
            resetColor(cmbBoxCuloare);
            deleteText(txtBoxAdresa);
            resetResultsLabel(lbl1Rezultate);
        }

        private void lbl1Rezultate_Click(object sender, EventArgs e)
        {

        }
    }
}

