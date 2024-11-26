namespace BlingLuxusCalc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bt_Plus = new Button();
            bt_Geteiltdurch = new Button();
            bt_Mal = new Button();
            bt_Minus = new Button();
            bt_0 = new Button();
            bt_1 = new Button();
            bt_2 = new Button();
            bt_3 = new Button();
            bt_4 = new Button();
            bt_5 = new Button();
            bt_6 = new Button();
            bt_7 = new Button();
            bt_8 = new Button();
            bt_9 = new Button();
            bt_Gleich = new Button();
            txtb_Input = new TextBox();
            bt_ClearEntry = new Button();
            txtb_Rechnung = new TextBox();
            bt_Komma = new Button();
            bt_ClearAll = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            bt_Back = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bt_Plus
            // 
            bt_Plus.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_Plus.BackColor = Color.Transparent;
            bt_Plus.BackgroundImage = Properties.Resources.leather_button;
            bt_Plus.BackgroundImageLayout = ImageLayout.Zoom;
            bt_Plus.Cursor = Cursors.Hand;
            bt_Plus.FlatAppearance.BorderColor = Color.Black;
            bt_Plus.FlatAppearance.BorderSize = 0;
            bt_Plus.FlatStyle = FlatStyle.Flat;
            bt_Plus.Font = new Font("Copperplate Gothic Bold", 18F);
            bt_Plus.ForeColor = Color.Black;
            bt_Plus.Location = new Point(355, 590);
            bt_Plus.Margin = new Padding(4, 3, 4, 3);
            bt_Plus.Name = "bt_Plus";
            bt_Plus.Size = new Size(80, 80);
            bt_Plus.TabIndex = 0;
            bt_Plus.Text = "+";
            bt_Plus.UseVisualStyleBackColor = false;
            bt_Plus.Click += bt_Plus_Click;
            // 
            // bt_Geteiltdurch
            // 
            bt_Geteiltdurch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_Geteiltdurch.BackColor = Color.Transparent;
            bt_Geteiltdurch.BackgroundImage = Properties.Resources.leather_button;
            bt_Geteiltdurch.BackgroundImageLayout = ImageLayout.Zoom;
            bt_Geteiltdurch.Cursor = Cursors.Hand;
            bt_Geteiltdurch.FlatAppearance.BorderColor = Color.Black;
            bt_Geteiltdurch.FlatAppearance.BorderSize = 0;
            bt_Geteiltdurch.FlatStyle = FlatStyle.Flat;
            bt_Geteiltdurch.Font = new Font("Copperplate Gothic Bold", 18F);
            bt_Geteiltdurch.ForeColor = Color.Black;
            bt_Geteiltdurch.Location = new Point(355, 306);
            bt_Geteiltdurch.Margin = new Padding(4, 3, 4, 3);
            bt_Geteiltdurch.Name = "bt_Geteiltdurch";
            bt_Geteiltdurch.Size = new Size(80, 80);
            bt_Geteiltdurch.TabIndex = 1;
            bt_Geteiltdurch.Text = "÷";
            bt_Geteiltdurch.UseVisualStyleBackColor = false;
            bt_Geteiltdurch.Click += bt_Geteiltdurch_Click;
            // 
            // bt_Mal
            // 
            bt_Mal.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_Mal.BackColor = Color.Transparent;
            bt_Mal.BackgroundImage = Properties.Resources.leather_button;
            bt_Mal.BackgroundImageLayout = ImageLayout.Zoom;
            bt_Mal.Cursor = Cursors.Hand;
            bt_Mal.FlatAppearance.BorderColor = Color.Black;
            bt_Mal.FlatAppearance.BorderSize = 0;
            bt_Mal.FlatStyle = FlatStyle.Flat;
            bt_Mal.Font = new Font("Copperplate Gothic Bold", 18F);
            bt_Mal.ForeColor = Color.Black;
            bt_Mal.Location = new Point(355, 401);
            bt_Mal.Margin = new Padding(4, 3, 4, 3);
            bt_Mal.Name = "bt_Mal";
            bt_Mal.Size = new Size(80, 80);
            bt_Mal.TabIndex = 2;
            bt_Mal.Text = "×";
            bt_Mal.UseVisualStyleBackColor = false;
            bt_Mal.Click += bt_Mal_Click;
            // 
            // bt_Minus
            // 
            bt_Minus.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_Minus.BackColor = Color.Transparent;
            bt_Minus.BackgroundImage = Properties.Resources.leather_button;
            bt_Minus.BackgroundImageLayout = ImageLayout.Zoom;
            bt_Minus.Cursor = Cursors.Hand;
            bt_Minus.FlatAppearance.BorderColor = Color.Black;
            bt_Minus.FlatAppearance.BorderSize = 0;
            bt_Minus.FlatStyle = FlatStyle.Flat;
            bt_Minus.Font = new Font("Copperplate Gothic Bold", 18F);
            bt_Minus.ForeColor = Color.Black;
            bt_Minus.Location = new Point(355, 495);
            bt_Minus.Margin = new Padding(4, 3, 4, 3);
            bt_Minus.Name = "bt_Minus";
            bt_Minus.Size = new Size(80, 80);
            bt_Minus.TabIndex = 3;
            bt_Minus.Text = "-";
            bt_Minus.UseVisualStyleBackColor = false;
            bt_Minus.Click += bt_Minus_Click;
            // 
            // bt_0
            // 
            bt_0.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_0.BackColor = Color.Transparent;
            bt_0.BackgroundImage = Properties.Resources.leather_button;
            bt_0.BackgroundImageLayout = ImageLayout.Zoom;
            bt_0.Cursor = Cursors.Hand;
            bt_0.FlatAppearance.BorderColor = Color.Black;
            bt_0.FlatAppearance.BorderSize = 0;
            bt_0.FlatStyle = FlatStyle.Flat;
            bt_0.Font = new Font("Copperplate Gothic Bold", 18F);
            bt_0.ForeColor = Color.Black;
            bt_0.Location = new Point(162, 590);
            bt_0.Margin = new Padding(4, 3, 4, 3);
            bt_0.Name = "bt_0";
            bt_0.Size = new Size(80, 80);
            bt_0.TabIndex = 4;
            bt_0.Text = "0";
            bt_0.UseVisualStyleBackColor = false;
            bt_0.Click += bt_0_Click;
            // 
            // bt_1
            // 
            bt_1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_1.BackColor = Color.Transparent;
            bt_1.BackgroundImage = Properties.Resources.leather_button;
            bt_1.BackgroundImageLayout = ImageLayout.Zoom;
            bt_1.Cursor = Cursors.Hand;
            bt_1.FlatAppearance.BorderColor = Color.Black;
            bt_1.FlatAppearance.BorderSize = 0;
            bt_1.FlatStyle = FlatStyle.Flat;
            bt_1.Font = new Font("Copperplate Gothic Bold", 18F);
            bt_1.ForeColor = Color.Black;
            bt_1.Location = new Point(65, 495);
            bt_1.Margin = new Padding(4, 3, 4, 3);
            bt_1.Name = "bt_1";
            bt_1.Size = new Size(80, 80);
            bt_1.TabIndex = 5;
            bt_1.Text = "1";
            bt_1.UseVisualStyleBackColor = false;
            bt_1.Click += bt_1_Click;
            // 
            // bt_2
            // 
            bt_2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_2.BackColor = Color.Transparent;
            bt_2.BackgroundImage = Properties.Resources.leather_button;
            bt_2.BackgroundImageLayout = ImageLayout.Zoom;
            bt_2.Cursor = Cursors.Hand;
            bt_2.FlatAppearance.BorderColor = Color.Black;
            bt_2.FlatAppearance.BorderSize = 0;
            bt_2.FlatStyle = FlatStyle.Flat;
            bt_2.Font = new Font("Copperplate Gothic Bold", 18F);
            bt_2.ForeColor = Color.Black;
            bt_2.Location = new Point(162, 495);
            bt_2.Margin = new Padding(4, 3, 4, 3);
            bt_2.Name = "bt_2";
            bt_2.Size = new Size(80, 80);
            bt_2.TabIndex = 6;
            bt_2.Text = "2";
            bt_2.UseVisualStyleBackColor = false;
            bt_2.Click += bt_2_Click;
            // 
            // bt_3
            // 
            bt_3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_3.BackColor = Color.Transparent;
            bt_3.BackgroundImage = Properties.Resources.leather_button;
            bt_3.BackgroundImageLayout = ImageLayout.Zoom;
            bt_3.Cursor = Cursors.Hand;
            bt_3.FlatAppearance.BorderColor = Color.Black;
            bt_3.FlatAppearance.BorderSize = 0;
            bt_3.FlatStyle = FlatStyle.Flat;
            bt_3.Font = new Font("Copperplate Gothic Bold", 18F);
            bt_3.ForeColor = Color.Black;
            bt_3.Location = new Point(259, 495);
            bt_3.Margin = new Padding(4, 3, 4, 3);
            bt_3.Name = "bt_3";
            bt_3.Size = new Size(80, 80);
            bt_3.TabIndex = 7;
            bt_3.Text = "3";
            bt_3.UseVisualStyleBackColor = false;
            bt_3.Click += bt_3_Click;
            // 
            // bt_4
            // 
            bt_4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_4.BackColor = Color.Transparent;
            bt_4.BackgroundImage = Properties.Resources.leather_button;
            bt_4.BackgroundImageLayout = ImageLayout.Zoom;
            bt_4.Cursor = Cursors.Hand;
            bt_4.FlatAppearance.BorderColor = Color.Black;
            bt_4.FlatAppearance.BorderSize = 0;
            bt_4.FlatStyle = FlatStyle.Flat;
            bt_4.Font = new Font("Copperplate Gothic Bold", 18F);
            bt_4.ForeColor = Color.Black;
            bt_4.Location = new Point(65, 401);
            bt_4.Margin = new Padding(4, 3, 4, 3);
            bt_4.Name = "bt_4";
            bt_4.Size = new Size(80, 80);
            bt_4.TabIndex = 8;
            bt_4.Text = "4";
            bt_4.UseVisualStyleBackColor = false;
            bt_4.Click += bt_4_Click;
            // 
            // bt_5
            // 
            bt_5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_5.BackColor = Color.Transparent;
            bt_5.BackgroundImage = Properties.Resources.leather_button;
            bt_5.BackgroundImageLayout = ImageLayout.Zoom;
            bt_5.Cursor = Cursors.Hand;
            bt_5.FlatAppearance.BorderColor = Color.Black;
            bt_5.FlatAppearance.BorderSize = 0;
            bt_5.FlatStyle = FlatStyle.Flat;
            bt_5.Font = new Font("Copperplate Gothic Bold", 18F);
            bt_5.ForeColor = Color.Black;
            bt_5.Location = new Point(162, 401);
            bt_5.Margin = new Padding(4, 3, 4, 3);
            bt_5.Name = "bt_5";
            bt_5.Size = new Size(80, 80);
            bt_5.TabIndex = 9;
            bt_5.Text = "5";
            bt_5.UseVisualStyleBackColor = false;
            bt_5.Click += bt_5_Click;
            // 
            // bt_6
            // 
            bt_6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_6.BackColor = Color.Transparent;
            bt_6.BackgroundImage = Properties.Resources.leather_button;
            bt_6.BackgroundImageLayout = ImageLayout.Zoom;
            bt_6.Cursor = Cursors.Hand;
            bt_6.FlatAppearance.BorderColor = Color.Black;
            bt_6.FlatAppearance.BorderSize = 0;
            bt_6.FlatStyle = FlatStyle.Flat;
            bt_6.Font = new Font("Copperplate Gothic Bold", 18F);
            bt_6.ForeColor = Color.Black;
            bt_6.Location = new Point(259, 401);
            bt_6.Margin = new Padding(4, 3, 4, 3);
            bt_6.Name = "bt_6";
            bt_6.Size = new Size(80, 80);
            bt_6.TabIndex = 10;
            bt_6.Text = "6";
            bt_6.UseVisualStyleBackColor = false;
            bt_6.Click += bt_6_Click;
            // 
            // bt_7
            // 
            bt_7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_7.BackColor = Color.Transparent;
            bt_7.BackgroundImage = Properties.Resources.leather_button;
            bt_7.BackgroundImageLayout = ImageLayout.Zoom;
            bt_7.Cursor = Cursors.Hand;
            bt_7.FlatAppearance.BorderColor = Color.Black;
            bt_7.FlatAppearance.BorderSize = 0;
            bt_7.FlatStyle = FlatStyle.Flat;
            bt_7.Font = new Font("Copperplate Gothic Bold", 18F);
            bt_7.ForeColor = Color.Black;
            bt_7.Location = new Point(65, 306);
            bt_7.Margin = new Padding(4, 3, 4, 3);
            bt_7.Name = "bt_7";
            bt_7.Size = new Size(80, 80);
            bt_7.TabIndex = 11;
            bt_7.Text = "7";
            bt_7.UseVisualStyleBackColor = false;
            bt_7.Click += bt_7_Click;
            // 
            // bt_8
            // 
            bt_8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_8.BackColor = Color.Transparent;
            bt_8.BackgroundImage = Properties.Resources.leather_button;
            bt_8.BackgroundImageLayout = ImageLayout.Zoom;
            bt_8.Cursor = Cursors.Hand;
            bt_8.FlatAppearance.BorderColor = Color.Black;
            bt_8.FlatAppearance.BorderSize = 0;
            bt_8.FlatStyle = FlatStyle.Flat;
            bt_8.Font = new Font("Copperplate Gothic Bold", 18F);
            bt_8.ForeColor = Color.Black;
            bt_8.Location = new Point(162, 306);
            bt_8.Margin = new Padding(4, 3, 4, 3);
            bt_8.Name = "bt_8";
            bt_8.Size = new Size(80, 80);
            bt_8.TabIndex = 12;
            bt_8.Text = "8";
            bt_8.UseVisualStyleBackColor = false;
            bt_8.Click += bt_8_Click;
            // 
            // bt_9
            // 
            bt_9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_9.BackColor = Color.Transparent;
            bt_9.BackgroundImage = Properties.Resources.leather_button;
            bt_9.BackgroundImageLayout = ImageLayout.Zoom;
            bt_9.Cursor = Cursors.Hand;
            bt_9.FlatAppearance.BorderColor = Color.Black;
            bt_9.FlatAppearance.BorderSize = 0;
            bt_9.FlatStyle = FlatStyle.Flat;
            bt_9.Font = new Font("Copperplate Gothic Bold", 18F);
            bt_9.ForeColor = Color.Black;
            bt_9.Location = new Point(259, 306);
            bt_9.Margin = new Padding(4, 3, 4, 3);
            bt_9.Name = "bt_9";
            bt_9.Size = new Size(80, 80);
            bt_9.TabIndex = 13;
            bt_9.Text = "9";
            bt_9.UseVisualStyleBackColor = false;
            bt_9.Click += bt_9_Click;
            // 
            // bt_Gleich
            // 
            bt_Gleich.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_Gleich.BackColor = Color.Transparent;
            bt_Gleich.BackgroundImage = Properties.Resources.gold_button;
            bt_Gleich.BackgroundImageLayout = ImageLayout.Zoom;
            bt_Gleich.Cursor = Cursors.Hand;
            bt_Gleich.FlatAppearance.BorderColor = Color.Black;
            bt_Gleich.FlatAppearance.BorderSize = 0;
            bt_Gleich.FlatStyle = FlatStyle.Flat;
            bt_Gleich.Font = new Font("Copperplate Gothic Bold", 18F);
            bt_Gleich.ForeColor = Color.Black;
            bt_Gleich.Location = new Point(259, 590);
            bt_Gleich.Margin = new Padding(4, 3, 4, 3);
            bt_Gleich.Name = "bt_Gleich";
            bt_Gleich.Size = new Size(80, 80);
            bt_Gleich.TabIndex = 14;
            bt_Gleich.Text = "=";
            bt_Gleich.UseVisualStyleBackColor = false;
            bt_Gleich.Click += bt_Gleich_Click;
            // 
            // txtb_Input
            // 
            txtb_Input.BackColor = Color.Black;
            txtb_Input.BorderStyle = BorderStyle.None;
            txtb_Input.Font = new Font("Segoe UI", 30F);
            txtb_Input.ForeColor = SystemColors.ScrollBar;
            txtb_Input.Location = new Point(65, 116);
            txtb_Input.Margin = new Padding(4, 3, 4, 3);
            txtb_Input.Name = "txtb_Input";
            txtb_Input.Size = new Size(380, 67);
            txtb_Input.TabIndex = 15;
            txtb_Input.TextAlign = HorizontalAlignment.Right;
            // 
            // bt_ClearEntry
            // 
            bt_ClearEntry.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_ClearEntry.BackColor = Color.Transparent;
            bt_ClearEntry.BackgroundImage = Properties.Resources.leather_button;
            bt_ClearEntry.BackgroundImageLayout = ImageLayout.Zoom;
            bt_ClearEntry.Cursor = Cursors.Hand;
            bt_ClearEntry.FlatAppearance.BorderColor = Color.Black;
            bt_ClearEntry.FlatAppearance.BorderSize = 0;
            bt_ClearEntry.FlatStyle = FlatStyle.Flat;
            bt_ClearEntry.Font = new Font("Copperplate Gothic Bold", 18F);
            bt_ClearEntry.ForeColor = Color.Black;
            bt_ClearEntry.Location = new Point(65, 211);
            bt_ClearEntry.Margin = new Padding(4, 3, 4, 3);
            bt_ClearEntry.Name = "bt_ClearEntry";
            bt_ClearEntry.Size = new Size(80, 80);
            bt_ClearEntry.TabIndex = 16;
            bt_ClearEntry.Text = "CE";
            bt_ClearEntry.UseVisualStyleBackColor = false;
            bt_ClearEntry.Click += bt_ClearEntry_Click;
            // 
            // txtb_Rechnung
            // 
            txtb_Rechnung.BackColor = Color.Black;
            txtb_Rechnung.BorderStyle = BorderStyle.None;
            txtb_Rechnung.Font = new Font("Segoe UI", 15F);
            txtb_Rechnung.ForeColor = SystemColors.ScrollBar;
            txtb_Rechnung.Location = new Point(65, 85);
            txtb_Rechnung.Margin = new Padding(4, 3, 4, 3);
            txtb_Rechnung.Name = "txtb_Rechnung";
            txtb_Rechnung.ReadOnly = true;
            txtb_Rechnung.Size = new Size(380, 34);
            txtb_Rechnung.TabIndex = 17;
            txtb_Rechnung.TextAlign = HorizontalAlignment.Right;
            // 
            // bt_Komma
            // 
            bt_Komma.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_Komma.BackColor = Color.Transparent;
            bt_Komma.BackgroundImage = Properties.Resources.leather_button;
            bt_Komma.BackgroundImageLayout = ImageLayout.Zoom;
            bt_Komma.Cursor = Cursors.Hand;
            bt_Komma.FlatAppearance.BorderColor = Color.Black;
            bt_Komma.FlatAppearance.BorderSize = 0;
            bt_Komma.FlatStyle = FlatStyle.Flat;
            bt_Komma.Font = new Font("Copperplate Gothic Bold", 18F);
            bt_Komma.ForeColor = Color.Black;
            bt_Komma.Location = new Point(65, 590);
            bt_Komma.Margin = new Padding(4, 3, 4, 3);
            bt_Komma.Name = "bt_Komma";
            bt_Komma.Size = new Size(80, 80);
            bt_Komma.TabIndex = 18;
            bt_Komma.Text = ",";
            bt_Komma.UseVisualStyleBackColor = false;
            bt_Komma.Click += bt_Komma_Click;
            // 
            // bt_ClearAll
            // 
            bt_ClearAll.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_ClearAll.BackColor = Color.Transparent;
            bt_ClearAll.BackgroundImage = Properties.Resources.leather_button;
            bt_ClearAll.BackgroundImageLayout = ImageLayout.Zoom;
            bt_ClearAll.Cursor = Cursors.Hand;
            bt_ClearAll.FlatAppearance.BorderColor = Color.Black;
            bt_ClearAll.FlatAppearance.BorderSize = 0;
            bt_ClearAll.FlatStyle = FlatStyle.Flat;
            bt_ClearAll.Font = new Font("Copperplate Gothic Bold", 18F);
            bt_ClearAll.ForeColor = Color.Black;
            bt_ClearAll.Location = new Point(162, 211);
            bt_ClearAll.Margin = new Padding(4, 3, 4, 3);
            bt_ClearAll.Name = "bt_ClearAll";
            bt_ClearAll.Size = new Size(80, 80);
            bt_ClearAll.TabIndex = 19;
            bt_ClearAll.Text = "C";
            bt_ClearAll.UseVisualStyleBackColor = false;
            bt_ClearAll.Click += bt_ClearAll_Click;
            // 
            // bt_Back
            // 
            bt_Back.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_Back.BackColor = Color.Transparent;
            bt_Back.BackgroundImage = Properties.Resources.leather_button;
            bt_Back.BackgroundImageLayout = ImageLayout.Stretch;
            bt_Back.Cursor = Cursors.Hand;
            bt_Back.FlatAppearance.BorderColor = Color.Black;
            bt_Back.FlatAppearance.BorderSize = 0;
            bt_Back.FlatStyle = FlatStyle.Flat;
            bt_Back.Font = new Font("Copperplate Gothic Bold", 18F);
            bt_Back.ForeColor = Color.Black;
            bt_Back.Location = new Point(259, 211);
            bt_Back.Margin = new Padding(4, 3, 4, 3);
            bt_Back.Name = "bt_Back";
            bt_Back.Size = new Size(176, 80);
            bt_Back.TabIndex = 20;
            bt_Back.Text = "↩";
            bt_Back.UseVisualStyleBackColor = false;
            bt_Back.Click += bt_Back_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.bling_logo;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(34, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.mahogany;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(497, 717);
            Controls.Add(txtb_Rechnung);
            Controls.Add(pictureBox1);
            Controls.Add(bt_Back);
            Controls.Add(bt_ClearAll);
            Controls.Add(bt_Komma);
            Controls.Add(bt_ClearEntry);
            Controls.Add(txtb_Input);
            Controls.Add(bt_Gleich);
            Controls.Add(bt_9);
            Controls.Add(bt_8);
            Controls.Add(bt_7);
            Controls.Add(bt_6);
            Controls.Add(bt_5);
            Controls.Add(bt_4);
            Controls.Add(bt_3);
            Controls.Add(bt_2);
            Controls.Add(bt_1);
            Controls.Add(bt_0);
            Controls.Add(bt_Minus);
            Controls.Add(bt_Mal);
            Controls.Add(bt_Geteiltdurch);
            Controls.Add(bt_Plus);
            Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold | FontStyle.Italic);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Teuer, aber kann wenig";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_Plus;
        private Button bt_Geteiltdurch;
        private Button bt_Mal;
        private Button bt_Minus;
        private Button bt_0;
        private Button bt_1;
        private Button bt_2;
        private Button bt_3;
        private Button bt_4;
        private Button bt_5;
        private Button bt_6;
        private Button bt_7;
        private Button bt_8;
        private Button bt_9;
        private Button bt_Gleich;
        private TextBox txtb_Input;
        private Button bt_ClearEntry;
        private TextBox txtb_Rechnung;
        private Button bt_Komma;
        private Button bt_ClearAll;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button bt_Back;
        private PictureBox pictureBox1;
    }
}
