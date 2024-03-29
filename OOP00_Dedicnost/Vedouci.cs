﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP00_Dedicnost
{
    class Vedouci:Zamestnanec
    {
        private double priplatekZaVedeni;

        public Vedouci(string jmeno, string prijmeni, double hodinovaMzda, double priplatekZaVedeni) : base(jmeno,prijmeni,hodinovaMzda)
        {
            this.priplatekZaVedeni = priplatekZaVedeni;
        }
        public double GetPriplatekZaVedeni()
        {
            return priplatekZaVedeni;
        }
        public void SetPriplatekZaVedeni(double priplatekZaVedeni)
        {
            this.priplatekZaVedeni = priplatekZaVedeni;
        }
        public override double VypoctiMzdu()
        {
            return base.VypoctiMzdu() + priplatekZaVedeni;
        }
        public override string ToString()
        {
            return base.ToString() + "\nPříplatek za vedení" + priplatekZaVedeni;
        }
    }
    
}
