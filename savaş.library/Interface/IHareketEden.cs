using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using savaş.library.Enum;

namespace savaş.library.Interface
{
    interface IHareketEden
    {
        Size HareketAlaniBoyutlari { get; }
        int HareketMesafesi { get; }
        bool HareketEttir(Yon yon);
    }
}
