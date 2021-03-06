namespace CinemaInformationSystemApp
{
    partial class SellTicketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellTicketForm));
            this.label1 = new System.Windows.Forms.Label();
            this.ChooseMovieComboBox = new System.Windows.Forms.ComboBox();
            this.ChooseMovieNextButton = new System.Windows.Forms.Button();
            this.MovieInformationTextBox = new System.Windows.Forms.TextBox();
            this.ChoosePlacesButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CinemaSeatsPictureBox = new System.Windows.Forms.PictureBox();
            this.ChooseAuditoriumComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RowCountTextBox = new System.Windows.Forms.TextBox();
            this.RowSeatsCountTextBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PriceComboBox = new System.Windows.Forms.ComboBox();
            this.TicketCountComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.auditoriumIdBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.AdNewClient = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.MovieIdTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CinemaSeatsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose movie:";
            // 
            // ChooseMovieComboBox
            // 
            this.ChooseMovieComboBox.FormattingEnabled = true;
            this.ChooseMovieComboBox.Location = new System.Drawing.Point(138, 9);
            this.ChooseMovieComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChooseMovieComboBox.Name = "ChooseMovieComboBox";
            this.ChooseMovieComboBox.Size = new System.Drawing.Size(381, 28);
            this.ChooseMovieComboBox.TabIndex = 1;
            this.ChooseMovieComboBox.SelectedIndexChanged += new System.EventHandler(this.ChooseMovieComboBox_SelectedIndexChanged);
            // 
            // ChooseMovieNextButton
            // 
            this.ChooseMovieNextButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChooseMovieNextButton.Location = new System.Drawing.Point(14, 201);
            this.ChooseMovieNextButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChooseMovieNextButton.Name = "ChooseMovieNextButton";
            this.ChooseMovieNextButton.Size = new System.Drawing.Size(255, 37);
            this.ChooseMovieNextButton.TabIndex = 2;
            this.ChooseMovieNextButton.Text = "Next";
            this.ChooseMovieNextButton.UseVisualStyleBackColor = true;
            this.ChooseMovieNextButton.Click += new System.EventHandler(this.ChooseMovieNextButton_Click);
            // 
            // MovieInformationTextBox
            // 
            this.MovieInformationTextBox.Location = new System.Drawing.Point(14, 246);
            this.MovieInformationTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MovieInformationTextBox.Multiline = true;
            this.MovieInformationTextBox.Name = "MovieInformationTextBox";
            this.MovieInformationTextBox.ReadOnly = true;
            this.MovieInformationTextBox.Size = new System.Drawing.Size(505, 136);
            this.MovieInformationTextBox.TabIndex = 3;
            // 
            // ChoosePlacesButton
            // 
            this.ChoosePlacesButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChoosePlacesButton.Location = new System.Drawing.Point(14, 390);
            this.ChoosePlacesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChoosePlacesButton.Name = "ChoosePlacesButton";
            this.ChoosePlacesButton.Size = new System.Drawing.Size(238, 31);
            this.ChoosePlacesButton.TabIndex = 4;
            this.ChoosePlacesButton.Text = "Choose places";
            this.ChoosePlacesButton.UseVisualStyleBackColor = true;
            this.ChoosePlacesButton.Click += new System.EventHandler(this.ChoosePlacesButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 56.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(555, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 125);
            this.label2.TabIndex = 5;
            this.label2.Text = "Screen";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CinemaSeatsPictureBox
            // 
            this.CinemaSeatsPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CinemaSeatsPictureBox.Location = new System.Drawing.Point(525, 144);
            this.CinemaSeatsPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CinemaSeatsPictureBox.Name = "CinemaSeatsPictureBox";
            this.CinemaSeatsPictureBox.Size = new System.Drawing.Size(377, 443);
            this.CinemaSeatsPictureBox.TabIndex = 6;
            this.CinemaSeatsPictureBox.TabStop = false;
            // 
            // ChooseAuditoriumComboBox
            // 
            this.ChooseAuditoriumComboBox.FormattingEnabled = true;
            this.ChooseAuditoriumComboBox.Location = new System.Drawing.Point(179, 71);
            this.ChooseAuditoriumComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChooseAuditoriumComboBox.Name = "ChooseAuditoriumComboBox";
            this.ChooseAuditoriumComboBox.Size = new System.Drawing.Size(340, 28);
            this.ChooseAuditoriumComboBox.TabIndex = 7;
            this.ChooseAuditoriumComboBox.SelectedIndexChanged += new System.EventHandler(this.ChooseAuditoriumComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Choose auditorium:";
            // 
            // RowCountTextBox
            // 
            this.RowCountTextBox.Location = new System.Drawing.Point(117, 134);
            this.RowCountTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RowCountTextBox.Name = "RowCountTextBox";
            this.RowCountTextBox.ReadOnly = true;
            this.RowCountTextBox.Size = new System.Drawing.Size(60, 27);
            this.RowCountTextBox.TabIndex = 9;
            // 
            // RowSeatsCountTextBox
            // 
            this.RowSeatsCountTextBox.Location = new System.Drawing.Point(346, 134);
            this.RowSeatsCountTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RowSeatsCountTextBox.Name = "RowSeatsCountTextBox";
            this.RowSeatsCountTextBox.ReadOnly = true;
            this.RowSeatsCountTextBox.Size = new System.Drawing.Size(63, 27);
            this.RowSeatsCountTextBox.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(470, 389);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(49, 27);
            this.textBox3.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(371, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Free seats:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(152, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ticket count:";
            // 
            // PriceComboBox
            // 
            this.PriceComboBox.FormattingEnabled = true;
            this.PriceComboBox.Location = new System.Drawing.Point(69, 169);
            this.PriceComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PriceComboBox.Name = "PriceComboBox";
            this.PriceComboBox.Size = new System.Drawing.Size(63, 28);
            this.PriceComboBox.TabIndex = 15;
            // 
            // TicketCountComboBox
            // 
            this.TicketCountComboBox.FormattingEnabled = true;
            this.TicketCountComboBox.Location = new System.Drawing.Point(276, 169);
            this.TicketCountComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TicketCountComboBox.Name = "TicketCountComboBox";
            this.TicketCountComboBox.Size = new System.Drawing.Size(83, 28);
            this.TicketCountComboBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "Auditorium Id:";
            // 
            // auditoriumIdBox
            // 
            this.auditoriumIdBox.Location = new System.Drawing.Point(152, 100);
            this.auditoriumIdBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.auditoriumIdBox.Name = "auditoriumIdBox";
            this.auditoriumIdBox.ReadOnly = true;
            this.auditoriumIdBox.Size = new System.Drawing.Size(367, 27);
            this.auditoriumIdBox.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(50, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 22);
            this.label9.TabIndex = 19;
            this.label9.Text = "Rows:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(183, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 22);
            this.label10.TabIndex = 20;
            this.label10.Text = "Rows seats count:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(14, 450);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 22);
            this.label8.TabIndex = 21;
            this.label8.Text = "Client name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(14, 484);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 22);
            this.label11.TabIndex = 22;
            this.label11.Text = "Surname:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(14, 516);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 22);
            this.label12.TabIndex = 23;
            this.label12.Text = "Age:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(121, 516);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 22);
            this.label13.TabIndex = 24;
            this.label13.Text = "Email:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(133, 445);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(232, 27);
            this.NameTextBox.TabIndex = 25;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(108, 478);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(257, 27);
            this.SurnameTextBox.TabIndex = 26;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(60, 509);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(58, 27);
            this.AgeTextBox.TabIndex = 27;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(183, 511);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(182, 27);
            this.EmailTextBox.TabIndex = 28;
            // 
            // AdNewClient
            // 
            this.AdNewClient.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdNewClient.Location = new System.Drawing.Point(385, 441);
            this.AdNewClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AdNewClient.Name = "AdNewClient";
            this.AdNewClient.Size = new System.Drawing.Size(109, 97);
            this.AdNewClient.TabIndex = 29;
            this.AdNewClient.Text = "Add new client";
            this.AdNewClient.UseVisualStyleBackColor = true;
            this.AdNewClient.Click += new System.EventHandler(this.AddNewClient_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(3, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 22);
            this.label14.TabIndex = 30;
            this.label14.Text = "Movie Id:";
            // 
            // MovieIdTextBox
            // 
            this.MovieIdTextBox.Location = new System.Drawing.Point(138, 39);
            this.MovieIdTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MovieIdTextBox.Name = "MovieIdTextBox";
            this.MovieIdTextBox.ReadOnly = true;
            this.MovieIdTextBox.Size = new System.Drawing.Size(381, 27);
            this.MovieIdTextBox.TabIndex = 31;
            // 
            // SellTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.MovieIdTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.AdNewClient);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.auditoriumIdBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TicketCountComboBox);
            this.Controls.Add(this.PriceComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.RowSeatsCountTextBox);
            this.Controls.Add(this.RowCountTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChooseAuditoriumComboBox);
            this.Controls.Add(this.CinemaSeatsPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChoosePlacesButton);
            this.Controls.Add(this.MovieInformationTextBox);
            this.Controls.Add(this.ChooseMovieNextButton);
            this.Controls.Add(this.ChooseMovieComboBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SellTicketForm";
            this.Text = "SellTicketForm";
            ((System.ComponentModel.ISupportInitialize)(this.CinemaSeatsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ChooseMovieComboBox;
        private System.Windows.Forms.Button ChooseMovieNextButton;
        private System.Windows.Forms.TextBox MovieInformationTextBox;
        private System.Windows.Forms.Button ChoosePlacesButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox CinemaSeatsPictureBox;
        private System.Windows.Forms.ComboBox ChooseAuditoriumComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RowCountTextBox;
        private System.Windows.Forms.TextBox RowSeatsCountTextBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox PriceComboBox;
        private System.Windows.Forms.ComboBox TicketCountComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox auditoriumIdBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Button AdNewClient;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox MovieIdTextBox;
    }
}