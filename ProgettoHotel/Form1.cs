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
            if (cmb_stagione.SelectedItem == null || cmb_stanza.SelectedItem == null)
            {
                MessageBox.Show("verificare che siano state selezionate correttamente la stagione e il tipo di stanza");
                return;
            }
            
            
                {
                int giorni = Convert.ToInt32(txt_giorni.Text), parcheggio;
                string stagione = cmb_stagione.SelectedItem.ToString(), stanza = cmb_stanza.SelectedItem.ToString();
                    double costo = 0, costoTot;
                    if (stagione == "Bassa stagione")
                    {
                        if (stanza == "Base")
                        {
                            costo = 15;
                        }
                        else if (stanza == "Media")
                        {
                            costo = 30;
                        }
                        else if (stanza == "Alta")
                        {
                            costo = 45;
                        }
                    }
                    else if (stagione == "Media stagione")
                    {
                        if (stanza == "Base")
                        {
                            costo = 20;
                        }
                        else if (stanza == "Media")
                        {
                            costo = 35;
                        }
                        else if (stanza == "Alta")
                        {
                            costo = 50;
                        }
                    }
                    else if (stagione == "Alta stagione")
                    {
                        if (stanza == "Base")
                        {
                            costo = 25;
                        }
                        else if (stanza == "Media")
                        {
                            costo = 40;
                        }
                        else if (stanza == "Alta")
                        {
                            costo = 55;
                        }
                    }
                    costoTot = costo * giorni;
                    if (giorni > 3 && giorni < 7)
                    {
                        costoTot = costoTot * 0.75;
                    }
                    else if (giorni > 7)
                    {
                        costoTot = costoTot * 0.65;
                    }
                    else
                    {

                    }
                    if (chk_parcheggio.Checked)
                    {
                        parcheggio = giorni * 5;
                    }
                    else
                    {
                        parcheggio = 0;
                    }

                    costoTot = costoTot + parcheggio;
                    lbl_prezzo.Text = "totale: " + costoTot + "$";
                }
            }
        

        private void lbl_prezzo_Click(object sender, EventArgs e)
        {

        }

        private void btn_stanza_Click(object sender, EventArgs e)
        {
            string stanzaScelta = cmb_stanza.SelectedItem?.ToString();

            if (stanzaScelta == "Base")
            {
                pcbox_stanza.Image = Properties.Resources.Gemini_Generated_Image_x7n10kx7n10kx7n1;
            }
            else if (stanzaScelta == "Media")
            {
                pcbox_stanza.Image = Properties.Resources.Gemini_Generated_Image_fhbsmqfhbsmqfhbs;
            }
            else if (stanzaScelta == "Alta")
            {
                pcbox_stanza.Image = Properties.Resources.Gemini_Generated_Image_t064aut064aut064;
            }
            else
            {
                MessageBox.Show("Seleziona prima un tipo di stanza valido!");
            }
        }
    }
}
