using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using savaş.library.Concrete;
using savaş.library.Enum;

namespace Gemi_Savaşı
{
    public partial class AnaForm : Form
    {
        private readonly Oyun _oyun;

        
        public AnaForm()
        {
            InitializeComponent();
            
            _oyun = new Oyun(gemisavarPanel, savasalaniPanel,Skor);
            _oyun.GecenSureDegisti += Oyun_GecenSureDegisti;

        }
        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AnaForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    _oyun.Baslat();
                    break;
                case Keys.Right:
                    _oyun.GemiyiHareketEttir(Yon.Saga);
                    break;
                case Keys.Left:
                    _oyun.GemiyiHareketEttir(Yon.Sola);
                    break;
                case Keys.Enter:
                    _oyun.AtesEt();
                    break;
                case Keys.Tab:
                    _oyun.FuzeAtesEt();
                    break;
                case Keys.Escape:
                    _oyun.Durdur();
                    break;
            }
        }

        private void Oyun_GecenSureDegisti(object sender,EventArgs e)
        {
            SL.Text = $"{_oyun.GecenSure.Minutes}:{_oyun.GecenSure.Seconds.ToString("D2")}";
        }

      
   
        private void Skor_Click(object sender, EventArgs e)
        {
            
        }
    }
}
