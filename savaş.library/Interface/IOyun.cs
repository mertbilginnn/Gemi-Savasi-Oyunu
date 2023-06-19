using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using savaş.library.Enum;

namespace savaş.library.Interface
{
    internal interface IOyun
    {
        event EventHandler GecenSureDegisti;


        bool DevamEdiyorMu { get; }
        TimeSpan GecenSure { get; }


        void Baslat();
        void AtesEt();
        void FuzeAtesEt();
        void GemiyiHareketEttir(Yon yon);
    }
}
