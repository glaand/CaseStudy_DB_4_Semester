namespace GUI
{
    partial class Personalverwaltung
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.personListview = new System.Windows.Forms.ListView();
            this.person_id = new System.Windows.Forms.ColumnHeader();
            this.firstname = new System.Windows.Forms.ColumnHeader();
            this.lastname = new System.Windows.Forms.ColumnHeader();
            this.email = new System.Windows.Forms.ColumnHeader();
            this.phone_nr = new System.Windows.Forms.ColumnHeader();
            this.manager = new System.Windows.Forms.ColumnHeader();
            this.address = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.personMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuPersonEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPersonDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.insertPerson = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.personMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 22);
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
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Freie Marktgruppe";
            // 
            // personListview
            // 
            this.personListview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.personListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.person_id,
            this.firstname,
            this.lastname,
            this.email,
            this.phone_nr,
            this.manager,
            this.address});
            this.personListview.HideSelection = false;
            this.personListview.Location = new System.Drawing.Point(12, 161);
            this.personListview.MultiSelect = false;
            this.personListview.Name = "personListview";
            this.personListview.Size = new System.Drawing.Size(946, 398);
            this.personListview.TabIndex = 4;
            this.personListview.UseCompatibleStateImageBehavior = false;
            this.personListview.View = System.Windows.Forms.View.Details;
            this.personListview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.personListview_MouseClick);
            // 
            // person_id
            // 
            this.person_id.Name = "person_id";
            this.person_id.Text = "person_id";
            this.person_id.Width = 70;
            // 
            // firstname
            // 
            this.firstname.Name = "firstname";
            this.firstname.Text = "Vorname";
            this.firstname.Width = 150;
            // 
            // lastname
            // 
            this.lastname.Name = "lastname";
            this.lastname.Text = "Nachname";
            this.lastname.Width = 150;
            // 
            // email
            // 
            this.email.Name = "email";
            this.email.Text = "E-Mail";
            this.email.Width = 200;
            // 
            // phone_nr
            // 
            this.phone_nr.Name = "phone_nr";
            this.phone_nr.Text = "Telefonnummer";
            this.phone_nr.Width = 100;
            // 
            // manager
            // 
            this.manager.Name = "manager";
            this.manager.Text = "Vorgesetzter";
            this.manager.Width = 150;
            // 
            // address
            // 
            this.address.Text = "Adresse";
            // 
            // personMenu
            // 
            this.personMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.personMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPersonEdit,
            this.menuPersonDelete,
            this.toolStripMenuItem1});
            this.personMenu.Name = "personMenu";
            this.personMenu.Size = new System.Drawing.Size(329, 70);
            this.personMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.personMenu_ItemClicked);
            // 
            // menuPersonEdit
            // 
            this.menuPersonEdit.Name = "menuPersonEdit";
            this.menuPersonEdit.Size = new System.Drawing.Size(328, 22);
            this.menuPersonEdit.Text = "Person bearbeiten";
            // 
            // menuPersonDelete
            // 
            this.menuPersonDelete.Name = "menuPersonDelete";
            this.menuPersonDelete.Size = new System.Drawing.Size(328, 22);
            this.menuPersonDelete.Text = "Person löschen";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "bonitat";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(328, 22);
            this.toolStripMenuItem1.Text = "Anbieter für die Öko-Bonitätsprüfung anmelden";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hinweis:\r\n\r\nRechtsklick auf entsprechende person_id ermöglicht Zusatzaktionen";
            // 
            // insertPerson
            // 
            this.insertPerson.Location = new System.Drawing.Point(325, 92);
            this.insertPerson.Name = "insertPerson";
            this.insertPerson.Size = new System.Drawing.Size(153, 31);
            this.insertPerson.TabIndex = 3;
            this.insertPerson.Text = "Person eintragen";
            this.insertPerson.UseVisualStyleBackColor = true;
            this.insertPerson.Click += new System.EventHandler(this.insertPerson_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(734, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(18, 18);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(758, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Anbieter";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Location = new System.Drawing.Point(734, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(18, 18);
            this.panel2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(758, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Vermieter";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LawnGreen;
            this.panel3.Location = new System.Drawing.Point(734, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(18, 18);
            this.panel3.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(758, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Inspektor";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel4.Location = new System.Drawing.Point(734, 99);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(18, 18);
            this.panel4.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(758, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Marktbesucher";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Pink;
            this.panel5.Location = new System.Drawing.Point(734, 123);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(18, 18);
            this.panel5.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(758, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mitarbeiter";
            // 
            // Personalverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(970, 571);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.insertPerson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.personListview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Personalverwaltung";
            this.Text = "Personalverwaltung";
            this.Activated += new System.EventHandler(this.Personalverwaltung_Activated);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.personListview_MouseClick);
            this.personMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView personListview;
        private System.Windows.Forms.ColumnHeader person_id;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader firstname;
        private System.Windows.Forms.ColumnHeader longitude;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader additional_info;
        private System.Windows.Forms.ColumnHeader manager_id;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader lastname;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader phone_nr;
        private System.Windows.Forms.ColumnHeader manager;
        private System.Windows.Forms.ListView personList;
        private System.Windows.Forms.ContextMenuStrip personMenu;
        private System.Windows.Forms.ToolStripMenuItem menuPersonEdit;
        private System.Windows.Forms.ToolStripMenuItem menuPersonDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button insertPerson;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}