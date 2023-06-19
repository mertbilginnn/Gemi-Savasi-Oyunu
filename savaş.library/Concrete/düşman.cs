using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using savaş.library.Abstract;

namespace savaş.library.Concrete
{
    internal class düşman : Cisim
    {
        private static readonly Random Random = new Random();
        public düşman(Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        {
            Image = Image.FromFile(@"Gorseller\gemi.png");
            HareketMesafesi = (int)(Height * .1);
            Left = Random.Next(HareketAlaniBoyutlari.Width - Width + 1);

        }
        public mermi VurulduMu(List<mermi> mermiler)
        {
            foreach (var mermi in mermiler)
            {
                var vurulduMu = mermi.Top < Bottom && mermi.Right > Left && mermi.Left < Right;
                if (vurulduMu) return mermi;
            }
            return null;
        }

        public mermi2 VurulduMu(List<mermi2> fuzeler)
        {
            foreach (var fuze in fuzeler)
            {
                var vurulduMu = fuze.Top < Bottom && fuze.Right > Left && fuze.Left < Right;
                if (vurulduMu) return fuze;
            }
            return null;
        }


    }
}
