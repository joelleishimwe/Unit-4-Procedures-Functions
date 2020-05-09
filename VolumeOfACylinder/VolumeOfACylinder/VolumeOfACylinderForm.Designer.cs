namespace VolumeOfACylinder
{
    partial class frmVolumeOfACylinder
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
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadius.Location = new System.Drawing.Point(31, 54);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(400, 25);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "Choose a number to represent the radius (cm)";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(31, 147);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(363, 26);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "Choose a number to represent the height (cm)";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(552, 59);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 20);
            this.txtRadius.TabIndex = 2;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(493, 153);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(642, 199);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(114, 39);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmVolumeOfACylinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 271);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblRadius);
            this.Name = "frmVolumeOfACylinder";
            this.Text = "Volume of a cylinder               by:  Joelle Ishimwe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button btnCalculate;
    }
}

