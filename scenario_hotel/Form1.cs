using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scenario_hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcola_Click(object sender, EventArgs e)
        {
            string stanza = cmb_stanza.Text, stagione = cmb_stagione.Text;
            float pStanza = 0, totale = 0, nGiorni = Convert.ToInt32(txt_ngiorni.Text), pParcheggio; 

            


            switch (stanza)
            {
                case "Bassa Stanza":

                    switch (stagione)
                    {
                        case "Bassa Stagione":

                            pStanza = 15;
                            break;

                        case "Media Stagione":

                            pStanza = 20;
                            break;

                        case "Alta Stagione":

                            pStanza = 25;
                            break;

                    }

                    break;

                        

                case "Media Stanza":

                        switch (stagione)
                        {
                        case "Bassa Stagione":

                            pStanza = 30;
                            break;

                        case "Media Stagione":

                            pStanza = 35;
                            break;

                        case "Alta Stagione":

                            pStanza = 40;
                            break;
                        }
                    break;

                case "Alta Stanza":

                    switch (stagione)
                    {
                        case "Bassa Stagione":

                            pStanza = 45;
                            break;

                        case "Media Stagione":

                            pStanza = 50;
                            break;

                        case "Alta Stagione":

                            pStanza = 55;
                            break;
                    }
                    break;
            }

            if (nGiorni <= 2)
            {
                totale = pStanza * nGiorni;
            }
            else
            {
                if (nGiorni >= 3 || nGiorni <= 7)
                {
                    totale = (pStanza * nGiorni) * 0.75f;
                }
                else
                {
                    totale = (pStanza * nGiorni) * 0.65f;
                }
            }

            if (checkBox1.Checked == true)
            {
                pParcheggio = 5 * nGiorni;

                totale = totale + pParcheggio;
            }

            lbl_risultato.Text = "Il Prezzo Di Alloggio Ammonta a: " + totale + " Euro";
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            if (grb_info.Visible == true)
            {
                grb_info.Visible = false;
            }
            else
            {
                grb_info.Visible = true;
            }
            
        }

        private void grb_info_Enter(object sender, EventArgs e)
        {

        }
    }
}
