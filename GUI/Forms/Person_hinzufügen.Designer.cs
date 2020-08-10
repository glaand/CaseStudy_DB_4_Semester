namespace GUI
{
    partial class Person_hinzufügen
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
            this.firstnameTextbox = new System.Windows.Forms.TextBox();
            this.lastnameTextbox = new System.Windows.Forms.TextBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.phoneNrTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.personType = new System.Windows.Forms.ComboBox();
            this.managerCombobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marktverwaltungssystem";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Freie Marktgruppe";
            // 
            // firstnameTextbox
            // 
            this.firstnameTextbox.Location = new System.Drawing.Point(50, 146);
            this.firstnameTextbox.Name = "firstnameTextbox";
            this.firstnameTextbox.PlaceholderText = "Vorname";
            this.firstnameTextbox.Size = new System.Drawing.Size(156, 23);
            this.firstnameTextbox.TabIndex = 4;
            // 
            // lastnameTextbox
            // 
            this.lastnameTextbox.Location = new System.Drawing.Point(50, 184);
            this.lastnameTextbox.Name = "lastnameTextbox";
            this.lastnameTextbox.PlaceholderText = "Nachname";
            this.lastnameTextbox.Size = new System.Drawing.Size(156, 23);
            this.lastnameTextbox.TabIndex = 5;
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(50, 222);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.PlaceholderText = "E-Mail";
            this.emailTextbox.Size = new System.Drawing.Size(156, 23);
            this.emailTextbox.TabIndex = 6;
            // 
            // phoneNrTextbox
            // 
            this.phoneNrTextbox.Location = new System.Drawing.Point(50, 262);
            this.phoneNrTextbox.Name = "phoneNrTextbox";
            this.phoneNrTextbox.PlaceholderText = "Telefon";
            this.phoneNrTextbox.Size = new System.Drawing.Size(156, 23);
            this.phoneNrTextbox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Person hinzufügen";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Zurück";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(131, 479);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 10;
            this.createButton.Text = "Bestätigen";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // personType
            // 
            this.personType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.personType.FormattingEnabled = true;
            this.personType.Items.AddRange(new object[] {
            "Vermieter",
            "Anbieter",
            "Qualitätsinspektion",
            "Marktbesucher",
            "Mitarbeiter"});
            this.personType.Location = new System.Drawing.Point(149, 334);
            this.personType.Name = "personType";
            this.personType.Size = new System.Drawing.Size(156, 23);
            this.personType.TabIndex = 4;
            // 
            // managerCombobox
            // 
            this.managerCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.managerCombobox.FormattingEnabled = true;
            this.managerCombobox.Items.AddRange(new object[] {
            "Vermieter",
            "Anbieter",
            "Qualitätsinspektion",
            "Marktbesucher",
            "Mitarbeiter"});
            this.managerCombobox.Location = new System.Drawing.Point(149, 305);
            this.managerCombobox.Name = "managerCombobox";
            this.managerCombobox.Size = new System.Drawing.Size(156, 23);
            this.managerCombobox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Vorgesetzter:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Personentyp:";
            // 
            // Person_hinzufügen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.managerCombobox);
            this.Controls.Add(this.personType);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phoneNrTextbox);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.lastnameTextbox);
            this.Controls.Add(this.firstnameTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Person_hinzufügen";
            this.Text = "Person hinzufügen";
            this.Load += new System.EventHandler(this.Person_hinzufügen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstnameTextbox;
        private System.Windows.Forms.TextBox lastnameTextbox;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.TextBox phoneNrTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.ComboBox personType;
        private System.Windows.Forms.ComboBox managerCombobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}