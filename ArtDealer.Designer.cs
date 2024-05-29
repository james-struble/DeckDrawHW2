namespace DeckDrawHW1
{
    partial class ArtDealer
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DrawButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.card1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rankBoxCard4 = new System.Windows.Forms.ComboBox();
            this.suitBoxCard4 = new System.Windows.Forms.ComboBox();
            this.rankBoxCard3 = new System.Windows.Forms.ComboBox();
            this.suitBoxCard3 = new System.Windows.Forms.ComboBox();
            this.rankBoxCard2 = new System.Windows.Forms.ComboBox();
            this.suitBoxCard2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rankBoxCard1 = new System.Windows.Forms.ComboBox();
            this.suitBoxCard1 = new System.Windows.Forms.ComboBox();
            this.infoBox = new System.Windows.Forms.Label();
            this.card4 = new System.Windows.Forms.PictureBox();
            this.card3 = new System.Windows.Forms.PictureBox();
            this.card2 = new System.Windows.Forms.PictureBox();
            this.PickACardMesage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // DrawButton
            // 
            this.DrawButton.BackColor = System.Drawing.Color.Green;
            this.DrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawButton.ForeColor = System.Drawing.Color.White;
            this.DrawButton.Location = new System.Drawing.Point(145, 513);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(327, 83);
            this.DrawButton.TabIndex = 0;
            this.DrawButton.Text = "Draw";
            this.DrawButton.UseVisualStyleBackColor = false;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.Red;
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StopButton.Location = new System.Drawing.Point(580, 513);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(327, 83);
            this.StopButton.TabIndex = 5;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(331, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1);
            this.label1.Size = new System.Drawing.Size(419, 63);
            this.label1.TabIndex = 6;
            this.label1.Text = "The Art Dealer";
            // 
            // card1
            // 
            this.card1.BackColor = System.Drawing.Color.Transparent;
            this.card1.Location = new System.Drawing.Point(254, 193);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(142, 215);
            this.card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card1.TabIndex = 7;
            this.card1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.groupBox1.BackgroundImage = global::DeckDrawHW1.Properties.Resources.poker_table_texture;
            this.groupBox1.Controls.Add(this.PickACardMesage);
            this.groupBox1.Controls.Add(this.ResetButton);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rankBoxCard4);
            this.groupBox1.Controls.Add(this.suitBoxCard4);
            this.groupBox1.Controls.Add(this.rankBoxCard3);
            this.groupBox1.Controls.Add(this.suitBoxCard3);
            this.groupBox1.Controls.Add(this.rankBoxCard2);
            this.groupBox1.Controls.Add(this.suitBoxCard2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rankBoxCard1);
            this.groupBox1.Controls.Add(this.suitBoxCard1);
            this.groupBox1.Controls.Add(this.infoBox);
            this.groupBox1.Controls.Add(this.card4);
            this.groupBox1.Controls.Add(this.card3);
            this.groupBox1.Controls.Add(this.card2);
            this.groupBox1.Controls.Add(this.card1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.StopButton);
            this.groupBox1.Controls.Add(this.DrawButton);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1087, 604);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // ResetButton
            // 
            this.ResetButton.AutoSize = true;
            this.ResetButton.BackColor = System.Drawing.Color.Green;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(145, 513);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(327, 83);
            this.ResetButton.TabIndex = 23;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(921, 66);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(130, 144);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(915, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "HISTORY";
            // 
            // rankBoxCard4
            // 
            this.rankBoxCard4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rankBoxCard4.FormattingEnabled = true;
            this.rankBoxCard4.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Jack",
            "Queen",
            "King",
            "Ace"});
            this.rankBoxCard4.Location = new System.Drawing.Point(698, 419);
            this.rankBoxCard4.Name = "rankBoxCard4";
            this.rankBoxCard4.Size = new System.Drawing.Size(142, 21);
            this.rankBoxCard4.TabIndex = 21;
            this.rankBoxCard4.SelectedIndexChanged += new System.EventHandler(this.rankBoxCard4_SelectedIndexChanged);
            // 
            // suitBoxCard4
            // 
            this.suitBoxCard4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suitBoxCard4.FormattingEnabled = true;
            this.suitBoxCard4.Items.AddRange(new object[] {
            "Hearts",
            "Clubs",
            "Diamonds",
            "Spades"});
            this.suitBoxCard4.Location = new System.Drawing.Point(698, 446);
            this.suitBoxCard4.Name = "suitBoxCard4";
            this.suitBoxCard4.Size = new System.Drawing.Size(142, 21);
            this.suitBoxCard4.TabIndex = 20;
            this.suitBoxCard4.SelectedIndexChanged += new System.EventHandler(this.suitBoxCard4_SelectedIndexChanged);
            // 
            // rankBoxCard3
            // 
            this.rankBoxCard3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rankBoxCard3.FormattingEnabled = true;
            this.rankBoxCard3.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Jack",
            "Queen",
            "King",
            "Ace"});
            this.rankBoxCard3.Location = new System.Drawing.Point(550, 419);
            this.rankBoxCard3.Name = "rankBoxCard3";
            this.rankBoxCard3.Size = new System.Drawing.Size(142, 21);
            this.rankBoxCard3.TabIndex = 19;
            this.rankBoxCard3.SelectedIndexChanged += new System.EventHandler(this.rankBoxCard3_SelectedIndexChanged);
            // 
            // suitBoxCard3
            // 
            this.suitBoxCard3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suitBoxCard3.FormattingEnabled = true;
            this.suitBoxCard3.Items.AddRange(new object[] {
            "Hearts",
            "Clubs",
            "Diamonds",
            "Spades"});
            this.suitBoxCard3.Location = new System.Drawing.Point(550, 446);
            this.suitBoxCard3.Name = "suitBoxCard3";
            this.suitBoxCard3.Size = new System.Drawing.Size(142, 21);
            this.suitBoxCard3.TabIndex = 18;
            this.suitBoxCard3.SelectedIndexChanged += new System.EventHandler(this.suitBoxCard3_SelectedIndexChanged);
            // 
            // rankBoxCard2
            // 
            this.rankBoxCard2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rankBoxCard2.FormattingEnabled = true;
            this.rankBoxCard2.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Jack",
            "Queen",
            "King",
            "Ace"});
            this.rankBoxCard2.Location = new System.Drawing.Point(402, 419);
            this.rankBoxCard2.Name = "rankBoxCard2";
            this.rankBoxCard2.Size = new System.Drawing.Size(142, 21);
            this.rankBoxCard2.TabIndex = 17;
            this.rankBoxCard2.SelectedIndexChanged += new System.EventHandler(this.rankBoxCard2_SelectedIndexChanged);
            // 
            // suitBoxCard2
            // 
            this.suitBoxCard2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suitBoxCard2.FormattingEnabled = true;
            this.suitBoxCard2.Items.AddRange(new object[] {
            "Hearts",
            "Clubs",
            "Diamonds",
            "Spades"});
            this.suitBoxCard2.Location = new System.Drawing.Point(402, 446);
            this.suitBoxCard2.Name = "suitBoxCard2";
            this.suitBoxCard2.Size = new System.Drawing.Size(142, 21);
            this.suitBoxCard2.TabIndex = 16;
            this.suitBoxCard2.SelectedIndexChanged += new System.EventHandler(this.suitBoxCard2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Suit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Rank";
            // 
            // rankBoxCard1
            // 
            this.rankBoxCard1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rankBoxCard1.FormattingEnabled = true;
            this.rankBoxCard1.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Jack",
            "Queen",
            "King",
            "Ace"});
            this.rankBoxCard1.Location = new System.Drawing.Point(254, 419);
            this.rankBoxCard1.Name = "rankBoxCard1";
            this.rankBoxCard1.Size = new System.Drawing.Size(142, 21);
            this.rankBoxCard1.TabIndex = 13;
            this.rankBoxCard1.SelectedIndexChanged += new System.EventHandler(this.rankBoxCard1_SelectedIndexChanged);
            // 
            // suitBoxCard1
            // 
            this.suitBoxCard1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suitBoxCard1.FormattingEnabled = true;
            this.suitBoxCard1.Items.AddRange(new object[] {
            "Hearts",
            "Clubs",
            "Diamonds",
            "Spades"});
            this.suitBoxCard1.Location = new System.Drawing.Point(254, 446);
            this.suitBoxCard1.Name = "suitBoxCard1";
            this.suitBoxCard1.Size = new System.Drawing.Size(142, 21);
            this.suitBoxCard1.TabIndex = 12;
            this.suitBoxCard1.SelectedIndexChanged += new System.EventHandler(this.suitBoxCard1_SelectedIndexChanged);
            // 
            // infoBox
            // 
            this.infoBox.AutoSize = true;
            this.infoBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.infoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.infoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoBox.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.infoBox.Location = new System.Drawing.Point(3, 16);
            this.infoBox.Name = "infoBox";
            this.infoBox.Padding = new System.Windows.Forms.Padding(3);
            this.infoBox.Size = new System.Drawing.Size(327, 128);
            this.infoBox.TabIndex = 11;
            this.infoBox.Text = "Information Panel\r\n\r\n1: Click the dropdown menus to select cards\r\n2. Click Draw t" +
    "o confirm card selections\r\n3. Click Reset to clear card selections\r\n3. Click Sto" +
    "p to close the application";
            // 
            // card4
            // 
            this.card4.BackColor = System.Drawing.Color.Transparent;
            this.card4.Location = new System.Drawing.Point(698, 193);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(142, 215);
            this.card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card4.TabIndex = 10;
            this.card4.TabStop = false;
            // 
            // card3
            // 
            this.card3.BackColor = System.Drawing.Color.Transparent;
            this.card3.Location = new System.Drawing.Point(550, 193);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(142, 215);
            this.card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card3.TabIndex = 9;
            this.card3.TabStop = false;
            // 
            // card2
            // 
            this.card2.BackColor = System.Drawing.Color.Transparent;
            this.card2.Location = new System.Drawing.Point(402, 193);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(142, 215);
            this.card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card2.TabIndex = 8;
            this.card2.TabStop = false;
            // 
            // PickACardMesage
            // 
            this.PickACardMesage.AutoSize = true;
            this.PickACardMesage.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PickACardMesage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.PickACardMesage.Location = new System.Drawing.Point(402, 109);
            this.PickACardMesage.Name = "PickACardMesage";
            this.PickACardMesage.Size = new System.Drawing.Size(290, 62);
            this.PickACardMesage.TabIndex = 24;
            this.PickACardMesage.Text = "Pick a Card! Any Card!\r\n(No duplicates!)";
            this.PickACardMesage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ArtDealer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1089, 620);
            this.Controls.Add(this.groupBox1);
            this.Name = "ArtDealer";
            this.Text = "Art Dealer";
            this.Load += new System.EventHandler(this.ArtDealer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.card1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox card1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox card4;
        private System.Windows.Forms.PictureBox card3;
        private System.Windows.Forms.PictureBox card2;
        private System.Windows.Forms.Label infoBox;
        private System.Windows.Forms.ComboBox suitBoxCard1;
        private System.Windows.Forms.ComboBox rankBoxCard1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox rankBoxCard4;
        private System.Windows.Forms.ComboBox suitBoxCard4;
        private System.Windows.Forms.ComboBox rankBoxCard3;
        private System.Windows.Forms.ComboBox suitBoxCard3;
        private System.Windows.Forms.ComboBox rankBoxCard2;
        private System.Windows.Forms.ComboBox suitBoxCard2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label PickACardMesage;
    }
}

