namespace StringEquality
{
    partial class frmStringEquality
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
            this.txtString1 = new System.Windows.Forms.TextBox();
            this.txtString2 = new System.Windows.Forms.TextBox();
            this.lblString1 = new System.Windows.Forms.Label();
            this.lblString2 = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtString1
            // 
            this.txtString1.Location = new System.Drawing.Point(258, 107);
            this.txtString1.Name = "txtString1";
            this.txtString1.Size = new System.Drawing.Size(100, 20);
            this.txtString1.TabIndex = 0;
            // 
            // txtString2
            // 
            this.txtString2.Location = new System.Drawing.Point(258, 166);
            this.txtString2.Name = "txtString2";
            this.txtString2.Size = new System.Drawing.Size(100, 20);
            this.txtString2.TabIndex = 1;
            // 
            // lblString1
            // 
            this.lblString1.AutoSize = true;
            this.lblString1.Location = new System.Drawing.Point(52, 114);
            this.lblString1.Name = "lblString1";
            this.lblString1.Size = new System.Drawing.Size(83, 13);
            this.lblString1.TabIndex = 2;
            this.lblString1.Text = "String Number 1";
            // 
            // lblString2
            // 
            this.lblString2.AutoSize = true;
            this.lblString2.Location = new System.Drawing.Point(52, 169);
            this.lblString2.Name = "lblString2";
            this.lblString2.Size = new System.Drawing.Size(83, 13);
            this.lblString2.TabIndex = 3;
            this.lblString2.Text = "String Number 2";
            // 
            // btnCompare
            // 
            this.btnCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompare.Location = new System.Drawing.Point(438, 128);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(136, 35);
            this.btnCompare.TabIndex = 4;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 60);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter to texts to see if they are equal\r\n\r\n(case doesn\'t matter)";
            // 
            // frmStringEquality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 209);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.lblString2);
            this.Controls.Add(this.lblString1);
            this.Controls.Add(this.txtString2);
            this.Controls.Add(this.txtString1);
            this.Name = "frmStringEquality";
            this.Text = "String Equality             by:  Joelle Ishimwe   ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtString1;
        private System.Windows.Forms.TextBox txtString2;
        private System.Windows.Forms.Label lblString1;
        private System.Windows.Forms.Label lblString2;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label label1;
    }
}

