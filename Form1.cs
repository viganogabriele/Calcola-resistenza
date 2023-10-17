using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace _22._35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Cmb 1 cifra
            cmb1.Items.Add("Nero");
            cmb1.Items.Add("Marrone");
            cmb1.Items.Add("Rosso");
            cmb1.Items.Add("Arancione");
            cmb1.Items.Add("Giallo");
            cmb1.Items.Add("Verde");
            cmb1.Items.Add("Blu");
            cmb1.Items.Add("Viola");
            cmb1.Items.Add("Grigio");
            cmb1.Items.Add("Bianco");
            //Cmb 2 cifra
            cmb2.Items.Add("Nero");
            cmb2.Items.Add("Marrone");
            cmb2.Items.Add("Rosso");
            cmb2.Items.Add("Arancione");
            cmb2.Items.Add("Giallo");
            cmb2.Items.Add("Verde");
            cmb2.Items.Add("Blu");
            cmb2.Items.Add("Viola");
            cmb2.Items.Add("Grigio");
            cmb2.Items.Add("Bianco");
            //Cmb moltiplicatore
            cmbM.Items.Add(1);
            cmbM.Items.Add(10);
            cmbM.Items.Add(100);
            cmbM.Items.Add(1000);
            cmbM.Items.Add(10000);
            cmbM.Items.Add(100000);
            cmbM.Items.Add(1000000);
            //Cmb tolleranza
            cmbT.Items.Add("Oro");
            cmbT.Items.Add("Argento");
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string R;
            int c1;
            int c2;
            int M;
            string T = "";
            c1 = cmb1.SelectedIndex;
            c2 = cmb2.SelectedIndex;
            M = (int) cmbM.SelectedItem;
            if(cmbT.SelectedIndex == 0)
            {
                T = "5 %";
            }
            else if(cmbT.SelectedIndex == 1)
            {
                T = "10 %";
            }
            R = (float.Parse(c1.ToString() + c2.ToString()) * M).ToString() + " Ω " + T;
            lbl.Text = R;
        }
    }
}
