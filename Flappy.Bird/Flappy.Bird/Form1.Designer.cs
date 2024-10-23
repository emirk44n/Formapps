namespace Flappy.Bird
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
            this.pipe_down = new System.Windows.Forms.PictureBox();
            this.pipe_up = new System.Windows.Forms.PictureBox();
            this.flappy = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pipe_down
            // 
            this.pipe_down.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pipe_down.BackgroundImage = global::Flappy.Bird.Properties.Resources.Screenshot_12;
            this.pipe_down.Image = global::Flappy.Bird.Properties.Resources.pipe_bottom;
            this.pipe_down.Location = new System.Drawing.Point(441, 440);
            this.pipe_down.Name = "pipe_down";
            this.pipe_down.Size = new System.Drawing.Size(99, 218);
            this.pipe_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe_down.TabIndex = 5;
            this.pipe_down.TabStop = false;
            // 
            // pipe_up
            // 
            this.pipe_up.BackgroundImage = global::Flappy.Bird.Properties.Resources.Screenshot_12;
            this.pipe_up.Image = global::Flappy.Bird.Properties.Resources.pipe_top;
            this.pipe_up.Location = new System.Drawing.Point(441, 0);
            this.pipe_up.Name = "pipe_up";
            this.pipe_up.Size = new System.Drawing.Size(99, 214);
            this.pipe_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe_up.TabIndex = 4;
            this.pipe_up.TabStop = false;
            // 
            // flappy
            // 
            this.flappy.BackColor = System.Drawing.Color.Transparent;
            this.flappy.BackgroundImage = global::Flappy.Bird.Properties.Resources.Screenshot_12;
            this.flappy.Image = global::Flappy.Bird.Properties.Resources.fly;
            this.flappy.Location = new System.Drawing.Point(28, 306);
            this.flappy.Name = "flappy";
            this.flappy.Size = new System.Drawing.Size(91, 64);
            this.flappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappy.TabIndex = 3;
            this.flappy.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::Flappy.Bird.Properties.Resources.Screenshot_121;
            this.ground.Location = new System.Drawing.Point(0, 653);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(630, 168);
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.DarkCyan;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.scoreLabel.Location = new System.Drawing.Point(12, 30);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(251, 58);
            this.scoreLabel.TabIndex = 6;
            this.scoreLabel.Text = "SCORE:0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Flappy.Bird.Properties.Resources.Screenshot_12;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(632, 753);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(632, 753);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.pipe_down);
            this.Controls.Add(this.pipe_up);
            this.Controls.Add(this.flappy);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pipe_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox flappy;
        private System.Windows.Forms.PictureBox pipe_up;
        private System.Windows.Forms.PictureBox pipe_down;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

