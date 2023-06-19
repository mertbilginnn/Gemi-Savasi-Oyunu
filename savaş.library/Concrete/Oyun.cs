using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using savaş.library.Enum;
using savaş.library.Interface;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using Gemi_Savaşı;

namespace savaş.library.Concrete
{
    public class Oyun : IOyun
    {
        #region Alanlar

        private readonly Timer _gecenSureTimer = new Timer { Interval = 1000 };
        private readonly Timer _hareketTimer = new Timer { Interval = 100 };
        private readonly Timer _düşmanOlusturmaTimer = new Timer { Interval = 2000 };
        private TimeSpan _gecenSure;
        private readonly Panel _düşmansavarPanel;
        private readonly Panel _savasalaniPanel;
        private düşmansavar _düşmansavar;
        private readonly List<mermi2> _mermi2 = new List<mermi2>();
        private readonly List<mermi> _mermiler = new List<mermi>();
        private readonly List<düşman> _düşmanlar = new List<düşman>();
        private bool Pause = false;

        #endregion

        #region Olaylar

        public event EventHandler GecenSureDegisti;

        #endregion


        #region Özellikler

        public bool DevamEdiyorMu { get; private set; }

        public TimeSpan GecenSure
        {
            get => _gecenSure;
            private set
            {
                _gecenSure = value;

                GecenSureDegisti?.Invoke(this, EventArgs.Empty);
            }
        }


        #endregion


        #region Metotlar




        public Oyun(Panel gemisavarPanel,Panel savasAlaniPanel, Label skor)
        {
            _düşmansavarPanel = gemisavarPanel;
            _savasalaniPanel = savasAlaniPanel;
            _gecenSureTimer.Tick += GecenSureTimer_Tick;
            _hareketTimer.Tick += HareketTimer_Tick;
            _düşmanOlusturmaTimer.Tick += GemiOlusturmaTimer_Tick;
            

        }

        private void GecenSureTimer_Tick(object sender, EventArgs e)
        {
            GecenSure += TimeSpan.FromSeconds(1);
        }

        private void HareketTimer_Tick(object sender, EventArgs e)
        {
            
            FuzeleriHareketEttir();
            MermileriHareketEttir();
            GemileriHareketEttir();
            VurulanGemileriCikar();
        }

       

       

        private void VurulanGemileriCikar()
        {
            for (var i = _düşmanlar.Count - 1; i >= 0; i--)
            {
                var gemi = _düşmanlar[i];

                var vuranMermi = gemi.VurulduMu(_mermiler);
                if (vuranMermi is null) continue;

                _düşmanlar.Remove(gemi);
                _mermiler.Remove(vuranMermi);
                _savasalaniPanel.Controls.Remove(gemi);
                _savasalaniPanel.Controls.Remove(vuranMermi);
                
                


            }
            for (var i = _düşmanlar.Count - 1; i >= 0; i--)
            {
                var gemi = _düşmanlar[i];

                var vuranFuze = gemi.VurulduMu(_mermi2);
                if (vuranFuze is null) continue;

                _düşmanlar.Remove(gemi);
                _mermi2.Remove(vuranFuze);
                _savasalaniPanel.Controls.Remove(gemi);
                _savasalaniPanel.Controls.Remove(vuranFuze);
                




            }
        }



        private void GemileriHareketEttir()
        {
            foreach(var gemi in _düşmanlar)
            {
                var carptiMi = gemi.HareketEttir(Yon.Saga);
                if (!carptiMi) continue;

                Bitir();
                break;




            }
        }



        private void GemiOlusturmaTimer_Tick(object sender, EventArgs e)
        {
            GemiOlustur();

        }

        private void MermileriHareketEttir()
        {

            for (int i = _mermiler.Count - 1; i >= 0; i--)
            {
               
                var mermi = _mermiler[i];
                var carptiMi = mermi.HareketEttir(Yon.Yukari);
                if (carptiMi)
                {
                   
                    _mermiler.Remove(mermi);
                    _savasalaniPanel.Controls.Remove(mermi);
                }
            }


        }

        private void FuzeleriHareketEttir()
        {

            for(int i = _mermi2.Count - 1; i >= 0; i--)
            {
                var fuze = _mermi2[i];
                var carptiMi = fuze.HareketEttir(Yon.Yukari);
                if (carptiMi)
                {
                    _mermi2.Remove(fuze);
                    _savasalaniPanel.Controls.Remove(fuze);
                }
            }
        }

        public void Baslat()
        {
            if (DevamEdiyorMu) return;

            DevamEdiyorMu = true;

            ZamanlayicilariBaslat();
            if (!Pause)
            {
                GemisavarOlustur();
            }


            
            GemiOlustur();


        }

        public void Durdur()
        {
            Pause=true;
            if (!DevamEdiyorMu)
            {
                ZamanlayicilariDurdur();
            }
            DevamEdiyorMu = false;
            
        }

        private void GemiOlustur()
        {
            var gemi = new düşman(_savasalaniPanel.Size);
            _düşmanlar.Add(gemi);
            _savasalaniPanel.Controls.Add(gemi);
        }



        private void ZamanlayicilariBaslat()
        {
            _gecenSureTimer.Start();
            _hareketTimer.Start();
            _düşmanOlusturmaTimer.Start();
        }


        private void GemisavarOlustur()
        {
             _düşmansavar = new düşmansavar(_düşmansavarPanel.Width,_düşmansavarPanel.Size);
            _düşmansavarPanel.Controls.Add(_düşmansavar);
        }


       

        private void Bitir()
        {
          
            if (!DevamEdiyorMu) return;

            DevamEdiyorMu = false;
            ZamanlayicilariDurdur();
            

        }

        private void ZamanlayicilariDurdur()
        {
            _gecenSureTimer.Stop();
            _hareketTimer.Stop();
            _düşmanOlusturmaTimer.Stop();
        }




        public void AtesEt()
        {
            if (!DevamEdiyorMu) return;
            var mermi = new mermi(_savasalaniPanel.Size, _düşmansavar.Center);
            _mermiler.Add(mermi);
            _savasalaniPanel.Controls.Add(mermi);

            
        }

        public void FuzeAtesEt()
        {
            if (!DevamEdiyorMu) return;
            var fuze = new mermi2(_savasalaniPanel.Size, _düşmansavar.Center);
            _mermi2.Add(fuze);
            _savasalaniPanel.Controls.Add(fuze);
            
        }

        public void GemiyiHareketEttir(Yon yon)
        {
            if (!DevamEdiyorMu) return;
            _düşmansavar.HareketEttir(yon);
        }
        
          

        #endregion
    }
}
