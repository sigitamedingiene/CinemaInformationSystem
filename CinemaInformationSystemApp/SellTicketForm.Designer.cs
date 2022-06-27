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
            ((System.ComponentModel.ISupportInitialize)(this.CinemaSeatsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose movie:";
            // 
            // ChooseMovieComboBox
            // 
            this.ChooseMovieComboBox.FormattingEnabled = true;
            this.ChooseMovieComboBox.Location = new System.Drawing.Point(27, 31);
            this.ChooseMovieComboBox.Name = "ChooseMovieComboBox";
            this.ChooseMovieComboBox.Size = new System.Drawing.Size(326, 23);
            this.ChooseMovieComboBox.TabIndex = 1;
            // 
            // ChooseMovieNextButton
            // 
            this.ChooseMovieNextButton.Location = new System.Drawing.Point(27, 69);
            this.ChooseMovieNextButton.Name = "ChooseMovieNextButton";
            this.ChooseMovieNextButton.Size = new System.Drawing.Size(208, 23);
            this.ChooseMovieNextButton.TabIndex = 2;
            this.ChooseMovieNextButton.Text = "Next";
            this.ChooseMovieNextButton.UseVisualStyleBackColor = true;
            // 
            // MovieInformationTextBox
            // 
            this.MovieInformationTextBox.Location = new System.Drawing.Point(27, 111);
            this.MovieInformationTextBox.Multiline = true;
            this.MovieInformationTextBox.Name = "MovieInformationTextBox";
            this.MovieInformationTextBox.ReadOnly = true;
            this.MovieInformationTextBox.Size = new System.Drawing.Size(326, 103);
            this.MovieInformationTextBox.TabIndex = 3;
            // 
            // ChoosePlacesButton
            // 
            this.ChoosePlacesButton.Location = new System.Drawing.Point(27, 235);
            this.ChoosePlacesButton.Name = "ChoosePlacesButton";
            this.ChoosePlacesButton.Size = new System.Drawing.Size(208, 23);
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
            this.label2.Location = new System.Drawing.Point(459, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 100);
            this.label2.TabIndex = 5;
            this.label2.Text = "Screen";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CinemaSeatsPictureBox
            // 
            this.CinemaSeatsPictureBox.Location = new System.Drawing.Point(459, 114);
            this.CinemaSeatsPictureBox.Name = "CinemaSeatsPictureBox";
            this.CinemaSeatsPictureBox.Size = new System.Drawing.Size(263, 217);
            this.CinemaSeatsPictureBox.TabIndex = 6;
            this.CinemaSeatsPictureBox.TabStop = false;
            // 
            // SellTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CinemaSeatsPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChoosePlacesButton);
            this.Controls.Add(this.MovieInformationTextBox);
            this.Controls.Add(this.ChooseMovieNextButton);
            this.Controls.Add(this.ChooseMovieComboBox);
            this.Controls.Add(this.label1);
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
    }
}