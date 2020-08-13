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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.areaList = new System.Windows.Forms.ListView();
            this.area_id = new System.Windows.Forms.ColumnHeader();
            this.latitude = new System.Windows.Forms.ColumnHeader();
            this.longitude = new System.Windows.Forms.ColumnHeader();
            this.address = new System.Windows.Forms.ColumnHeader();
            this.additional_info = new System.Windows.Forms.ColumnHeader();
            this.square = new System.Windows.Forms.ColumnHeader();
            this.employee = new System.Windows.Forms.ColumnHeader();
            this.landlord = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mieter hinzufügen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(514, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Areal hinzufügen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(674, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "Mietobjekt erstellen";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(355, 77);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 31);
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
            this.label1.Location = new System.Drawing.Point(42, 29);
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
            this.label2.Location = new System.Drawing.Point(42, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Freie Marktgruppe";
            // 
            // areaList
            // 
            this.areaList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.area_id,
            this.latitude,
            this.longitude,
            this.address,
            this.additional_info,
            this.square,
            this.employee,
            this.landlord});
            this.areaList.HideSelection = false;
            this.areaList.Location = new System.Drawing.Point(12, 130);
            this.areaList.Name = "areaList";
            this.areaList.Size = new System.Drawing.Size(848, 425);
            this.areaList.TabIndex = 4;
            this.areaList.UseCompatibleStateImageBehavior = false;
            this.areaList.View = System.Windows.Forms.View.Details;
            // 
            // area_id
            // 
            this.area_id.Name = "area_id";
            this.area_id.Text = "area_id";
            // 
            // latitude
            // 
            this.latitude.Name = "latitude";
            this.latitude.Text = "latitude";
            // 
            // longitude
            // 
            this.longitude.Name = "longitude";
            this.longitude.Text = "longitude";
            // 
            // address
            // 
            this.address.Name = "address";
            this.address.Text = "address";
            // 
            // additional_info
            // 
            this.additional_info.Name = "additional_info";
            this.additional_info.Text = "additional_info";
            // 
            // square
            // 
            this.square.Name = "square";
            this.square.Text = "square";
            // 
            // employee
            // 
            this.employee.Name = "employee";
            this.employee.Text = "employee";
            // 
            // landlord
            // 
            this.landlord.Name = "landlord";
            this.landlord.Text = "landlord";
            // 
            // Areaverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(872, 567);
            this.Controls.Add(this.areaList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Areaverwaltung";
            this.Text = "Arealverwaltung";
            this.Load += new System.EventHandler(this.Arealeverwaltung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView areaList;
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
    }
}