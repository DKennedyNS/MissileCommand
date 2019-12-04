namespace MissileCommand
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GameScreen = new System.Windows.Forms.PictureBox();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonQuit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GroundPictureBox = new System.Windows.Forms.PictureBox();
            this.FlakPictureBox = new System.Windows.Forms.PictureBox();
            this.City1PictureBox = new System.Windows.Forms.PictureBox();
            this.City2PictureBox = new System.Windows.Forms.PictureBox();
            this.City3PictureBox = new System.Windows.Forms.PictureBox();
            this.City4PictureBox = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GameScreen)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroundPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlakPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.City1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.City2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.City3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.City4PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GameScreen
            // 
            this.GameScreen.BackColor = System.Drawing.Color.Transparent;
            this.GameScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GameScreen.BackgroundImage")));
            this.GameScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameScreen.Cursor = System.Windows.Forms.Cursors.Cross;
            this.GameScreen.Location = new System.Drawing.Point(0, 0);
            this.GameScreen.Name = "GameScreen";
            this.GameScreen.Size = new System.Drawing.Size(1024, 1015);
            this.GameScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.GameScreen.TabIndex = 1;
            this.GameScreen.TabStop = false;
            this.GameScreen.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.GameScreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Executor_GameScreenClick);
            // 
            // ButtonReset
            // 
            this.ButtonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonReset.AutoSize = true;
            this.ButtonReset.BackColor = System.Drawing.Color.Crimson;
            this.ButtonReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReset.Location = new System.Drawing.Point(0, 0);
            this.ButtonReset.MaximumSize = new System.Drawing.Size(100, 50);
            this.ButtonReset.MinimumSize = new System.Drawing.Size(100, 50);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(100, 50);
            this.ButtonReset.TabIndex = 0;
            this.ButtonReset.Text = "Reset";
            this.ButtonReset.UseVisualStyleBackColor = false;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonStart.AutoSize = true;
            this.ButtonStart.BackColor = System.Drawing.Color.Crimson;
            this.ButtonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStart.Location = new System.Drawing.Point(408, 0);
            this.ButtonStart.MaximumSize = new System.Drawing.Size(200, 50);
            this.ButtonStart.MinimumSize = new System.Drawing.Size(200, 50);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(200, 50);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "Start Game";
            this.ButtonStart.UseVisualStyleBackColor = false;
            this.ButtonStart.Click += new System.EventHandler(this.Executor_ButtonStartClick);
            // 
            // ButtonQuit
            // 
            this.ButtonQuit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonQuit.AutoSize = true;
            this.ButtonQuit.BackColor = System.Drawing.Color.Crimson;
            this.ButtonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonQuit.Location = new System.Drawing.Point(908, 0);
            this.ButtonQuit.MaximumSize = new System.Drawing.Size(100, 50);
            this.ButtonQuit.MinimumSize = new System.Drawing.Size(100, 50);
            this.ButtonQuit.Name = "ButtonQuit";
            this.ButtonQuit.Size = new System.Drawing.Size(100, 50);
            this.ButtonQuit.TabIndex = 2;
            this.ButtonQuit.Text = "Quit";
            this.ButtonQuit.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.ButtonQuit);
            this.panel1.Controls.Add(this.ButtonStart);
            this.panel1.Controls.Add(this.ButtonReset);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 679);
            this.panel1.MaximumSize = new System.Drawing.Size(0, 50);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 50);
            this.panel1.TabIndex = 2;
            // 
            // GroundPictureBox
            // 
            this.GroundPictureBox.BackColor = System.Drawing.Color.Black;
            this.GroundPictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.GroundPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("GroundPictureBox.Image")));
            this.GroundPictureBox.Location = new System.Drawing.Point(0, 596);
            this.GroundPictureBox.Name = "GroundPictureBox";
            this.GroundPictureBox.Size = new System.Drawing.Size(1008, 84);
            this.GroundPictureBox.TabIndex = 3;
            this.GroundPictureBox.TabStop = false;
            // 
            // FlakPictureBox
            // 
            this.FlakPictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FlakPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("FlakPictureBox.Image")));
            this.FlakPictureBox.Location = new System.Drawing.Point(434, 542);
            this.FlakPictureBox.Name = "FlakPictureBox";
            this.FlakPictureBox.Size = new System.Drawing.Size(146, 64);
            this.FlakPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.FlakPictureBox.TabIndex = 4;
            this.FlakPictureBox.TabStop = false;
            // 
            // City1PictureBox
            // 
            this.City1PictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.City1PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("City1PictureBox.Image")));
            this.City1PictureBox.Location = new System.Drawing.Point(152, 596);
            this.City1PictureBox.Name = "City1PictureBox";
            this.City1PictureBox.Size = new System.Drawing.Size(96, 61);
            this.City1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.City1PictureBox.TabIndex = 5;
            this.City1PictureBox.TabStop = false;
            // 
            // City2PictureBox
            // 
            this.City2PictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.City2PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("City2PictureBox.Image")));
            this.City2PictureBox.Location = new System.Drawing.Point(316, 596);
            this.City2PictureBox.Name = "City2PictureBox";
            this.City2PictureBox.Size = new System.Drawing.Size(96, 61);
            this.City2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.City2PictureBox.TabIndex = 6;
            this.City2PictureBox.TabStop = false;
            // 
            // City3PictureBox
            // 
            this.City3PictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.City3PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("City3PictureBox.Image")));
            this.City3PictureBox.Location = new System.Drawing.Point(601, 596);
            this.City3PictureBox.Name = "City3PictureBox";
            this.City3PictureBox.Size = new System.Drawing.Size(96, 61);
            this.City3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.City3PictureBox.TabIndex = 7;
            this.City3PictureBox.TabStop = false;
            // 
            // City4PictureBox
            // 
            this.City4PictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.City4PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("City4PictureBox.Image")));
            this.City4PictureBox.Location = new System.Drawing.Point(786, 596);
            this.City4PictureBox.Name = "City4PictureBox";
            this.City4PictureBox.Size = new System.Drawing.Size(96, 61);
            this.City4PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.City4PictureBox.TabIndex = 8;
            this.City4PictureBox.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 16;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.City4PictureBox);
            this.Controls.Add(this.City3PictureBox);
            this.Controls.Add(this.City2PictureBox);
            this.Controls.Add(this.City1PictureBox);
            this.Controls.Add(this.FlakPictureBox);
            this.Controls.Add(this.GroundPictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GameScreen);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Missile Command";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.GameScreen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroundPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlakPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.City1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.City2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.City3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.City4PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.PictureBox GameScreen;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonQuit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox GroundPictureBox;
        private System.Windows.Forms.PictureBox FlakPictureBox;
        private System.Windows.Forms.PictureBox City1PictureBox;
        private System.Windows.Forms.PictureBox City2PictureBox;
        private System.Windows.Forms.PictureBox City3PictureBox;
        private System.Windows.Forms.PictureBox City4PictureBox;
        private System.Windows.Forms.Timer GameTimer;
    }
}

