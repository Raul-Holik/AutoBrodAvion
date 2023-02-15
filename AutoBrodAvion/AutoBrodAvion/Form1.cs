using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoBrodAvion
{

    public partial class Form1 : Form
    {
        List<Vozilo> VoziloList = new List<Vozilo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            Vozilo vozilo = new Vozilo(txtBxMarka.Text, txtBxModel.Text, cmbVrsta.SelectedText);
            try
            {
                if (txtBxModel.Text == "" || txtBxMarka.Text == "" || cmbVrsta.Text == "")
                {
                    MessageBox.Show("Pogrešan unos", "Pokušajte ponovo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBxMarka.Clear();
                    txtBxModel.Clear();
                }

            else
             {
                    VoziloList.Add(vozilo);
                    txtBxMarka.Clear();
                    txtBxModel.Clear();
                }
            }

            catch
            {

                txtBxMarka.Clear();
                txtBxModel.Clear();
            }
        }


            private void btnIspis_Click(object sender, EventArgs e)
            {
                foreach (Vozilo v in VoziloList)
                {
                    txtBx3.AppendText(v.ToString());
                }
            }

        private void btnObrada_Click(object sender, EventArgs e)
        {
            foreach(Vozilo v in VoziloList)
            {
                if(v.Vrsta=="Auto")
                {
                    v.VoziPo = "Cesta.";
                }

                else if(v.Vrsta=="Avion")
                {
                    v.VoziPo = "Zrak";
                }

                else if(v.Vrsta=="Brod")
                {
                    v.VoziPo = "Voda";
                }
            }
        }
    }

    class Vozilo
        {
            string marka, model, vrsta;
            string voziPo;


            public Vozilo(string marka, string model, string vrsta)
            {
                this.marka = marka;
                this.model = model;
                this.vrsta = vrsta;

            }

            public string Marka { get => marka; set => marka = value; }
            public string Model { get => model; set => model = value; }
            public string Vrsta { get => vrsta; set => vrsta = value; }
             public string VoziPo { get => voziPo; set => voziPo = value; }

        public override string ToString()
            {
                string ispis = "Marka: " + marka + ", model: " + model + ", vrsta: " + vrsta;
                return ispis;
            }
        }
    }

