
namespace Gemi_Savaşı
{
    partial class AnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bilgialaniPanel = new System.Windows.Forms.Panel();
            this.Skor = new System.Windows.Forms.Label();
            this.SL = new System.Windows.Forms.Label();
            this.BL = new System.Windows.Forms.Label();
            this.gemisavarPanel = new System.Windows.Forms.Panel();
            this.savasalaniPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bilgialaniPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bilgialaniPanel
            // 
            this.bilgialaniPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bilgialaniPanel.Controls.Add(this.label1);
            this.bilgialaniPanel.Controls.Add(this.Skor);
            this.bilgialaniPanel.Controls.Add(this.SL);
            this.bilgialaniPanel.Controls.Add(this.BL);
            this.bilgialaniPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bilgialaniPanel.Location = new System.Drawing.Point(0, 0);
            this.bilgialaniPanel.Name = "bilgialaniPanel";
            this.bilgialaniPanel.Size = new System.Drawing.Size(800, 112);
            this.bilgialaniPanel.TabIndex = 0;
            this.bilgialaniPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Skor
            // 
            this.Skor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Skor.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Skor.Location = new System.Drawing.Point(693, 53);
            this.Skor.Name = "Skor";
            this.Skor.Size = new System.Drawing.Size(104, 51);
            this.Skor.TabIndex = 2;
            this.Skor.Text = "0";
            this.Skor.Click += new System.EventHandler(this.Skor_Click);
            // 
            // SL
            // 
            this.SL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SL.ForeColor = System.Drawing.Color.White;
            this.SL.Location = new System.Drawing.Point(638, 0);
            this.SL.Name = "SL";
            this.SL.Size = new System.Drawing.Size(162, 53);
            this.SL.TabIndex = 1;
            this.SL.Text = "0:00";
            this.SL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SL.Click += new System.EventHandler(this.label2_Click);
            // 
            // BL
            // 
            this.BL.AutoSize = true;
            this.BL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BL.ForeColor = System.Drawing.Color.White;
            this.BL.Location = new System.Drawing.Point(-5, 0);
            this.BL.Name = "BL";
            this.BL.Size = new System.Drawing.Size(617, 104);
            this.BL.TabIndex = 0;
            this.BL.Text = "Oyunu başlatmak için BOŞLUK, Durdurmak için ESC basın.\r\nUçaksavarı hareket ettirm" +
    "ek için SAĞ/SOL yön tuşlarına basın.\r\nAteş etmek için ENTER tuşuna basın.\r\n2.Mer" +
    "mi için TAB tuşuna basın.\r\n";
            this.BL.Click += new System.EventHandler(this.label1_Click);
            // 
            // gemisavarPanel
            // 
            this.gemisavarPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gemisavarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gemisavarPanel.Location = new System.Drawing.Point(0, 350);
            this.gemisavarPanel.Name = "gemisavarPanel";
            this.gemisavarPanel.Size = new System.Drawing.Size(800, 100);
            this.gemisavarPanel.TabIndex = 0;
            this.gemisavarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // savasalaniPanel
            // 
            this.savasalaniPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.savasalaniPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savasalaniPanel.Location = new System.Drawing.Point(0, 112);
            this.savasalaniPanel.Name = "savasalaniPanel";
            this.savasalaniPanel.Size = new System.Drawing.Size(800, 238);
            this.savasalaniPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(537, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Puan:";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.savasalaniPanel);
            this.Controls.Add(this.gemisavarPanel);
            this.Controls.Add(this.bilgialaniPanel);
            this.Name = "AnaForm";
            this.Text = "Savaş Oyunu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnaForm_KeyDown);
            this.bilgialaniPanel.ResumeLayout(false);
            this.bilgialaniPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bilgialaniPanel;
        private System.Windows.Forms.Panel gemisavarPanel;
        private System.Windows.Forms.Label BL;
        private System.Windows.Forms.Panel savasalaniPanel;
        private System.Windows.Forms.Label SL;
        private System.Windows.Forms.Label Skor;
        private System.Windows.Forms.Label label1;
    }
}

