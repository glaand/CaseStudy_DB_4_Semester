namespace GUI.Forms.Buchhaltung
{
    partial class Buchhaltung
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.invoice_id = new System.Windows.Forms.ColumnHeader();
            this.person_id = new System.Windows.Forms.ColumnHeader();
            this.vat = new System.Windows.Forms.ColumnHeader();
            this.paid_on = new System.Windows.Forms.ColumnHeader();
            this.created_on = new System.Windows.Forms.ColumnHeader();
            this.listView1 = new System.Windows.Forms.ListView();
            this.oder_id = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.total_price = new System.Windows.Forms.ColumnHeader();
            this.ps_id = new System.Windows.Forms.ColumnHeader();
            this.hours = new System.Windows.Forms.ColumnHeader();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "Rechnungen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(579, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 68);
            this.button2.TabIndex = 1;
            this.button2.Text = "Lohnzahlungen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(23, 29);
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
            this.label2.Location = new System.Drawing.Point(36, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Freie Marktgruppe";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "columnHeader1";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            this.columnHeader2.Text = "columnHeader2";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Name = "columnHeader3";
            this.columnHeader3.Text = "columnHeader3";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Name = "columnHeader4";
            this.columnHeader4.Text = "columnHeader4";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Name = "columnHeader5";
            this.columnHeader5.Text = "columnHeader5";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Name = "columnHeader6";
            this.columnHeader6.Text = "columnHeader6";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Name = "columnHeader7";
            this.columnHeader7.Text = "columnHeader7";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Name = "columnHeader8";
            this.columnHeader8.Text = "columnHeader8";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(36, 141);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(733, 287);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(725, 259);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rechnungen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.invoice_id,
            this.person_id,
            this.vat,
            this.paid_on,
            this.created_on});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(-7, 3);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(732, 256);
            this.listView2.TabIndex = 6;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(725, 259);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lohnübersicht";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // invoice_id
            // 
            this.invoice_id.Text = "Rechnungsnummer";
            // 
            // person_id
            // 
            this.person_id.Text = "person_id";
            // 
            // vat
            // 
            this.vat.Text = "MwSt.";
            // 
            // paid_on
            // 
            this.paid_on.Text = "Zahlungsdatum";
            // 
            // created_on
            // 
            this.created_on.Text = "Erstellt";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.oder_id,
            this.columnHeader9,
            this.total_price,
            this.ps_id,
            this.hours});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(4, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(720, 258);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // oder_id
            // 
            this.oder_id.Text = "Rechnungsnummer";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Erstellt";
            // 
            // total_price
            // 
            this.total_price.Text = "Summe";
            // 
            // ps_id
            // 
            this.ps_id.Text = "Personennummer";
            // 
            // hours
            // 
            this.hours.Text = "Arbeitsstunden";
            // 
            // Buchhaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 633);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Buchhaltung";
            this.Text = "Buchhaltung";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader invoice_id;
        private System.Windows.Forms.ColumnHeader person_id;
        private System.Windows.Forms.ColumnHeader vat;
        private System.Windows.Forms.ColumnHeader paid_on;
        private System.Windows.Forms.ColumnHeader created_on;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader oder_id;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader total_price;
        private System.Windows.Forms.ColumnHeader ps_id;
        private System.Windows.Forms.ColumnHeader hours;
    }
}