using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetSicilyLines
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb.Hide();
            tbSaisie.Hide();
            btnVal.Hide();
            lbl.Hide();
            btnModif.Hide();
            btnInsert.Hide();
            btnSup.Hide();
            btnselect.Hide();
        }

        private void btnResa_Click(object sender, EventArgs e)
        {
            tb.Visible = true;
            //btnVal.Visible = true;
            btnSup.Visible = true;
            btnInsert.Visible = true;
            btnModif.Visible = true;
            btnselect.Visible = true;
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            tb.Hide();
            btnVal.Hide();
            btnSup.Hide();
            btnInsert.Hide();
            btnModif.Hide();
            lbl.Hide();
            tbSaisie.Hide();
            btnselect.Hide();

            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            tbSaisie.Hide();
            btnVal.Hide();
            lbl.Hide();
            //-----------------------------------
            tbSaisie.Visible = true;
            //tbModif.Text = "Modification";
            btnVal.Visible = true;
            lbl.Visible = true;
            lbl.Text = "Insertion";
            /*insertion inse = new insertion();
            inse.ShowDialog();*/
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            tbSaisie.Visible = true;
            //tbModif.Text = "Modification";
            btnVal.Visible = true;
            lbl.Visible = true;
            lbl.Text = "Modification";

        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            /*ofd.ShowDialog();
            StreamReader sr = new StreamReader(ofd.FileName);
            lb.Text = sr.ReadToEnd();*/
            DialogResult dr = this.ofd.ShowDialog();
            if(dr == DialogResult.OK)
            {
                string path = this.ofd.FileName;

                string text = File.ReadAllText(path);
                this.tb.Text = text;
                System.Console.WriteLine(text);
            } 
        }

        private void btnVal_Click(object sender, EventArgs e)
        {
            if (lbl.Text == "Insertion")
            {
                //
                //tu met le code pour inserer ici je crois Yvan
            }
            if (lbl.Text == "Modification")
            {
                //
                //et le code pour la modificatiokn ici aussii
            }
        }
    }
}
