namespace CinemaInformationSystemApp
{
    partial class MainForm
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
            this.SellTicketButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MovieNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MovieTypeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MovieCompanyTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DatePickerBox = new System.Windows.Forms.DateTimePicker();
            this.TimePickerBox = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.GenerateReportButton = new System.Windows.Forms.Button();
            this.AuditoriumNumberTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AuditoriumAdressComboBox = new System.Windows.Forms.ComboBox();
            this.AuditoriumIdTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SellTicketButton
            // 
            this.SellTicketButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SellTicketButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SellTicketButton.Location = new System.Drawing.Point(14, 37);
            this.SellTicketButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SellTicketButton.Name = "SellTicketButton";
            this.SellTicketButton.Size = new System.Drawing.Size(114, 228);
            this.SellTicketButton.TabIndex = 0;
            this.SellTicketButton.Text = "SELL TICKET";
            this.SellTicketButton.UseVisualStyleBackColor = false;
            this.SellTicketButton.Click += new System.EventHandler(this.SellTicketButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(161, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movie name.";
            // 
            // MovieNameTextBox
            // 
            this.MovieNameTextBox.Location = new System.Drawing.Point(161, 37);
            this.MovieNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MovieNameTextBox.Name = "MovieNameTextBox";
            this.MovieNameTextBox.Size = new System.Drawing.Size(299, 27);
            this.MovieNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(161, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Movie type. (Ex. adventure, animation...).";
            // 
            // MovieTypeTextBox
            // 
            this.MovieTypeTextBox.Location = new System.Drawing.Point(161, 96);
            this.MovieTypeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MovieTypeTextBox.Name = "MovieTypeTextBox";
            this.MovieTypeTextBox.Size = new System.Drawing.Size(299, 27);
            this.MovieTypeTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(161, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Company created the movie. (Ex. Walt Disney...).";
            // 
            // MovieCompanyTextBox
            // 
            this.MovieCompanyTextBox.Location = new System.Drawing.Point(161, 155);
            this.MovieCompanyTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MovieCompanyTextBox.Name = "MovieCompanyTextBox";
            this.MovieCompanyTextBox.Size = new System.Drawing.Size(299, 27);
            this.MovieCompanyTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(161, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Movie showing time.";
            // 
            // DatePickerBox
            // 
            this.DatePickerBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerBox.Location = new System.Drawing.Point(161, 213);
            this.DatePickerBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DatePickerBox.Name = "DatePickerBox";
            this.DatePickerBox.Size = new System.Drawing.Size(134, 27);
            this.DatePickerBox.TabIndex = 8;
            this.DatePickerBox.Value = new System.DateTime(2022, 6, 26, 0, 0, 0, 0);
            // 
            // TimePickerBox
            // 
            this.TimePickerBox.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePickerBox.Location = new System.Drawing.Point(303, 213);
            this.TimePickerBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TimePickerBox.Name = "TimePickerBox";
            this.TimePickerBox.Size = new System.Drawing.Size(95, 27);
            this.TimePickerBox.TabIndex = 9;
            this.TimePickerBox.Value = new System.DateTime(2022, 6, 26, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(159, 399);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add new movie";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(569, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Choose report type.";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(569, 96);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 24);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Clients report";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(569, 143);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(117, 24);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Movie report";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(569, 189);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(203, 24);
            this.checkBox3.TabIndex = 16;
            this.checkBox3.Text = "Cinema auditorium report";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // GenerateReportButton
            // 
            this.GenerateReportButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GenerateReportButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GenerateReportButton.Location = new System.Drawing.Point(569, 252);
            this.GenerateReportButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GenerateReportButton.Name = "GenerateReportButton";
            this.GenerateReportButton.Size = new System.Drawing.Size(301, 40);
            this.GenerateReportButton.TabIndex = 17;
            this.GenerateReportButton.Text = "Generate report";
            this.GenerateReportButton.UseVisualStyleBackColor = false;
            // 
            // AuditoriumNumberTextBox
            // 
            this.AuditoriumNumberTextBox.Location = new System.Drawing.Point(166, 365);
            this.AuditoriumNumberTextBox.Name = "AuditoriumNumberTextBox";
            this.AuditoriumNumberTextBox.Size = new System.Drawing.Size(159, 27);
            this.AuditoriumNumberTextBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(166, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Auditorium number.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(161, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Auditorium adress.";
            // 
            // AuditoriumAdressComboBox
            // 
            this.AuditoriumAdressComboBox.FormattingEnabled = true;
            this.AuditoriumAdressComboBox.Location = new System.Drawing.Point(161, 274);
            this.AuditoriumAdressComboBox.Name = "AuditoriumAdressComboBox";
            this.AuditoriumAdressComboBox.Size = new System.Drawing.Size(295, 28);
            this.AuditoriumAdressComboBox.TabIndex = 21;
            // 
            // AuditoriumIdTextBox
            // 
            this.AuditoriumIdTextBox.Location = new System.Drawing.Point(159, 309);
            this.AuditoriumIdTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AuditoriumIdTextBox.Name = "AuditoriumIdTextBox";
            this.AuditoriumIdTextBox.ReadOnly = true;
            this.AuditoriumIdTextBox.Size = new System.Drawing.Size(299, 27);
            this.AuditoriumIdTextBox.TabIndex = 22;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.AuditoriumIdTextBox);
            this.Controls.Add(this.AuditoriumAdressComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AuditoriumNumberTextBox);
            this.Controls.Add(this.GenerateReportButton);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TimePickerBox);
            this.Controls.Add(this.DatePickerBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MovieCompanyTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MovieTypeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MovieNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SellTicketButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SellTicketButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MovieNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MovieTypeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MovieCompanyTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DatePickerBox;
        private System.Windows.Forms.DateTimePicker TimePickerBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button GenerateReportButton;
        private System.Windows.Forms.TextBox AuditoriumNumberTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox AuditoriumAdressComboBox;
        private System.Windows.Forms.TextBox AuditoriumIdTextBox;
    }
}
