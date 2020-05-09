namespace CalculateHypotenuse
{
    partial class frmCalculateHypotenuse
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
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(27, 72);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(535, 24);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Choose a number to represent the a leg of the triangle";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(27, 164);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(536, 24);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "Choose a number to represent the b leg of the triangle";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalculateHypotenuse.Properties.Resources.triangle;
            this.pictureBox1.Location = new System.Drawing.Point(74, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(493, 281);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(123, 39);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(642, 75);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 4;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(631, 167);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 5;
            // 
            // frmCalculateHypotenuse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Name = "frmCalculateHypotenuse";
            this.Text = "Calculate the Hypotenuse                  by:  Joelle Ishimwe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
    }
}

