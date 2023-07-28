using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAZOKULUKAYIT;
using DataAccessLayer;
namespace BusinessLogicLayer
{
   public  class BLLOgrenci
    {
        public  int OgrenciEkleBLL(Entity parametre)
        {
            if (parametre.AD != "" && 
                parametre.SOYAD != "" && 
                parametre.SIFRE != "" && 
                parametre.FOTOGRAF != "" && 
                parametre.NUMARA != "")
            {
                return DALOgrenci.OgrenciEkle(parametre);
            }
            else
            {
                return -1;
            }
        }
    }
}
