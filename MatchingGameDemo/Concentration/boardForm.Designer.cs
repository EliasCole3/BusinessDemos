namespace Concentration
{
    partial class boardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(boardForm));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.card1 = new System.Windows.Forms.PictureBox();
            this.card2 = new System.Windows.Forms.PictureBox();
            this.card3 = new System.Windows.Forms.PictureBox();
            this.card4 = new System.Windows.Forms.PictureBox();
            this.card5 = new System.Windows.Forms.PictureBox();
            this.card6 = new System.Windows.Forms.PictureBox();
            this.card19 = new System.Windows.Forms.PictureBox();
            this.card18 = new System.Windows.Forms.PictureBox();
            this.card17 = new System.Windows.Forms.PictureBox();
            this.card16 = new System.Windows.Forms.PictureBox();
            this.card15 = new System.Windows.Forms.PictureBox();
            this.card14 = new System.Windows.Forms.PictureBox();
            this.card20 = new System.Windows.Forms.PictureBox();
            this.card12 = new System.Windows.Forms.PictureBox();
            this.card11 = new System.Windows.Forms.PictureBox();
            this.card10 = new System.Windows.Forms.PictureBox();
            this.card9 = new System.Windows.Forms.PictureBox();
            this.card8 = new System.Windows.Forms.PictureBox();
            this.card7 = new System.Windows.Forms.PictureBox();
            this.card13 = new System.Windows.Forms.PictureBox();
            this.lblElapsedTime = new System.Windows.Forms.Label();
            this.flipTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card13)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // card1
            // 
            this.card1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("card1.ErrorImage")));
            this.card1.Image = ((System.Drawing.Image)(resources.GetObject("card1.Image")));
            this.card1.InitialImage = ((System.Drawing.Image)(resources.GetObject("card1.InitialImage")));
            this.card1.Location = new System.Drawing.Point(21, 18);
            this.card1.Margin = new System.Windows.Forms.Padding(2);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(82, 124);
            this.card1.TabIndex = 0;
            this.card1.TabStop = false;
            this.card1.Click += new System.EventHandler(this.card_Click);
            // 
            // card2
            // 
            this.card2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("card2.ErrorImage")));
            this.card2.Image = ((System.Drawing.Image)(resources.GetObject("card2.Image")));
            this.card2.InitialImage = ((System.Drawing.Image)(resources.GetObject("card2.InitialImage")));
            this.card2.Location = new System.Drawing.Point(121, 18);
            this.card2.Margin = new System.Windows.Forms.Padding(2);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(80, 124);
            this.card2.TabIndex = 1;
            this.card2.TabStop = false;
            this.card2.Click += new System.EventHandler(this.card_Click);
            // 
            // card3
            // 
            this.card3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("card3.ErrorImage")));
            this.card3.Image = ((System.Drawing.Image)(resources.GetObject("card3.Image")));
            this.card3.InitialImage = ((System.Drawing.Image)(resources.GetObject("card3.InitialImage")));
            this.card3.Location = new System.Drawing.Point(215, 18);
            this.card3.Margin = new System.Windows.Forms.Padding(2);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(81, 124);
            this.card3.TabIndex = 2;
            this.card3.TabStop = false;
            this.card3.Click += new System.EventHandler(this.card_Click);
            // 
            // card4
            // 
            this.card4.ErrorImage = ((System.Drawing.Image)(resources.GetObject("card4.ErrorImage")));
            this.card4.Image = ((System.Drawing.Image)(resources.GetObject("card4.Image")));
            this.card4.InitialImage = ((System.Drawing.Image)(resources.GetObject("card4.InitialImage")));
            this.card4.Location = new System.Drawing.Point(312, 18);
            this.card4.Margin = new System.Windows.Forms.Padding(2);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(83, 124);
            this.card4.TabIndex = 3;
            this.card4.TabStop = false;
            this.card4.Click += new System.EventHandler(this.card_Click);
            // 
            // card5
            // 
            this.card5.ErrorImage = ((System.Drawing.Image)(resources.GetObject("card5.ErrorImage")));
            this.card5.Image = ((System.Drawing.Image)(resources.GetObject("card5.Image")));
            this.card5.InitialImage = ((System.Drawing.Image)(resources.GetObject("card5.InitialImage")));
            this.card5.Location = new System.Drawing.Point(413, 18);
            this.card5.Margin = new System.Windows.Forms.Padding(2);
            this.card5.Name = "card5";
            this.card5.Size = new System.Drawing.Size(84, 124);
            this.card5.TabIndex = 4;
            this.card5.TabStop = false;
            this.card5.Click += new System.EventHandler(this.card_Click);
            // 
            // card6
            // 
            this.card6.ErrorImage = ((System.Drawing.Image)(resources.GetObject("card6.ErrorImage")));
            this.card6.Image = ((System.Drawing.Image)(resources.GetObject("card6.Image")));
            this.card6.InitialImage = ((System.Drawing.Image)(resources.GetObject("card6.InitialImage")));
            this.card6.Location = new System.Drawing.Point(21, 158);
            this.card6.Margin = new System.Windows.Forms.Padding(2);
            this.card6.Name = "card6";
            this.card6.Size = new System.Drawing.Size(82, 122);
            this.card6.TabIndex = 5;
            this.card6.TabStop = false;
            this.card6.Click += new System.EventHandler(this.card_Click);
            // 
            // card19
            // 
            this.card19.ErrorImage = ((System.Drawing.Image)(resources.GetObject("card19.ErrorImage")));
            this.card19.Image = ((System.Drawing.Image)(resources.GetObject("card19.Image")));
            this.card19.InitialImage = ((System.Drawing.Image)(resources.GetObject("card19.InitialImage")));
            this.card19.Location = new System.Drawing.Point(316, 432);
            this.card19.Margin = new System.Windows.Forms.Padding(2);
            this.card19.Name = "card19";
            this.card19.Size = new System.Drawing.Size(83, 139);
            this.card19.TabIndex = 11;
            this.card19.TabStop = false;
            this.card19.Click += new System.EventHandler(this.card_Click);
            // 
            // card18
            // 
            this.card18.ErrorImage = ((System.Drawing.Image)(resources.GetObject("card18.ErrorImage")));
            this.card18.Image = ((System.Drawing.Image)(resources.GetObject("card18.Image")));
            this.card18.InitialImage = ((System.Drawing.Image)(resources.GetObject("card18.InitialImage")));
            this.card18.Location = new System.Drawing.Point(219, 432);
            this.card18.Margin = new System.Windows.Forms.Padding(2);
            this.card18.Name = "card18";
            this.card18.Size = new System.Drawing.Size(81, 139);
            this.card18.TabIndex = 10;
            this.card18.TabStop = false;
            this.card18.Click += new System.EventHandler(this.card_Click);
            // 
            // card17
            // 
            this.card17.ErrorImage = ((System.Drawing.Image)(resources.GetObject("card17.ErrorImage")));
            this.card17.Image = ((System.Drawing.Image)(resources.GetObject("card17.Image")));
            this.card17.InitialImage = ((System.Drawing.Image)(resources.GetObject("card17.InitialImage")));
            this.card17.Location = new System.Drawing.Point(121, 432);
            this.card17.Margin = new System.Windows.Forms.Padding(2);
            this.card17.Name = "card17";
            this.card17.Size = new System.Drawing.Size(80, 139);
            this.card17.TabIndex = 9;
            this.card17.TabStop = false;
            this.card17.Click += new System.EventHandler(this.card_Click);
            // 
            // card16
            // 
            this.card16.ErrorImage = ((System.Drawing.Image)(resources.GetObject("card16.ErrorImage")));
            this.card16.Image = ((System.Drawing.Image)(resources.GetObject("card16.Image")));
            this.card16.InitialImage = ((System.Drawing.Image)(resources.GetObject("card16.InitialImage")));
            this.card16.Location = new System.Drawing.Point(21, 432);
            this.card16.Margin = new System.Windows.Forms.Padding(2);
            this.card16.Name = "card16";
            this.card16.Size = new System.Drawing.Size(82, 123);
            this.card16.TabIndex = 8;
            this.card16.TabStop = false;
            this.card16.Click += new System.EventHandler(this.card_Click);
            // 
            // card15
            // 
            this.card15.ErrorImage = ((System.Drawing.Image)(resources.GetObject("card15.ErrorImage")));
            this.card15.Image = ((System.Drawing.Image)(resources.GetObject("card15.Image")));
            this.card15.InitialImage = ((System.Drawing.Image)(resources.GetObject("card15.InitialImage")));
            this.card15.Location = new System.Drawing.Point(413, 295);
            this.card15.Margin = new System.Windows.Forms.Padding(2);
            this.card15.Name = "card15";
            this.card15.Size = new System.Drawing.Size(79, 139);
            this.card15.TabIndex = 7;
            this.card15.TabStop = false;
            this.card15.Click += new System.EventHandler(this.card_Click);
            // 
            // card14
            // 
            this.card14.ErrorImage = ((System.Drawing.Image)(resources.GetObject("card14.ErrorImage")));
            this.card14.Image = ((System.Drawing.Image)(resources.GetObject("card14.Image")));
            this.card14.InitialImage = ((System.Drawing.Image)(resources.GetObject("card14.InitialImage")));
            this.card14.Location = new System.Drawing.Point(312, 295);
            this.card14.Margin = new System.Windows.Forms.Padding(2);
            this.card14.Name = "card14";
            this.card14.Size = new System.Drawing.Size(83, 139);
            this.card14.TabIndex = 6;
            this.card14.TabStop = false;
            this.card14.Click += new System.EventHandler(this.card_Click);
            // 
            // card20
            // 
            this.card20.ErrorImage = ((System.Drawing.Image)(resources.GetObject("card20.ErrorImage")));
            this.card20.Image = ((System.Drawing.Image)(resources.GetObject("card20.Image")));
            this.card20.InitialImage = ((System.Drawing.Image)(resources.GetObject("card20.InitialImage")));
            this.card20.Location = new System.Drawing.Point(413, 432);
            this.card20.Margin = new System.Windows.Forms.Padding(2);
            this.card20.Name = "card20";
            this.card20.Size = new System.Drawing.Size(79, 139);
            this.card20.TabIndex = 30;
            this.card20.TabStop = false;
            this.card20.Click += new System.EventHandler(this.card_Click);
            // 
            // card12
            // 
            this.card12.ErrorImage = ((System.Drawing.Image)(resources.GetObject("card12.ErrorImage")));
            this.card12.Image = ((System.Drawing.Image)(resources.GetObject("card12.Image")));
            this.card12.InitialImage = ((System.Drawing.Image)(resources.GetObject("card12.InitialImage")));
            this.card12.Location = new System.Drawing.Point(121, 295);
            this.card12.Margin = new System.Windows.Forms.Padding(2);
            this.card12.Name = "card12";
            this.card12.Size = new System.Drawing.Size(80, 139);
            this.card12.TabIndex = 29;
            this.card12.TabStop = false;
            this.card12.Click += new System.EventHandler(this.card_Click);
            // 
            // card11
            // 
            this.card11.ErrorImage = ((System.Drawing.Image)(resources.GetObject("card11.ErrorImage")));
            this.card11.Image = ((System.Drawing.Image)(resources.GetObject("card11.Image")));
            this.card11.InitialImage = ((System.Drawing.Image)(resources.GetObject("card11.InitialImage")));
            this.card11.Location = new System.Drawing.Point(21, 295);
            this.card11.Margin = new System.Windows.Forms.Padding(2);
            this.card11.Name = "card11";
            this.card11.Size = new System.Drawing.Size(82, 121);
            this.card11.TabIndex = 28;
            this.card11.TabStop = false;
            this.card11.Click += new System.EventHandler(this.card_Click);
            // 
            // card10
            // 
            this.card10.ErrorImage = ((System.Drawing.Image)(resources.GetObject("card10.ErrorImage")));
            this.card10.Image = ((System.Drawing.Image)(resources.GetObject("card10.Image")));
            this.card10.InitialImage = ((System.Drawing.Image)(resources.GetObject("card10.InitialImage")));
            this.card10.Location = new System.Drawing.Point(413, 158);
            this.card10.Margin = new System.Windows.Forms.Padding(2);
            this.card10.Name = "card10";
            this.card10.Size = new System.Drawing.Size(79, 139);
            this.card10.TabIndex = 27;
            this.card10.TabStop = false;
            this.card10.Click += new System.EventHandler(this.card_Click);
            // 
            // card9
            // 
            this.card9.ErrorImage = ((System.Drawing.Image)(resources.GetObject("card9.ErrorImage")));
            this.card9.Image = ((System.Drawing.Image)(resources.GetObject("card9.Image")));
            this.card9.InitialImage = ((System.Drawing.Image)(resources.GetObject("card9.InitialImage")));
            this.card9.Location = new System.Drawing.Point(312, 158);
            this.card9.Margin = new System.Windows.Forms.Padding(2);
            this.card9.Name = "card9";
            this.card9.Size = new System.Drawing.Size(83, 139);
            this.card9.TabIndex = 26;
            this.card9.TabStop = false;
            this.card9.Click += new System.EventHandler(this.card_Click);
            // 
            // card8
            // 
            this.card8.ErrorImage = ((System.Drawing.Image)(resources.GetObject("card8.ErrorImage")));
            this.card8.Image = ((System.Drawing.Image)(resources.GetObject("card8.Image")));
            this.card8.InitialImage = ((System.Drawing.Image)(resources.GetObject("card8.InitialImage")));
            this.card8.Location = new System.Drawing.Point(215, 158);
            this.card8.Margin = new System.Windows.Forms.Padding(2);
            this.card8.Name = "card8";
            this.card8.Size = new System.Drawing.Size(81, 139);
            this.card8.TabIndex = 25;
            this.card8.TabStop = false;
            this.card8.Click += new System.EventHandler(this.card_Click);
            // 
            // card7
            // 
            this.card7.ErrorImage = ((System.Drawing.Image)(resources.GetObject("card7.ErrorImage")));
            this.card7.Image = ((System.Drawing.Image)(resources.GetObject("card7.Image")));
            this.card7.InitialImage = ((System.Drawing.Image)(resources.GetObject("card7.InitialImage")));
            this.card7.Location = new System.Drawing.Point(121, 158);
            this.card7.Margin = new System.Windows.Forms.Padding(2);
            this.card7.Name = "card7";
            this.card7.Size = new System.Drawing.Size(80, 139);
            this.card7.TabIndex = 24;
            this.card7.TabStop = false;
            this.card7.Click += new System.EventHandler(this.card_Click);
            // 
            // card13
            // 
            this.card13.ErrorImage = ((System.Drawing.Image)(resources.GetObject("card13.ErrorImage")));
            this.card13.Image = ((System.Drawing.Image)(resources.GetObject("card13.Image")));
            this.card13.InitialImage = ((System.Drawing.Image)(resources.GetObject("card13.InitialImage")));
            this.card13.Location = new System.Drawing.Point(215, 295);
            this.card13.Margin = new System.Windows.Forms.Padding(2);
            this.card13.Name = "card13";
            this.card13.Size = new System.Drawing.Size(81, 139);
            this.card13.TabIndex = 48;
            this.card13.TabStop = false;
            this.card13.Click += new System.EventHandler(this.card_Click);
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElapsedTime.Location = new System.Drawing.Point(554, 18);
            this.lblElapsedTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.Size = new System.Drawing.Size(133, 35);
            this.lblElapsedTime.TabIndex = 52;
            this.lblElapsedTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flipTimer
            // 
            this.flipTimer.Interval = 2000;
            this.flipTimer.Tick += new System.EventHandler(this.flipTimer_Tick);
            // 
            // boardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(746, 566);
            this.Controls.Add(this.lblElapsedTime);
            this.Controls.Add(this.card13);
            this.Controls.Add(this.card20);
            this.Controls.Add(this.card12);
            this.Controls.Add(this.card11);
            this.Controls.Add(this.card10);
            this.Controls.Add(this.card9);
            this.Controls.Add(this.card8);
            this.Controls.Add(this.card7);
            this.Controls.Add(this.card19);
            this.Controls.Add(this.card18);
            this.Controls.Add(this.card17);
            this.Controls.Add(this.card16);
            this.Controls.Add(this.card15);
            this.Controls.Add(this.card14);
            this.Controls.Add(this.card6);
            this.Controls.Add(this.card5);
            this.Controls.Add(this.card4);
            this.Controls.Add(this.card3);
            this.Controls.Add(this.card2);
            this.Controls.Add(this.card1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "boardForm";
            this.Text = "`216900i-";
            this.Load += new System.EventHandler(this.frmBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card13)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox card1;
        private System.Windows.Forms.PictureBox card2;
        private System.Windows.Forms.PictureBox card3;
        private System.Windows.Forms.PictureBox card4;
        private System.Windows.Forms.PictureBox card5;
        private System.Windows.Forms.PictureBox card6;
        private System.Windows.Forms.PictureBox card19;
        private System.Windows.Forms.PictureBox card18;
        private System.Windows.Forms.PictureBox card17;
        private System.Windows.Forms.PictureBox card16;
        private System.Windows.Forms.PictureBox card15;
        private System.Windows.Forms.PictureBox card14;
        private System.Windows.Forms.PictureBox card20;
        private System.Windows.Forms.PictureBox card12;
        private System.Windows.Forms.PictureBox card11;
        private System.Windows.Forms.PictureBox card10;
        private System.Windows.Forms.PictureBox card9;
        private System.Windows.Forms.PictureBox card8;
        private System.Windows.Forms.PictureBox card7;
        private System.Windows.Forms.PictureBox card13;
        private System.Windows.Forms.Label lblElapsedTime;
        private System.Windows.Forms.Timer flipTimer;
    }
}

