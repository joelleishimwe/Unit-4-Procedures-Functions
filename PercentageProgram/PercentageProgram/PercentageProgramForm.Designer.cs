namespace PercentageProgram
{
    partial class frmPercentageProgram
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
            this.lblMarkLevel = new System.Windows.Forms.Label();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.btnPercentage = new System.Windows.Forms.Button();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMarkLevel
            // 
            this.lblMarkLevel.AutoSize = true;
            this.lblMarkLevel.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarkLevel.Location = new System.Drawing.Point(107, 112);
            this.lblMarkLevel.Name = "lblMarkLevel";
            this.lblMarkLevel.Size = new System.Drawing.Size(236, 36);
            this.lblMarkLevel.TabIndex = 0;
            this.lblMarkLevel.Text = "Enter a rubric level";
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(492, 126);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(100, 20);
            this.txtLevel.TabIndex = 1;
            // 
            // btnPercentage
            // 
            this.btnPercentage.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercentage.Location = new System.Drawing.Point(252, 188);
            this.btnPercentage.Name = "btnPercentage";
            this.btnPercentage.Size = new System.Drawing.Size(251, 43);
            this.btnPercentage.TabIndex = 2;
            this.btnPercentage.Text = "Get Percentage";
            this.btnPercentage.UseVisualStyleBackColor = true;
            this.btnPercentage.Click += new System.EventHandler(this.btnPercentage_Click);
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.Location = new System.Drawing.Point(221, 311);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(0, 16);
            this.lblPercentage.TabIndex = 3;
            // 
            // frmPercentageProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.btnPercentage);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.lblMarkLevel);
            this.Name = "frmPercentageProgram";
            this.Text = "Percentage Program                     by:  Joelle Ishimwe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarkLevel;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Button btnPercentage;
        private System.Windows.Forms.Label lblPercentage;
    }
}

