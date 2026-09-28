using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CegApp
{
    public class Menedzser : Alkalmazott
    {
        public int Bonusz { get; set; }
        public Menedzser(string nev, int alapber,int bonusz) : base(nev, alapber)
        {
            Bonusz = bonusz;
        }
        public override int FizetesSzamitas()
        {
            return Alapber + Bonusz;
        }
    }
    
}
