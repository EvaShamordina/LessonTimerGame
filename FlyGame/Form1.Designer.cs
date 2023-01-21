namespace FlyGame
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.labelScore = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.labelRecorde = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonMENU = new System.Windows.Forms.Button();
            this.buttonEXTEND = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerGame
            // 
            this.timerGame.Interval = 1000;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(12, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(50, 13);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Score : 0";
            this.labelScore.Visible = false;
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(13, 26);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(54, 13);
            this.labelTimer.TabIndex = 2;
            this.labelTimer.Text = "Timer : 15";
            this.labelTimer.Visible = false;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(169, 147);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(107, 79);
            this.buttonPlay.TabIndex = 3;
            this.buttonPlay.Text = "PLAY";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // labelRecorde
            // 
            this.labelRecorde.AutoSize = true;
            this.labelRecorde.Location = new System.Drawing.Point(191, 117);
            this.labelRecorde.Name = "labelRecorde";
            this.labelRecorde.Size = new System.Drawing.Size(60, 13);
            this.labelRecorde.TabIndex = 4;
            this.labelRecorde.Text = "Recorde: 0";
            this.labelRecorde.Click += new System.EventHandler(this.labelRecorde_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(2, 42);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(65, 29);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "STOP";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Visible = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonMENU
            // 
            this.buttonMENU.Location = new System.Drawing.Point(394, 9);
            this.buttonMENU.Name = "buttonMENU";
            this.buttonMENU.Size = new System.Drawing.Size(78, 29);
            this.buttonMENU.TabIndex = 7;
            this.buttonMENU.Text = "MENU";
            this.buttonMENU.UseVisualStyleBackColor = true;
            this.buttonMENU.Visible = false;
            this.buttonMENU.Click += new System.EventHandler(this.buttonMENU_Click_1);
            // 
            // buttonEXTEND
            // 
            this.buttonEXTEND.Location = new System.Drawing.Point(135, 140);
            this.buttonEXTEND.Name = "buttonEXTEND";
            this.buttonEXTEND.Size = new System.Drawing.Size(177, 92);
            this.buttonEXTEND.TabIndex = 8;
            this.buttonEXTEND.Text = "TO EXTEND";
            this.buttonEXTEND.UseVisualStyleBackColor = true;
            this.buttonEXTEND.Visible = false;
            this.buttonEXTEND.Click += new System.EventHandler(this.buttonEXTEND_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "НАЖМИ НА МУХУ ЧТОБЫ СОБРАТЬ МАКСИМАЛЬНОЕ КОЛИЧЕСТВО ОЧКОВ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::FlyGame.Properties.Resources.theplan_001;
            this.pictureBox1.Location = new System.Drawing.Point(176, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEXTEND);
            this.Controls.Add(this.buttonMENU);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.labelRecorde);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labelScore);
            this.Name = "Form1";
            this.Text = "FlyGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Label labelRecorde;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonMENU;
        private System.Windows.Forms.Button buttonEXTEND;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

