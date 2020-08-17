namespace GUI
{
    partial class Areaverwaltung
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
            this.button2 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.areaListview = new System.Windows.Forms.ListView();
            this.area_id = new System.Windows.Forms.ColumnHeader();
            this.latitude = new System.Windows.Forms.ColumnHeader();
            this.longitude = new System.Windows.Forms.ColumnHeader();
            this.address = new System.Windows.Forms.ColumnHeader();
            this.additional_info = new System.Windows.Forms.ColumnHeader();
            this.square = new System.Windows.Forms.ColumnHeader();
            this.employee = new System.Windows.Forms.ColumnHeader();
            this.landlord = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(355, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Areal hinzufügen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Freie Marktgruppe";
            // 
            // areaListview
            // 
            this.areaListview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.areaListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.area_id,
            this.latitude,
            this.longitude,
            this.address,
            this.additional_info,
            this.square,
            this.employee,
            this.landlord,
            this.columnHeader9,
            this.columnHeader10});
            this.areaListview.HideSelection = false;
            this.areaListview.Location = new System.Drawing.Point(12, 159);
            this.areaListview.Name = "areaListview";
            this.areaListview.Size = new System.Drawing.Size(1253, 396);
            this.areaListview.TabIndex = 4;
            this.areaListview.UseCompatibleStateImageBehavior = false;
            this.areaListview.View = System.Windows.Forms.View.Details;
            this.areaListview.SelectedIndexChanged += new System.EventHandler(this.areaListview_SelectedIndexChanged);
            this.areaListview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.areaListview_MouseClick);
            // 
            // area_id
            // 
            this.area_id.Name = "area_id";
            this.area_id.Text = "AreaID";
            // 
            // latitude
            // 
            this.latitude.Name = "latitude";
            this.latitude.Text = "Breitengrad";
            // 
            // longitude
            // 
            this.longitude.Name = "longitude";
            this.longitude.Text = "Längengrad";
            // 
            // address
            // 
            this.address.Name = "address";
            this.address.Text = "Adresse";
            // 
            // additional_info
            // 
            this.additional_info.Name = "additional_info";
            this.additional_info.Text = "Wegbeschreibung";
            // 
            // square
            // 
            this.square.Name = "square";
            this.square.Text = "Gesamtfläche (m2)";
            // 
            // employee
            // 
            this.employee.Name = "employee";
            this.employee.Text = "Standortverwalter";
            // 
            // landlord
            // 
            this.landlord.Name = "landlord";
            this.landlord.Text = "Vermieter";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Anzahl Mietobjekte";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Gesamtfläche eines Mietobjekts (m2)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marktverwaltungssystem";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(192, 48);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.toolStripMenuItem1.Text = "Mietobjekte verwalten";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(191, 22);
            this.toolStripMenuItem2.Text = "Areal löschen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hinweis:\r\n\r\nRechtsklick auf entsprechende person_id ermöglicht Zusatzaktionen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(349, 45);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hinweis:\r\n\r\nRechtsklick auf entsprechende AreaID ermöglicht Zusatzaktionen";
            // 
            // Areaverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1277, 567);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.areaListview);
            this.Name = "Areaverwaltung";
            this.Text = "Arealverwaltung";
            this.Activated += new System.EventHandler(this.Areaverwaltung_Activated);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView areaListview;
        private System.Windows.Forms.ColumnHeader area_id;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader latitude;
        private System.Windows.Forms.ColumnHeader longitude;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader additional_info;
        private System.Windows.Forms.ColumnHeader square;
        private System.Windows.Forms.ColumnHeader employee;
        private System.Windows.Forms.ColumnHeader landlord;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}