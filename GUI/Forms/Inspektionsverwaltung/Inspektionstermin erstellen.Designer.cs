namespace GUI.Forms.Inspektionsverwaltung
{
    partial class Inspektionstermin_erstellen
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inspectorsCombobox = new System.Windows.Forms.ComboBox();
            this.sellerCombobox = new System.Windows.Forms.ComboBox();
            this.roundCheckCombobox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(22, 23);
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
            this.label2.Location = new System.Drawing.Point(22, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Freie Marktgruppe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Inspektor: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Anbieter:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prüfungsrunde:";
            // 
            // inspectorsCombobox
            // 
            this.inspectorsCombobox.FormattingEnabled = true;
            this.inspectorsCombobox.Location = new System.Drawing.Point(124, 129);
            this.inspectorsCombobox.Name = "inspectorsCombobox";
            this.inspectorsCombobox.Size = new System.Drawing.Size(409, 23);
            this.inspectorsCombobox.TabIndex = 5;
            // 
            // sellerCombobox
            // 
            this.sellerCombobox.FormattingEnabled = true;
            this.sellerCombobox.Location = new System.Drawing.Point(124, 161);
            this.sellerCombobox.Name = "sellerCombobox";
            this.sellerCombobox.Size = new System.Drawing.Size(409, 23);
            this.sellerCombobox.TabIndex = 5;
            // 
            // roundCheckCombobox
            // 
            this.roundCheckCombobox.FormattingEnabled = true;
            this.roundCheckCombobox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.roundCheckCombobox.Location = new System.Drawing.Point(124, 195);
            this.roundCheckCombobox.Name = "roundCheckCombobox";
            this.roundCheckCombobox.Size = new System.Drawing.Size(409, 23);
            this.roundCheckCombobox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 89);
            this.button1.TabIndex = 6;
            this.button1.Text = "Erstellen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inspektionstermin_erstellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(741, 250);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.roundCheckCombobox);
            this.Controls.Add(this.sellerCombobox);
            this.Controls.Add(this.inspectorsCombobox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Inspektionstermin_erstellen";
            this.Text = "Inspektionstermin erstellen";
            this.Load += new System.EventHandler(this.Inspektionstermin_erstellen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox inspectorsCombobox;
        private System.Windows.Forms.ComboBox sellerCombobox;
        private System.Windows.Forms.ComboBox roundCheckCombobox;
        private System.Windows.Forms.Button button1;
    }
}