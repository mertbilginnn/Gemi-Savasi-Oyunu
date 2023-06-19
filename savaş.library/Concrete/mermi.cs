using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using savaş.library.Abstract;
using System.Windows.Forms;
using System.Drawing;

namespace savaş.library.Concrete
{
   internal class mermi: Cisim
    {
        public mermi(Size hareketAlaniBoyutlari, int namluOrtasiX) : base(hareketAlaniBoyutlari)
        {
            Image = Image.FromFile(@"Gorseller\mermi.jpg");
            BaslangicKonumunuAyarla(namluOrtasiX);
            HareketMesafesi = (int)(Height * 1.5);
        }
        private void BaslangicKonumunuAyarla(int namluOrtasiX)
        {
            Bottom = HareketAlaniBoyutlari.Height;
            Center = namluOrtasiX; 
        }
    }
}
