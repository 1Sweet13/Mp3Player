namespace Mp3_player
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
            this.Playlist = new System.Windows.Forms.ListBox();
            this.SLvolume = new MB.Controls.ColorSlider();
            this.button5 = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SLtime = new MB.Controls.ColorSlider();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Playlist
            // 
            this.Playlist.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Playlist.FormattingEnabled = true;
            this.Playlist.Location = new System.Drawing.Point(233, 168);
            this.Playlist.Name = "Playlist";
            this.Playlist.Size = new System.Drawing.Size(340, 303);
            this.Playlist.TabIndex = 5;
            // 
            // SLvolume
            // 
            this.SLvolume.BackColor = System.Drawing.Color.Transparent;
            this.SLvolume.BarInnerColor = System.Drawing.Color.Black;
            this.SLvolume.BarOuterColor = System.Drawing.Color.Black;
            this.SLvolume.BarPenColor = System.Drawing.Color.Empty;
            this.SLvolume.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.SLvolume.ElapsedInnerColor = System.Drawing.Color.LimeGreen;
            this.SLvolume.ElapsedOuterColor = System.Drawing.Color.LimeGreen;
            this.SLvolume.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SLvolume.LargeChange = ((uint)(5u));
            this.SLvolume.Location = new System.Drawing.Point(649, 31);
            this.SLvolume.Name = "SLvolume";
            this.SLvolume.Size = new System.Drawing.Size(148, 29);
            this.SLvolume.SmallChange = ((uint)(1u));
            this.SLvolume.TabIndex = 6;
            this.SLvolume.Text = "colorSlider1";
            this.SLvolume.ThumbInnerColor = System.Drawing.Color.LimeGreen;
            this.SLvolume.ThumbOuterColor = System.Drawing.Color.LimeGreen;
            this.SLvolume.ThumbPenColor = System.Drawing.Color.LimeGreen;
            this.SLvolume.ThumbRoundRectSize = new System.Drawing.Size(1, 1);
            this.SLvolume.ThumbSize = 11;
            this.SLvolume.Value = 100;
            this.SLvolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SLvolume_Scroll);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::Mp3_player.Properties.Resources.icons8_end_50;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Location = new System.Drawing.Point(476, 28);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(39, 33);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // ButtonStop
            // 
            this.ButtonStop.BackgroundImage = global::Mp3_player.Properties.Resources.icons8_pause_button_32;
            this.ButtonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonStop.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonStop.Location = new System.Drawing.Point(434, 25);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(36, 35);
            this.ButtonStop.TabIndex = 3;
            this.ButtonStop.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::Mp3_player.Properties.Resources.icons8_play_50__1_;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.Location = new System.Drawing.Point(377, 19);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(51, 49);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = global::Mp3_player.Properties.Resources.icons8_stop_circled_32;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStop.Location = new System.Drawing.Point(335, 25);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(36, 35);
            this.btnStop.TabIndex = 1;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Mp3_player.Properties.Resources.icons8_skip_to_start_50;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(290, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 34);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SLtime
            // 
            this.SLtime.BackColor = System.Drawing.Color.Transparent;
            this.SLtime.BarPenColor = System.Drawing.Color.Transparent;
            this.SLtime.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.SLtime.LargeChange = ((uint)(5u));
            this.SLtime.Location = new System.Drawing.Point(12, 111);
            this.SLtime.Name = "SLtime";
            this.SLtime.Size = new System.Drawing.Size(785, 15);
            this.SLtime.SmallChange = ((uint)(1u));
            this.SLtime.TabIndex = 7;
            this.SLtime.Text = "colorSlider1";
            this.SLtime.ThumbInnerColor = System.Drawing.Color.Black;
            this.SLtime.ThumbOuterColor = System.Drawing.Color.Black;
            this.SLtime.ThumbPenColor = System.Drawing.Color.Black;
            this.SLtime.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.SLtime.Value = 0;
            this.SLtime.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SLtime_Scroll);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Playlist);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 483);
            this.panel1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(748, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00:00";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 482);
            this.Controls.Add(this.SLtime);
            this.Controls.Add(this.SLvolume);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dex";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox Playlist;
        private MB.Controls.ColorSlider SLvolume;
        private MB.Controls.ColorSlider SLtime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
    }
}

