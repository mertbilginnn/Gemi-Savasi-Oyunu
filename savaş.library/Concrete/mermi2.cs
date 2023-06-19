using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using savaş.library.Abstract;

namespace savaş.library.Concrete
{
    internal class mermi2 : Cisim
    {
        public mermi2(Size hareketAlaniBoyutlari, int namluOrtasiX) : base(hareketAlaniBoyutlari)
        {
            Image = Image.FromFile(@"Gorseller\füze.png");
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