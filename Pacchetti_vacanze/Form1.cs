using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacchetti_vacanze
{
    public partial class Form1 : Form
    {

        Pacchetto_base[] offerte;
        int dim;

        public Form1()
        {
            InitializeComponent();
            offerte = new Pacchetto_base[100];
            dim = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void add_base_button_Click(object sender, EventArgs e)
        {
            Pacchetto_base temp = new Pacchetto_base(destinazione_textbox.Text, int.Parse(durata_textbox.Text), float.Parse(prezzo_textbox.Text));
            offerte[dim] = temp;
            dim++;
            listView1.Items.Add(temp.ToString() + " Prezzo Vendita: " + temp.CalcolaPrezzo());
        }

        private void add_volo_button1_Click(object sender, EventArgs e)
        {
            Pacchetto_base temp = new Pacchetto_volo(volo_ritorno_checkbox.Checked, destinazione_textbox.Text, int.Parse(durata_textbox.Text), float.Parse(prezzo_textbox.Text));
            offerte[dim] = temp;
            dim++;
            listView1.Items.Add(temp.ToString() + " Prezzo Vendita: " + temp.CalcolaPrezzo());
        }

        private void add_pastp_button_Click(object sender, EventArgs e)
        {
            Pacchetto_base temp = new Pacchetto_pasto(pensione_checkbox.Checked, destinazione_textbox.Text, int.Parse(durata_textbox.Text), float.Parse(prezzo_textbox.Text));
            offerte[dim] = temp;
            dim++;
            listView1.Items.Add(temp.ToString() + " Prezzo Vendita: " + temp.CalcolaPrezzo());
        }

        private void add_esc_button_Click(object sender, EventArgs e)
        {
            Pacchetto_base temp = new Pacchetto_escursione(int.Parse(escursioni_textbox.Text), volo_ritorno_checkbox.Checked, destinazione_textbox.Text, int.Parse(durata_textbox.Text), float.Parse(prezzo_textbox.Text));
            offerte[dim] = temp;
            dim++;
            listView1.Items.Add(temp.ToString() + " Prezzo Vendita: " + temp.CalcolaPrezzo());
        }

        private void max_min_button1_Click(object sender, EventArgs e)
        {
            if(dim > 0)
            {
                int min = 0;
                int max = 0;
                float prezzoMin = offerte[0].CalcolaPrezzo();
                float prezzoMax = offerte[0].CalcolaPrezzo();

                for (int i = 1; i < dim; i++)
                {
                    if (offerte[i].CalcolaPrezzo() > prezzoMax)
                    {
                        max = i;
                        prezzoMax = offerte[i].CalcolaPrezzo();
                    }

                    if (offerte[i].CalcolaPrezzo() < prezzoMin)
                    {
                        min = i;
                        prezzoMax = offerte[i].CalcolaPrezzo();
                    }
                }

                listView2.Items.Clear();
                listView2.Items.Add( "Offerta Prezzo Min:   "+ offerte[min].ToString() + " Prezzo Vendita: " + offerte[min].CalcolaPrezzo());
                listView2.Items.Add("Offerta Prezzo Max:   " + offerte[max].ToString() + " Prezzo Vendita: " + offerte[max].CalcolaPrezzo());
            }
            
        }

        private void media_button_Click(object sender, EventArgs e)
        {
            if (dim > 0)
            {
                float sum = 0;

                for (int i = 0; i < dim; i++)
                {
                    sum += offerte[i].CalcolaPrezzo();
                }

                float size = dim;
                MessageBox.Show((sum / size).ToString());
            }
        }
    }
}
