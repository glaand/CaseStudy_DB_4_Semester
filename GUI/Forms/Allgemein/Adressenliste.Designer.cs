namespace GUI.Forms.Allgemein
{
    partial class Adressenliste
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
            this.addressListview = new System.Windows.Forms.ListView();
            this.address_id = new System.Windows.Forms.ColumnHeader();
            this.place_id = new System.Windows.Forms.ColumnHeader();
            this.district_id = new System.Windows.Forms.ColumnHeader();
            this.address = new System.Windows.Forms.ColumnHeader();
            this.place = new System.Windows.Forms.ColumnHeader();
            this.district = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(25, 23);
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
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Freie Marktgruppe";
            // 
            // addressListview
            // 
            this.addressListview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.address_id,
            this.place_id,
            this.district_id,
            this.address,
            this.place,
            this.district});
            this.addressListview.HideSelection = false;
            this.addressListview.Location = new System.Drawing.Point(25, 109);
            this.addressListview.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.addressListview.Name = "addressListview";
            this.addressListview.Size = new System.Drawing.Size(785, 367);
            this.addressListview.TabIndex = 4;
            this.addressListview.UseCompatibleStateImageBehavior = false;
            this.addressListview.View = System.Windows.Forms.View.Details;
            // 
            // address_id
            // 
            this.address_id.Text = "address_id";
            // 
            // place_id
            // 
            this.place_id.Text = "PLZ / place_id";
            // 
            // district_id
            // 
            this.district_id.Text = "district_id";
            // 
            // address
            // 
            this.address.Text = "Adresse";
            // 
            // place
            // 
            this.place.Text = "Bezirk";
            // 
            // district
            // 
            this.district.Text = "Kanton";
            // 
            // Adressenliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(833, 495);
            this.Controls.Add(this.addressListview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Adressenliste";
            this.Text = "Adressenliste";
            this.Activated += new System.EventHandler(this.Adressenliste_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView addressListview;
        private System.Windows.Forms.ColumnHeader address_id;
        private System.Windows.Forms.ColumnHeader place_id;
        private System.Windows.Forms.ColumnHeader district_id;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader place;
        private System.Windows.Forms.ColumnHeader district;
    }
}