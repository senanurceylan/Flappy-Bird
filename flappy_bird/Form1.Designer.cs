using System;
using System.Windows.Forms;

namespace flappy_bird
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.ustDisk = new System.Windows.Forms.PictureBox();
            this.altDisk = new System.Windows.Forms.PictureBox();
            this.zemin = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.sena = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustDisk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altDisk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).BeginInit();
            this.SuspendLayout();
            // 
            // flappyBird
            // 
            this.flappyBird.Image = global::flappy_bird.Properties.Resources.bird;
            this.flappyBird.Location = new System.Drawing.Point(232, 55);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(47, 42);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            // 
            // ustDisk
            // 
            this.ustDisk.Image = global::flappy_bird.Properties.Resources.pipedown;
            this.ustDisk.Location = new System.Drawing.Point(534, -14);
            this.ustDisk.Name = "ustDisk";
            this.ustDisk.Size = new System.Drawing.Size(76, 146);
            this.ustDisk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ustDisk.TabIndex = 1;
            this.ustDisk.TabStop = false;
            // 
            // altDisk
            // 
            this.altDisk.Image = global::flappy_bird.Properties.Resources.pipe;
            this.altDisk.Location = new System.Drawing.Point(400, 240);
            this.altDisk.Name = "altDisk";
            this.altDisk.Size = new System.Drawing.Size(68, 167);
            this.altDisk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.altDisk.TabIndex = 2;
            this.altDisk.TabStop = false;
            // 
            // zemin
            // 
            this.zemin.Image = global::flappy_bird.Properties.Resources.ground;
            this.zemin.Location = new System.Drawing.Point(-11, 395);
            this.zemin.Name = "zemin";
            this.zemin.Size = new System.Drawing.Size(858, 99);
            this.zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zemin.TabIndex = 3;
            this.zemin.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.NavajoWhite;
            this.scoreText.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreText.Location = new System.Drawing.Point(38, 414);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(122, 44);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "score:0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // sena
            // 
            this.sena.AutoSize = true;
            this.sena.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sena.Location = new System.Drawing.Point(12, 23);
            this.sena.Name = "sena";
            this.sena.Size = new System.Drawing.Size(142, 18);
            this.sena.TabIndex = 5;
            this.sena.Text = "Sena Nur Ceylan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.zemin);
            this.Controls.Add(this.altDisk);
            this.Controls.Add(this.ustDisk);
            this.Controls.Add(this.sena);
            this.Name = "Form1";
            this.Text = "Flappy Bird Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustDisk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altDisk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       /* private void gamekeyisup(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }
        
        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }
        */
        #endregion

        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox ustDisk;
        private System.Windows.Forms.PictureBox altDisk;
        private System.Windows.Forms.PictureBox zemin;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private Label sena;
    }
}

