﻿namespace IoT_PaymentEmulator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AmountBonusScoreLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ServiceComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ECComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.ParkingCheckBox = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.PayButton = new System.Windows.Forms.Button();
            this.BonusScoreCheckBox = new System.Windows.Forms.CheckBox();
            this.OwnerLabel = new System.Windows.Forms.Label();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.CityLabel = new System.Windows.Forms.Label();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.BlockedCheckBox = new System.Windows.Forms.CheckBox();
            this.ErrorPayLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(681, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello, Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(681, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bonus score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select user:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(8, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 3);
            this.panel1.TabIndex = 999;
            // 
            // UserComboBox
            // 
            this.UserComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.UserComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserComboBox.FormattingEnabled = true;
            this.UserComboBox.Location = new System.Drawing.Point(126, 55);
            this.UserComboBox.Name = "UserComboBox";
            this.UserComboBox.Size = new System.Drawing.Size(170, 24);
            this.UserComboBox.TabIndex = 4;
            this.UserComboBox.SelectionChangeCommitted += new System.EventHandler(this.UserComboBox_TextUpdate);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(308, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name:";
            // 
            // AmountBonusScoreLabel
            // 
            this.AmountBonusScoreLabel.AutoSize = true;
            this.AmountBonusScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountBonusScoreLabel.ForeColor = System.Drawing.Color.Maroon;
            this.AmountBonusScoreLabel.Location = new System.Drawing.Point(780, 58);
            this.AmountBonusScoreLabel.Name = "AmountBonusScoreLabel";
            this.AmountBonusScoreLabel.Size = new System.Drawing.Size(16, 16);
            this.AmountBonusScoreLabel.TabIndex = 6;
            this.AmountBonusScoreLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(487, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Surname:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(367, 58);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(46, 16);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "Empty";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameLabel.Location = new System.Drawing.Point(555, 58);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(46, 16);
            this.SurnameLabel.TabIndex = 10;
            this.SurnameLabel.Text = "Empty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Select service:";
            // 
            // ServiceComboBox
            // 
            this.ServiceComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ServiceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServiceComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceComboBox.FormattingEnabled = true;
            this.ServiceComboBox.Location = new System.Drawing.Point(126, 208);
            this.ServiceComboBox.Name = "ServiceComboBox";
            this.ServiceComboBox.Size = new System.Drawing.Size(170, 24);
            this.ServiceComboBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(307, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Description:";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLabel.ForeColor = System.Drawing.Color.Maroon;
            this.PriceLabel.Location = new System.Drawing.Point(355, 241);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(16, 16);
            this.PriceLabel.TabIndex = 16;
            this.PriceLabel.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(307, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Price:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Select EC:";
            // 
            // ECComboBox
            // 
            this.ECComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ECComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ECComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ECComboBox.FormattingEnabled = true;
            this.ECComboBox.Location = new System.Drawing.Point(126, 131);
            this.ECComboBox.Name = "ECComboBox";
            this.ECComboBox.Size = new System.Drawing.Size(170, 24);
            this.ECComboBox.TabIndex = 18;
            this.ECComboBox.SelectionChangeCommitted += new System.EventHandler(this.ECComboBox_SelectionChangeCommitted);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(359, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 16);
            this.label12.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(308, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "Owner:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressLabel.Location = new System.Drawing.Point(555, 134);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(46, 16);
            this.AddressLabel.TabIndex = 22;
            this.AddressLabel.Text = "Empty";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(487, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 16);
            this.label15.TabIndex = 21;
            this.label15.Text = "Address:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneLabel.Location = new System.Drawing.Point(359, 163);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(46, 16);
            this.PhoneLabel.TabIndex = 24;
            this.PhoneLabel.Text = "Empty";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(308, 163);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 16);
            this.label17.TabIndex = 23;
            this.label17.Text = "Phone:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLabel.Location = new System.Drawing.Point(535, 163);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(46, 16);
            this.EmailLabel.TabIndex = 26;
            this.EmailLabel.Text = "Empty";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(487, 163);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 16);
            this.label19.TabIndex = 25;
            this.label19.Text = "Email:";
            // 
            // ParkingCheckBox
            // 
            this.ParkingCheckBox.AutoSize = true;
            this.ParkingCheckBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ParkingCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParkingCheckBox.Location = new System.Drawing.Point(684, 162);
            this.ParkingCheckBox.Name = "ParkingCheckBox";
            this.ParkingCheckBox.Size = new System.Drawing.Size(80, 20);
            this.ParkingCheckBox.TabIndex = 28;
            this.ParkingCheckBox.Text = "Parking";
            this.ParkingCheckBox.UseVisualStyleBackColor = true;
            this.ParkingCheckBox.Click += new System.EventHandler(this.CheckBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(9, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 1);
            this.panel2.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Location = new System.Drawing.Point(9, 196);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(825, 1);
            this.panel3.TabIndex = 30;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionTextBox.HideSelection = false;
            this.DescriptionTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.DescriptionTextBox.Location = new System.Drawing.Point(436, 210);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ReadOnly = true;
            this.DescriptionTextBox.Size = new System.Drawing.Size(394, 115);
            this.DescriptionTextBox.TabIndex = 31;
            // 
            // PayButton
            // 
            this.PayButton.BackColor = System.Drawing.Color.Maroon;
            this.PayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PayButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.PayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.PayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PayButton.ForeColor = System.Drawing.Color.White;
            this.PayButton.Location = new System.Drawing.Point(358, 350);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(125, 32);
            this.PayButton.TabIndex = 32;
            this.PayButton.Text = "Pay";
            this.PayButton.UseVisualStyleBackColor = false;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // BonusScoreCheckBox
            // 
            this.BonusScoreCheckBox.AutoSize = true;
            this.BonusScoreCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BonusScoreCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BonusScoreCheckBox.ForeColor = System.Drawing.Color.Navy;
            this.BonusScoreCheckBox.Location = new System.Drawing.Point(502, 356);
            this.BonusScoreCheckBox.Name = "BonusScoreCheckBox";
            this.BonusScoreCheckBox.Size = new System.Drawing.Size(173, 20);
            this.BonusScoreCheckBox.TabIndex = 34;
            this.BonusScoreCheckBox.Text = "Pay with bonus score";
            this.BonusScoreCheckBox.UseVisualStyleBackColor = true;
            this.BonusScoreCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // OwnerLabel
            // 
            this.OwnerLabel.AutoSize = true;
            this.OwnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OwnerLabel.Location = new System.Drawing.Point(359, 134);
            this.OwnerLabel.Name = "OwnerLabel";
            this.OwnerLabel.Size = new System.Drawing.Size(46, 16);
            this.OwnerLabel.TabIndex = 35;
            this.OwnerLabel.Text = "Empty";
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalPriceLabel.ForeColor = System.Drawing.Color.Maroon;
            this.TotalPriceLabel.Location = new System.Drawing.Point(221, 353);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(19, 20);
            this.TotalPriceLabel.TabIndex = 37;
            this.TotalPriceLabel.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.ForeColor = System.Drawing.Color.Crimson;
            this.label23.Location = new System.Drawing.Point(122, 353);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(98, 20);
            this.label23.TabIndex = 36;
            this.label23.Text = "Total price:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Maroon;
            this.panel4.Location = new System.Drawing.Point(9, 336);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(825, 1);
            this.panel4.TabIndex = 38;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Lavender;
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(-1, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(844, 39);
            this.panel5.TabIndex = 39;
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityLabel.Location = new System.Drawing.Point(555, 87);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(46, 16);
            this.CityLabel.TabIndex = 1003;
            this.CityLabel.Text = "Empty";
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryLabel.Location = new System.Drawing.Point(367, 87);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(46, 16);
            this.CountryLabel.TabIndex = 1002;
            this.CountryLabel.Text = "Empty";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(487, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 16);
            this.label14.TabIndex = 1001;
            this.label14.Text = "City:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(308, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 16);
            this.label16.TabIndex = 1000;
            this.label16.Text = "Country:";
            // 
            // BlockedCheckBox
            // 
            this.BlockedCheckBox.AutoSize = true;
            this.BlockedCheckBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BlockedCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BlockedCheckBox.Location = new System.Drawing.Point(684, 86);
            this.BlockedCheckBox.Name = "BlockedCheckBox";
            this.BlockedCheckBox.Size = new System.Drawing.Size(84, 20);
            this.BlockedCheckBox.TabIndex = 1004;
            this.BlockedCheckBox.Text = "Blocked";
            this.BlockedCheckBox.UseVisualStyleBackColor = true;
            this.BlockedCheckBox.Click += new System.EventHandler(this.CheckBox1_Click);
            // 
            // ErrorPayLabel
            // 
            this.ErrorPayLabel.AutoSize = true;
            this.ErrorPayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorPayLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorPayLabel.Location = new System.Drawing.Point(123, 387);
            this.ErrorPayLabel.Name = "ErrorPayLabel";
            this.ErrorPayLabel.Size = new System.Drawing.Size(54, 15);
            this.ErrorPayLabel.TabIndex = 1006;
            this.ErrorPayLabel.Text = "ErrorPay";
            this.ErrorPayLabel.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(16, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 411);
            this.Controls.Add(this.ErrorPayLabel);
            this.Controls.Add(this.BlockedCheckBox);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.CountryLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.TotalPriceLabel);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.OwnerLabel);
            this.Controls.Add(this.BonusScoreCheckBox);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ParkingCheckBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ECComboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ServiceComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AmountBonusScoreLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UserComboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(860, 450);
            this.MinimumSize = new System.Drawing.Size(860, 450);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IoT_PaymentEmulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox UserComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AmountBonusScoreLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ServiceComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ECComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox ParkingCheckBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.CheckBox BonusScoreCheckBox;
        private System.Windows.Forms.Label OwnerLabel;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox BlockedCheckBox;
        private System.Windows.Forms.Label ErrorPayLabel;
        private System.Windows.Forms.Button button1;
    }
}

