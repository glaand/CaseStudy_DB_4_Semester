namespace GUI
{
    partial class WelcomeForm
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
            this.accountingButton = new System.Windows.Forms.Button();
            this.areaManagementButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.managerLabel = new System.Windows.Forms.Label();
            this.phoneNrLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eventManagementButton = new System.Windows.Forms.Button();
            this.inspectionManagementButton = new System.Windows.Forms.Button();
            this.personManagementButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountingButton
            // 
            this.accountingButton.BackColor = System.Drawing.Color.Transparent;
            this.accountingButton.Location = new System.Drawing.Point(25, 209);
            this.accountingButton.Name = "accountingButton";
            this.accountingButton.Size = new System.Drawing.Size(179, 64);
            this.accountingButton.TabIndex = 2;
            this.accountingButton.Text = "Buchhaltung";
            this.accountingButton.UseVisualStyleBackColor = false;
            this.accountingButton.Click += new System.EventHandler(this.accountingButton_Click);
            // 
            // areaManagementButton
            // 
            this.areaManagementButton.Location = new System.Drawing.Point(25, 139);
            this.areaManagementButton.Name = "areaManagementButton";
            this.areaManagementButton.Size = new System.Drawing.Size(179, 64);
            this.areaManagementButton.TabIndex = 0;
            this.areaManagementButton.Text = "Arealverwaltung";
            this.areaManagementButton.UseVisualStyleBackColor = true;
            this.areaManagementButton.Click += new System.EventHandler(this.areaManagementButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(25, 35);
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
            this.label2.Location = new System.Drawing.Point(25, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Freie Marktgruppe";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.managerLabel);
            this.groupBox1.Controls.Add(this.phoneNrLabel);
            this.groupBox1.Controls.Add(this.emailLabel);
            this.groupBox1.Controls.Add(this.lastnameLabel);
            this.groupBox1.Controls.Add(this.firstnameLabel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(466, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 204);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ihr Profil";
            // 
            // managerLabel
            // 
            this.managerLabel.AutoSize = true;
            this.managerLabel.Location = new System.Drawing.Point(135, 165);
            this.managerLabel.Name = "managerLabel";
            this.managerLabel.Size = new System.Drawing.Size(55, 15);
            this.managerLabel.TabIndex = 5;
            this.managerLabel.Text = "-- Leer --";
            // 
            // phoneNrLabel
            // 
            this.phoneNrLabel.AutoSize = true;
            this.phoneNrLabel.Location = new System.Drawing.Point(135, 130);
            this.phoneNrLabel.Name = "phoneNrLabel";
            this.phoneNrLabel.Size = new System.Drawing.Size(55, 15);
            this.phoneNrLabel.TabIndex = 4;
            this.phoneNrLabel.Text = "-- Leer --";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(135, 95);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(55, 15);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "-- Leer --";
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Location = new System.Drawing.Point(135, 63);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(55, 15);
            this.lastnameLabel.TabIndex = 2;
            this.lastnameLabel.Text = "-- Leer --";
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Location = new System.Drawing.Point(135, 33);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(55, 15);
            this.firstnameLabel.TabIndex = 1;
            this.firstnameLabel.Text = "-- Leer --";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(38, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Vorgesetzter:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(28, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Handynummer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(77, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "E-Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(52, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nachname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(61, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Vorname:";
            // 
            // eventManagementButton
            // 
            this.eventManagementButton.Location = new System.Drawing.Point(210, 139);
            this.eventManagementButton.Name = "eventManagementButton";
            this.eventManagementButton.Size = new System.Drawing.Size(179, 64);
            this.eventManagementButton.TabIndex = 1;
            this.eventManagementButton.Text = "Eventverwaltung";
            this.eventManagementButton.UseVisualStyleBackColor = true;
            // 
            // inspectionManagementButton
            // 
            this.inspectionManagementButton.Location = new System.Drawing.Point(210, 209);
            this.inspectionManagementButton.Name = "inspectionManagementButton";
            this.inspectionManagementButton.Size = new System.Drawing.Size(179, 64);
            this.inspectionManagementButton.TabIndex = 3;
            this.inspectionManagementButton.Text = "Inspektionsverwaltung";
            this.inspectionManagementButton.UseVisualStyleBackColor = true;
            // 
            // personManagementButton
            // 
            this.personManagementButton.Location = new System.Drawing.Point(25, 279);
            this.personManagementButton.Name = "personManagementButton";
            this.personManagementButton.Size = new System.Drawing.Size(179, 64);
            this.personManagementButton.TabIndex = 4;
            this.personManagementButton.Text = "Personalverwaltung";
            this.personManagementButton.UseVisualStyleBackColor = true;
            this.personManagementButton.Click += new System.EventHandler(this.personManagementButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(645, 35);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(179, 64);
            this.logoutButton.TabIndex = 6;
            this.logoutButton.Text = "Ausloggen";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Adressenliste";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "Abonnemente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(888, 369);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.personManagementButton);
            this.Controls.Add(this.inspectionManagementButton);
            this.Controls.Add(this.eventManagementButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.areaManagementButton);
            this.Controls.Add(this.accountingButton);
            this.Name = "WelcomeForm";
            this.Text = "Willkomen im Marktverwaltungssystem";
            this.Load += new System.EventHandler(this.WelcomeForms_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button accountingButton;
        private System.Windows.Forms.Button areaManagementButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label managerLabel;
        private System.Windows.Forms.Label phoneNrLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button eventManagementButton;
        private System.Windows.Forms.Button inspectionManagementButton;
        private System.Windows.Forms.Button personManagementButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}