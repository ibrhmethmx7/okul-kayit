using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YAZOKULUKAYIT
{
    public class EntityOgretmen
    {
        private int ogretmenid;
        private string adsoyad;
        private int brans;

        public int OGRETMENID { get => ogretmenid; set => ogretmenid = value; }
        public string ADSOYAD { get => adsoyad; set => adsoyad = value; }
        public int BRANS { get => brans; set => brans = value; }
    }
}