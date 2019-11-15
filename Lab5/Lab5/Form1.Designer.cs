namespace Lab5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CityBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StadiumBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.QuarterbackListBox = new System.Windows.Forms.ListBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Citylabel = new System.Windows.Forms.Label();
            this.Stadiumlabel = new System.Windows.Forms.Label();
            this.Quarterbacklabel = new System.Windows.Forms.Label();
            this.Resultlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(698, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Match the NFL City to the Stadium to the Quarterback ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose a City:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(338, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Match all three and win!";
            // 
            // CityBox
            // 
            this.CityBox.FormattingEnabled = true;
            this.CityBox.Items.AddRange(new object[] {
            "Chicago",
            "Minneapolis",
            "Denver",
            "Detroit",
            "Dallas"});
            this.CityBox.Location = new System.Drawing.Point(28, 180);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(208, 24);
            this.CityBox.TabIndex = 3;
            this.CityBox.SelectedIndexChanged += new System.EventHandler(this.CityBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(292, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Choose a Stadium in that City:";
            // 
            // StadiumBox
            // 
            this.StadiumBox.FormattingEnabled = true;
            this.StadiumBox.Items.AddRange(new object[] {
            "Soldier Feild",
            "U.S. Bank Stadium",
            "Empower Field",
            "Ford Feild",
            "AT&T Stadium"});
            this.StadiumBox.Location = new System.Drawing.Point(307, 180);
            this.StadiumBox.Name = "StadiumBox";
            this.StadiumBox.Size = new System.Drawing.Size(208, 24);
            this.StadiumBox.TabIndex = 5;
            this.StadiumBox.SelectedIndexChanged += new System.EventHandler(this.StadiumBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(581, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Who is their Quarterback?:";
            // 
            // QuarterbackListBox
            // 
            this.QuarterbackListBox.FormattingEnabled = true;
            this.QuarterbackListBox.ItemHeight = 16;
            this.QuarterbackListBox.Items.AddRange(new object[] {
            "Mitch Trubisky",
            "Kirk Cousins",
            "Joe Flacco",
            "Matthew Stafford",
            "Dak Prescott"});
            this.QuarterbackListBox.Location = new System.Drawing.Point(606, 180);
            this.QuarterbackListBox.Name = "QuarterbackListBox";
            this.QuarterbackListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.QuarterbackListBox.Size = new System.Drawing.Size(143, 100);
            this.QuarterbackListBox.TabIndex = 7;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(606, 303);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(141, 50);
            this.SubmitButton.TabIndex = 8;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Your Results:";
            // 
            // Citylabel
            // 
            this.Citylabel.AutoSize = true;
            this.Citylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Citylabel.Location = new System.Drawing.Point(26, 303);
            this.Citylabel.Name = "Citylabel";
            this.Citylabel.Size = new System.Drawing.Size(43, 20);
            this.Citylabel.TabIndex = 10;
            this.Citylabel.Text = "City:";
            // 
            // Stadiumlabel
            // 
            this.Stadiumlabel.AutoSize = true;
            this.Stadiumlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stadiumlabel.Location = new System.Drawing.Point(24, 347);
            this.Stadiumlabel.Name = "Stadiumlabel";
            this.Stadiumlabel.Size = new System.Drawing.Size(75, 20);
            this.Stadiumlabel.TabIndex = 11;
            this.Stadiumlabel.Text = "Stadium:";
            // 
            // Quarterbacklabel
            // 
            this.Quarterbacklabel.AutoSize = true;
            this.Quarterbacklabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quarterbacklabel.Location = new System.Drawing.Point(26, 394);
            this.Quarterbacklabel.Name = "Quarterbacklabel";
            this.Quarterbacklabel.Size = new System.Drawing.Size(106, 20);
            this.Quarterbacklabel.TabIndex = 12;
            this.Quarterbacklabel.Text = "Quarterback:";
            // 
            // Resultlabel
            // 
            this.Resultlabel.AutoSize = true;
            this.Resultlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultlabel.Location = new System.Drawing.Point(26, 446);
            this.Resultlabel.Name = "Resultlabel";
            this.Resultlabel.Size = new System.Drawing.Size(62, 20);
            this.Resultlabel.TabIndex = 13;
            this.Resultlabel.Text = "Result:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 553);
            this.Controls.Add(this.Resultlabel);
            this.Controls.Add(this.Quarterbacklabel);
            this.Controls.Add(this.Stadiumlabel);
            this.Controls.Add(this.Citylabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.QuarterbackListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StadiumBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Quarterback Match";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CityBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox StadiumBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox QuarterbackListBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Citylabel;
        private System.Windows.Forms.Label Stadiumlabel;
        private System.Windows.Forms.Label Quarterbacklabel;
        private System.Windows.Forms.Label Resultlabel;
    }
}

