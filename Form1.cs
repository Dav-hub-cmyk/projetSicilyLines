﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            lb.Hide();
            tbSaisie.Hide();
            btnVal.Hide();
            lbl.Hide();
            btnModif.Hide();
            btnInsert.Hide();
            btnSup.Hide();
        }

        private void btnResa_Click(object sender, EventArgs e)
        {
            lb.Visible = true;
            //btnVal.Visible = true;
            btnSup.Visible = true;
            btnInsert.Visible = true;
            btnModif.Visible = true;
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            lb.Hide();
            btnVal.Hide();
            btnSup.Hide();
            btnInsert.Hide();
            btnModif.Hide();
            lbl.Hide();
            tbSaisie.Hide();

            
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
    }
}