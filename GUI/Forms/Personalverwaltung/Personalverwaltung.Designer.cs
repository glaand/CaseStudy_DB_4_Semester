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
            this.button4 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
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
            this.menuAddLandlord = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeleteLandlord = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddSeller = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeleteSeller = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddInspector = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeleteInspector = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddVisitor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeleteVisitor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeleteEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.insertPerson = new System.Windows.Forms.Button();
            this.personMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(659, 179);
            this.button4.Margin = new System.Windows.Forms.Padding(6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(284, 66);
            this.button4.TabIndex = 3;
            this.button4.Text = "Zurück";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(78, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marktverwaltungssystem";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(78, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(482, 54);
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
            this.personListview.Location = new System.Drawing.Point(22, 277);
            this.personListview.Margin = new System.Windows.Forms.Padding(6);
            this.personListview.MultiSelect = false;
            this.personListview.Name = "personListview";
            this.personListview.Size = new System.Drawing.Size(1753, 855);
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
            this.menuAddLandlord,
            this.menuDeleteLandlord,
            this.menuAddSeller,
            this.menuDeleteSeller,
            this.menuAddInspector,
            this.menuDeleteInspector,
            this.menuAddVisitor,
            this.menuDeleteVisitor,
            this.menuAddEmployee,
            this.menuDeleteEmployee});
            this.personMenu.Name = "personMenu";
            this.personMenu.Size = new System.Drawing.Size(415, 460);
            this.personMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.personMenu_ItemClicked);
            // 
            // menuPersonEdit
            // 
            this.menuPersonEdit.Name = "menuPersonEdit";
            this.menuPersonEdit.Size = new System.Drawing.Size(414, 38);
            this.menuPersonEdit.Text = "Person bearbeiten";
            // 
            // menuPersonDelete
            // 
            this.menuPersonDelete.Name = "menuPersonDelete";
            this.menuPersonDelete.Size = new System.Drawing.Size(414, 38);
            this.menuPersonDelete.Text = "Person löschen";
            // 
            // menuAddLandlord
            // 
            this.menuAddLandlord.Name = "menuAddLandlord";
            this.menuAddLandlord.Size = new System.Drawing.Size(414, 38);
            this.menuAddLandlord.Text = "Als Vermieter hinzufügen";
            // 
            // menuDeleteLandlord
            // 
            this.menuDeleteLandlord.Name = "menuDeleteLandlord";
            this.menuDeleteLandlord.Size = new System.Drawing.Size(414, 38);
            this.menuDeleteLandlord.Text = "Als Vermieter entfernen";
            // 
            // menuAddSeller
            // 
            this.menuAddSeller.Name = "menuAddSeller";
            this.menuAddSeller.Size = new System.Drawing.Size(414, 38);
            this.menuAddSeller.Text = "Als Anbieter hinzufügen";
            // 
            // menuDeleteSeller
            // 
            this.menuDeleteSeller.Name = "menuDeleteSeller";
            this.menuDeleteSeller.Size = new System.Drawing.Size(414, 38);
            this.menuDeleteSeller.Text = "Als Anbieter entfernen";
            // 
            // menuAddInspector
            // 
            this.menuAddInspector.Name = "menuAddInspector";
            this.menuAddInspector.Size = new System.Drawing.Size(414, 38);
            this.menuAddInspector.Text = "Als Inspektor hinzufügen";
            // 
            // menuDeleteInspector
            // 
            this.menuDeleteInspector.Name = "menuDeleteInspector";
            this.menuDeleteInspector.Size = new System.Drawing.Size(414, 38);
            this.menuDeleteInspector.Text = "Als Inspektor entfernen";
            // 
            // menuAddVisitor
            // 
            this.menuAddVisitor.Name = "menuAddVisitor";
            this.menuAddVisitor.Size = new System.Drawing.Size(414, 38);
            this.menuAddVisitor.Text = "Als Marktbesucher hinzufügen";
            // 
            // menuDeleteVisitor
            // 
            this.menuDeleteVisitor.Name = "menuDeleteVisitor";
            this.menuDeleteVisitor.Size = new System.Drawing.Size(414, 38);
            this.menuDeleteVisitor.Text = "Als Marktbesucher entfernen";
            // 
            // menuAddEmployee
            // 
            this.menuAddEmployee.Name = "menuAddEmployee";
            this.menuAddEmployee.Size = new System.Drawing.Size(414, 38);
            this.menuAddEmployee.Text = "Als Mitarbeiter hinzufügen";
            // 
            // menuDeleteEmployee
            // 
            this.menuDeleteEmployee.Name = "menuDeleteEmployee";
            this.menuDeleteEmployee.Size = new System.Drawing.Size(414, 38);
            this.menuDeleteEmployee.Text = "Als Mitarbeiter entfernen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(659, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(738, 96);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hinweis:\r\n\r\nRechtsklick auf entsprechende person_id ermöglicht Zusatzaktionen";
            // 
            // insertPerson
            // 
            this.insertPerson.Location = new System.Drawing.Point(955, 179);
            this.insertPerson.Margin = new System.Windows.Forms.Padding(6);
            this.insertPerson.Name = "insertPerson";
            this.insertPerson.Size = new System.Drawing.Size(284, 66);
            this.insertPerson.TabIndex = 3;
            this.insertPerson.Text = "Person eintragen";
            this.insertPerson.UseVisualStyleBackColor = true;
            this.insertPerson.Click += new System.EventHandler(this.insertPerson_Click);
            // 
            // Personalverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1801, 1163);
            this.Controls.Add(this.insertPerson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.personListview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Personalverwaltung";
            this.Text = "Personalverwaltung";
            this.Activated += new System.EventHandler(this.Personalverwaltung_Activated);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.personListview_MouseClick);
            this.personMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
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
        private System.Windows.Forms.ToolStripMenuItem menuAddLandlord;
        private System.Windows.Forms.ToolStripMenuItem menuDeleteLandlord;
        private System.Windows.Forms.ToolStripMenuItem menuAddSeller;
        private System.Windows.Forms.ToolStripMenuItem menuDeleteSeller;
        private System.Windows.Forms.ToolStripMenuItem menuAddInspector;
        private System.Windows.Forms.ToolStripMenuItem menuDeleteInspector;
        private System.Windows.Forms.ToolStripMenuItem menuAddVisitor;
        private System.Windows.Forms.ToolStripMenuItem menuDeleteVisitor;
        private System.Windows.Forms.ToolStripMenuItem menuAddEmployee;
        private System.Windows.Forms.ToolStripMenuItem menuDeleteEmployee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button insertPerson;
    }
}