﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YAZOKULUKAYIT
{
    public class Entity
    {
        private string ad;
        private string soyad;
        private int ogrenciid;
        private string numara;
        private string fotograf;
        private double bakiye;
        private string sifre;

        public string AD { get => ad; set => ad = value; }
        public string SOYAD { get => soyad; set => soyad = value; }
        public int OGRENCID { get => ogrenciid; set => ogrenciid = value; }
        public string NUMARA { get => numara; set => numara = value; }
        public string FOTOGRAF { get => fotograf; set => fotograf = value; }
        public double BAKIYE { get => bakiye; set => bakiye = value; }
        public string SIFRE { get => sifre; set => sifre = value; }
    }
}