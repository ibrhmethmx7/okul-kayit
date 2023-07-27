using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YAZOKULUKAYIT
{
    public class EntityBasvuru
    {
        private int basvuruid;
        private int ogrenciid;
        private int dersid;

        public int BASVURUID { get => basvuruid; set => basvuruid = value; }
        public int OGRENCIID { get => ogrenciid; set => ogrenciid = value; }
        public int DERSID { get => dersid; set => dersid = value; }
    }
}