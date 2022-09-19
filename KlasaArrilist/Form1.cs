using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace KlasaArrilist
{
    public partial class Form1 : Form
    {
        ArrayList listaAutomobila = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNovi_Click(object sender, EventArgs e)
        {
            textBoxNovi.Enabled = true;
            buttonUnesi.Enabled = true;
        }

        private void buttonUnesi_Click(object sender, EventArgs e)
        {
            textBoxNovi.Enabled = false;
            buttonUnesi.Enabled = false;
            //textBoxLista.AppendText(textBoxNovi.Text + Environment.NewLine);
            Automobil a = new Automobil(textBoxNovi.Text);
            listaAutomobila.Add(a);
            textBoxLista.AppendText(listaAutomobila.IndexOf(a) + 1 + ". " + a.dajMarku() + Environment.NewLine);
            textBoxNovi.Clear();
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            textBoxLista.Clear();
        }
    }
}
