﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP00_Dedicnost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zamestnanec zamestnanec = new Zamestnanec("Eva", "Nováková", 100);
            MessageBox.Show(zamestnanec.GetJmeno());
            MessageBox.Show(zamestnanec.ToString());

            zamestnanec.SetPrijmeni("Pospíchalová");
            MessageBox.Show(zamestnanec.ToString());

            zamestnanec.OdpracujHodiny(20);
            MessageBox.Show(zamestnanec.ToString());
            zamestnanec.OdpracujHodiny(150);
            MessageBox.Show(zamestnanec.ToString());
        }
            
        private void button2_Click(object sender, EventArgs e)
        {
            Vedouci vedouci = new Vedouci("Emil", "K.", 200,300);

            MessageBox.Show(vedouci.ToString());
            MessageBox.Show("Příplatek za vedení je: " + vedouci.GetPriplatekZaVedeni());
            vedouci.OdpracujHodiny(20);
            vedouci.SetPriplatekZaVedeni(1500);
            MessageBox.Show(vedouci.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ridic ridic = new Ridic("Martin", "Dostal", 150, "B");
            ridic.OdpracujHodiny(10);
            MessageBox.Show(ridic.ToString());
        }
    }
}
