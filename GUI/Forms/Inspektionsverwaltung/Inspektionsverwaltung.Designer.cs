namespace GUI.Forms.Inspektionsverwaltung
{
    partial class Inspektionsverwaltung
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
            this.quality_check_id = new System.Windows.Forms.ColumnHeader();
            this.inspector_id = new System.Windows.Forms.ColumnHeader();
            this.seller_id = new System.Windows.Forms.ColumnHeader();
            this.round_check = new System.Windows.Forms.ColumnHeader();
            this.approved = new System.Windows.Forms.ColumnHeader();
            this.approved_on = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(25, 36);
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
            this.label2.Location = new System.Drawing.Point(45, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Freie Marktgruppe";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 71);
            this.button1.TabIndex = 4;
            this.button1.Text = "Inspektion erstellen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.quality_check_id,
            this.inspector_id,
            this.seller_id,
            this.round_check,
            this.approved,
            this.approved_on});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1, 144);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(798, 306);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // quality_check_id
            // 
            this.quality_check_id.Text = "Inspektionsnummer";
            // 
            // inspector_id
            // 
            this.inspector_id.Text = "Inspektor";
            // 
            // seller_id
            // 
            this.seller_id.Text = "Anbieter";
            // 
            // round_check
            // 
            this.round_check.Text = "Prüfung";
            // 
            // approved
            // 
            this.approved.Text = "absolviert";
            // 
            // approved_on
            // 
            this.approved_on.Text = "Absolvierungsdatum";
            // 
            // Inspektionsverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Inspektionsverwaltung";
            this.Text = "Inspektionsverwaltung";
            this.Load += new System.EventHandler(this.Inspektionsverwaltung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader quality_check_id;
        private System.Windows.Forms.ColumnHeader inspector_id;
        private System.Windows.Forms.ColumnHeader seller_id;
        private System.Windows.Forms.ColumnHeader round_check;
        private System.Windows.Forms.ColumnHeader approved;
        private System.Windows.Forms.ColumnHeader approved_on;
    }
}