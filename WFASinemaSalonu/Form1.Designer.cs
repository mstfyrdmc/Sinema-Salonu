namespace WFASinemaSalonu
{
    partial class Form1
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
            this.btnYap = new System.Windows.Forms.Button();
            this.flpSalon = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnYap
            // 
            this.btnYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYap.Location = new System.Drawing.Point(36, 18);
            this.btnYap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnYap.Name = "btnYap";
            this.btnYap.Size = new System.Drawing.Size(1556, 92);
            this.btnYap.TabIndex = 0;
            this.btnYap.Text = "Sinema Otomasyonu";
            this.btnYap.UseVisualStyleBackColor = true;
            this.btnYap.Click += new System.EventHandler(this.btnYap_Click);
            // 
            // flpSalon
            // 
            this.flpSalon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpSalon.Location = new System.Drawing.Point(36, 151);
            this.flpSalon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flpSalon.Name = "flpSalon";
            this.flpSalon.Size = new System.Drawing.Size(1799, 922);
            this.flpSalon.TabIndex = 1;
            this.flpSalon.Paint += new System.Windows.Forms.PaintEventHandler(this.flpSalon_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 972);
            this.Controls.Add(this.flpSalon);
            this.Controls.Add(this.btnYap);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYap;
        private System.Windows.Forms.FlowLayoutPanel flpSalon;
    }
}

