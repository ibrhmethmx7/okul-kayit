using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YAZOKULUKAYIT
{
    public class EntityDers
    {
        private int dersid;
        private string dersad;
        private string min;
        private string max;

        public int DERSID { get => dersid; set => dersid = value; }
        public string DERSAD { get => dersad; set => dersad = value; }
        public string MIN { get => min; set => min = value; }
        public string MAX { get => max; set => max = value; }
    }
}