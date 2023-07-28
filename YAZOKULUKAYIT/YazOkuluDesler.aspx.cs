using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YAZOKULUKAYIT;
using DataAccessLayer;
using BusinessLogicLayer;

namespace YAZOKULUKAYIT
{
    public partial class YazOkuluDesler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Entity parametres = new Entity();
            parametres.AD=TxtAd.Text;
            parametres.SOYAD = TxtSoyad.Text;
            parametres.SIFRE = TxtSifre.Text;
            parametres.FOTOGRAF = TxtFotograf.Text;
            parametres.NUMARA = TxtNumara.Text;
            BLLOgrenci prm = new BLLOgrenci();
            prm.OgrenciEkleBLL(parametres);



        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}