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
            this.AddNewMovieButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.GenerateReportButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AuditoriumAdressComboBox = new System.Windows.Forms.ComboBox();
            this.NewMovieIdTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CityNameTextBox = new System.Windows.Forms.TextBox();
            this.SearchAuditoriumAdressButton = new System.Windows.Forms.Button();
            this.AddNewAuditorium = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.AuditoriumNumberBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AuditoriumOwnerTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.AuditoriumAdressTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.AuditoriumPlaceCountTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.AuditoriumRowsCountTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.AuditoriumSeatsInRowCountTextBox = new System.Windows.Forms.TextBox();
            this.AddNewMovieIdToAuditoriumDataBaseButton = new System.Windows.Forms.Button();
            this.AllMovieListComboBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SellTicketButton
            // 
            this.SellTicketButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SellTicketButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SellTicketButton.Location = new System.Drawing.Point(12, 116);
            this.SellTicketButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SellTicketButton.Name = "SellTicketButton";
            this.SellTicketButton.Size = new System.Drawing.Size(114, 318);
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
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movie name:";
            // 
            // MovieNameTextBox
            // 
            this.MovieNameTextBox.Location = new System.Drawing.Point(161, 37);
            this.MovieNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MovieNameTextBox.Name = "MovieNameTextBox";
            this.MovieNameTextBox.Size = new System.Drawing.Size(364, 27);
            this.MovieNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(161, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Movie type. (Ex. adventure, animation...):";
            // 
            // MovieTypeTextBox
            // 
            this.MovieTypeTextBox.Location = new System.Drawing.Point(161, 96);
            this.MovieTypeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MovieTypeTextBox.Name = "MovieTypeTextBox";
            this.MovieTypeTextBox.Size = new System.Drawing.Size(364, 27);
            this.MovieTypeTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(161, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Company created the movie. (Ex. Walt Disney...):";
            // 
            // MovieCompanyTextBox
            // 
            this.MovieCompanyTextBox.Location = new System.Drawing.Point(161, 155);
            this.MovieCompanyTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MovieCompanyTextBox.Name = "MovieCompanyTextBox";
            this.MovieCompanyTextBox.Size = new System.Drawing.Size(364, 27);
            this.MovieCompanyTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(161, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Movie showing time:";
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
            // AddNewMovieButton
            // 
            this.AddNewMovieButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddNewMovieButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddNewMovieButton.Location = new System.Drawing.Point(161, 248);
            this.AddNewMovieButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddNewMovieButton.Name = "AddNewMovieButton";
            this.AddNewMovieButton.Size = new System.Drawing.Size(364, 40);
            this.AddNewMovieButton.TabIndex = 10;
            this.AddNewMovieButton.Text = "Add new movie";
            this.AddNewMovieButton.UseVisualStyleBackColor = false;
            this.AddNewMovieButton.Click += new System.EventHandler(this.AddNewMovieButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(955, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Choose report type.";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(955, 450);
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
            this.checkBox2.Location = new System.Drawing.Point(955, 482);
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
            this.checkBox3.Location = new System.Drawing.Point(955, 514);
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
            this.GenerateReportButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GenerateReportButton.Location = new System.Drawing.Point(955, 547);
            this.GenerateReportButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GenerateReportButton.Name = "GenerateReportButton";
            this.GenerateReportButton.Size = new System.Drawing.Size(231, 40);
            this.GenerateReportButton.TabIndex = 17;
            this.GenerateReportButton.Text = "Generate report";
            this.GenerateReportButton.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1108, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Movie ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(738, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Auditorium adress:";
            // 
            // AuditoriumAdressComboBox
            // 
            this.AuditoriumAdressComboBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.AuditoriumAdressComboBox.FormattingEnabled = true;
            this.AuditoriumAdressComboBox.Location = new System.Drawing.Point(738, 223);
            this.AuditoriumAdressComboBox.Name = "AuditoriumAdressComboBox";
            this.AuditoriumAdressComboBox.Size = new System.Drawing.Size(448, 28);
            this.AuditoriumAdressComboBox.TabIndex = 21;
            this.AuditoriumAdressComboBox.Text = "Choose adress...";
            // 
            // NewMovieIdTextBox
            // 
            this.NewMovieIdTextBox.Location = new System.Drawing.Point(738, 71);
            this.NewMovieIdTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewMovieIdTextBox.Name = "NewMovieIdTextBox";
            this.NewMovieIdTextBox.ReadOnly = true;
            this.NewMovieIdTextBox.Size = new System.Drawing.Size(364, 27);
            this.NewMovieIdTextBox.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(738, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "Whrite city name (Ex. Klaipeda):";
            // 
            // CityNameTextBox
            // 
            this.CityNameTextBox.Location = new System.Drawing.Point(738, 155);
            this.CityNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CityNameTextBox.Name = "CityNameTextBox";
            this.CityNameTextBox.Size = new System.Drawing.Size(185, 27);
            this.CityNameTextBox.TabIndex = 24;
            // 
            // SearchAuditoriumAdressButton
            // 
            this.SearchAuditoriumAdressButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SearchAuditoriumAdressButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchAuditoriumAdressButton.Location = new System.Drawing.Point(955, 154);
            this.SearchAuditoriumAdressButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchAuditoriumAdressButton.Name = "SearchAuditoriumAdressButton";
            this.SearchAuditoriumAdressButton.Size = new System.Drawing.Size(231, 28);
            this.SearchAuditoriumAdressButton.TabIndex = 25;
            this.SearchAuditoriumAdressButton.Text = "Search auditorium adress";
            this.SearchAuditoriumAdressButton.UseVisualStyleBackColor = false;
            this.SearchAuditoriumAdressButton.Click += new System.EventHandler(this.SearchAuditoriumAdressButton_Click);
            // 
            // AddNewAuditorium
            // 
            this.AddNewAuditorium.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddNewAuditorium.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddNewAuditorium.Location = new System.Drawing.Point(161, 547);
            this.AddNewAuditorium.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddNewAuditorium.Name = "AddNewAuditorium";
            this.AddNewAuditorium.Size = new System.Drawing.Size(364, 40);
            this.AddNewAuditorium.TabIndex = 26;
            this.AddNewAuditorium.Text = "Add new auditorium";
            this.AddNewAuditorium.UseVisualStyleBackColor = false;
            this.AddNewAuditorium.Click += new System.EventHandler(this.AddNewAuditorium_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(164, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 19);
            this.label9.TabIndex = 27;
            this.label9.Text = "Auditorium number:";
            // 
            // AuditoriumNumberBox
            // 
            this.AuditoriumNumberBox.Location = new System.Drawing.Point(333, 424);
            this.AuditoriumNumberBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AuditoriumNumberBox.Name = "AuditoriumNumberBox";
            this.AuditoriumNumberBox.Size = new System.Drawing.Size(55, 27);
            this.AuditoriumNumberBox.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(164, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(320, 19);
            this.label10.TabIndex = 29;
            this.label10.Text = "Auditorium owner (Ex. Forum Cinema...):";
            // 
            // AuditoriumOwnerTextBox
            // 
            this.AuditoriumOwnerTextBox.Location = new System.Drawing.Point(165, 328);
            this.AuditoriumOwnerTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AuditoriumOwnerTextBox.Name = "AuditoriumOwnerTextBox";
            this.AuditoriumOwnerTextBox.Size = new System.Drawing.Size(360, 27);
            this.AuditoriumOwnerTextBox.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(164, 371);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 19);
            this.label11.TabIndex = 31;
            this.label11.Text = "City:";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(218, 363);
            this.CityTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(307, 27);
            this.CityTextBox.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(164, 397);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 19);
            this.label12.TabIndex = 33;
            this.label12.Text = "Auditorium adress:";
            // 
            // AuditoriumAdressTextBox
            // 
            this.AuditoriumAdressTextBox.Location = new System.Drawing.Point(323, 393);
            this.AuditoriumAdressTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AuditoriumAdressTextBox.Name = "AuditoriumAdressTextBox";
            this.AuditoriumAdressTextBox.Size = new System.Drawing.Size(202, 27);
            this.AuditoriumAdressTextBox.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(161, 463);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(190, 19);
            this.label13.TabIndex = 35;
            this.label13.Text = "Auditorium place count:";
            // 
            // AuditoriumPlaceCountTextBox
            // 
            this.AuditoriumPlaceCountTextBox.Location = new System.Drawing.Point(355, 459);
            this.AuditoriumPlaceCountTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AuditoriumPlaceCountTextBox.Name = "AuditoriumPlaceCountTextBox";
            this.AuditoriumPlaceCountTextBox.Size = new System.Drawing.Size(55, 27);
            this.AuditoriumPlaceCountTextBox.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(161, 491);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(188, 19);
            this.label14.TabIndex = 37;
            this.label14.Text = "Auditorium rows count:";
            // 
            // AuditoriumRowsCountTextBox
            // 
            this.AuditoriumRowsCountTextBox.Location = new System.Drawing.Point(355, 491);
            this.AuditoriumRowsCountTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AuditoriumRowsCountTextBox.Name = "AuditoriumRowsCountTextBox";
            this.AuditoriumRowsCountTextBox.Size = new System.Drawing.Size(55, 27);
            this.AuditoriumRowsCountTextBox.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(160, 520);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(270, 19);
            this.label15.TabIndex = 39;
            this.label15.Text = "Auditorium seats in one row count:";
            // 
            // AuditoriumSeatsInRowCountTextBox
            // 
            this.AuditoriumSeatsInRowCountTextBox.Location = new System.Drawing.Point(436, 512);
            this.AuditoriumSeatsInRowCountTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AuditoriumSeatsInRowCountTextBox.Name = "AuditoriumSeatsInRowCountTextBox";
            this.AuditoriumSeatsInRowCountTextBox.Size = new System.Drawing.Size(55, 27);
            this.AuditoriumSeatsInRowCountTextBox.TabIndex = 40;
            // 
            // AddNewMovieIdToAuditoriumDataBaseButton
            // 
            this.AddNewMovieIdToAuditoriumDataBaseButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddNewMovieIdToAuditoriumDataBaseButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddNewMovieIdToAuditoriumDataBaseButton.Location = new System.Drawing.Point(738, 258);
            this.AddNewMovieIdToAuditoriumDataBaseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddNewMovieIdToAuditoriumDataBaseButton.Name = "AddNewMovieIdToAuditoriumDataBaseButton";
            this.AddNewMovieIdToAuditoriumDataBaseButton.Size = new System.Drawing.Size(448, 40);
            this.AddNewMovieIdToAuditoriumDataBaseButton.TabIndex = 41;
            this.AddNewMovieIdToAuditoriumDataBaseButton.Text = "Add new movie to auditorium database";
            this.AddNewMovieIdToAuditoriumDataBaseButton.UseVisualStyleBackColor = false;
            this.AddNewMovieIdToAuditoriumDataBaseButton.Click += new System.EventHandler(this.AddNewMovieIdToAuditoriumDataBaseButton_Click);
            // 
            // AllMovieListComboBox
            // 
            this.AllMovieListComboBox.FormattingEnabled = true;
            this.AllMovieListComboBox.Location = new System.Drawing.Point(738, 36);
            this.AllMovieListComboBox.Name = "AllMovieListComboBox";
            this.AllMovieListComboBox.Size = new System.Drawing.Size(448, 28);
            this.AllMovieListComboBox.TabIndex = 42;
            this.AllMovieListComboBox.SelectedIndexChanged += new System.EventHandler(this.AllMovieListComboBox_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(738, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 19);
            this.label16.TabIndex = 43;
            this.label16.Text = "Movie list:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 600);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.AllMovieListComboBox);
            this.Controls.Add(this.AddNewMovieIdToAuditoriumDataBaseButton);
            this.Controls.Add(this.AuditoriumSeatsInRowCountTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.AuditoriumRowsCountTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.AuditoriumPlaceCountTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.AuditoriumAdressTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.AuditoriumOwnerTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AuditoriumNumberBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AddNewAuditorium);
            this.Controls.Add(this.SearchAuditoriumAdressButton);
            this.Controls.Add(this.CityNameTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NewMovieIdTextBox);
            this.Controls.Add(this.AuditoriumAdressComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GenerateReportButton);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddNewMovieButton);
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
        private System.Windows.Forms.Button AddNewMovieButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button GenerateReportButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox AuditoriumAdressComboBox;
        private System.Windows.Forms.TextBox NewMovieIdTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CityNameTextBox;
        private System.Windows.Forms.Button SearchAuditoriumAdressButton;
        private System.Windows.Forms.Button AddNewAuditorium;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AuditoriumNumberBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox AuditoriumOwnerTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox AuditoriumAdressTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox AuditoriumPlaceCountTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox AuditoriumRowsCountTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox AuditoriumSeatsInRowCountTextBox;
        private System.Windows.Forms.Button AddNewMovieIdToAuditoriumDataBaseButton;
        private System.Windows.Forms.ComboBox AllMovieListComboBox;
        private System.Windows.Forms.Label label16;
    }
}
