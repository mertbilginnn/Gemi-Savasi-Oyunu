using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using savaş.library.Abstract;
using System.Drawing;

namespace savaş.library.Concrete

{
    internal class düşmansavar : Cisim
    {
      public düşmansavar(int panelGenisligi, Size hareketAlaniBoyutlari):base(hareketAlaniBoyutlari)
        {
            Image = Image.FromFile(@"Gorseller\submarine.png");
            Center = panelGenisligi / 2;
            HareketMesafesi = Width;
        }
    }
}
