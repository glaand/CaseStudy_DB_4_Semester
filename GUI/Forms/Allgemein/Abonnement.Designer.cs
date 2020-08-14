namespace GUI.Forms.Allgemein
{
    partial class Abonnement
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
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.subscriptions_id = new System.Windows.Forms.ColumnHeader();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.duration = new System.Windows.Forms.ColumnHeader();
            this.rental_properties_quantity = new System.Windows.Forms.ColumnHeader();
            this.price = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(29, 29);
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
            this.label2.Location = new System.Drawing.Point(44, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Freie Marktgruppe";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "Abonnemente erstellen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.subscriptions_id,
            this.name,
            this.duration,
            this.rental_properties_quantity,
            this.price});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1, 151);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(797, 297);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // subscriptions_id
            // 
            this.subscriptions_id.Text = "AboNr.";
            // 
            // name
            // 
            this.name.Text = "Abo";
            // 
            // duration
            // 
            this.duration.Text = "Dauer";
            // 
            // rental_properties_quantity
            // 
            this.rental_properties_quantity.Text = "Anzahl Standorte";
            // 
            // price
            // 
            this.price.Text = "Preis";
            // 
            // Abonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Abonnement";
            this.Text = "Abonnement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader subscriptions_id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader duration;
        private System.Windows.Forms.ColumnHeader rental_properties_quantity;
        private System.Windows.Forms.ColumnHeader price;
    }
}