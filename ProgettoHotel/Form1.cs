using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoHotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_calcolo_Click(object sender, EventArgs e)
        {
            int giorni = Convert.ToInt32(txt_giorni.Text), costo = 0;
            string stagione = cmb_stagione.SelectedItem.ToString(), stanza = cmb_stanza.SelectedItem.ToString();
            if (stagione == "Bassa Stagione")
            {
                if (stanza == "Base")
                {
                    costo = 15;
                }
                else if (stanza == "Media")
                {
                    costo = 30;
                }
            }
        }
    }
}
