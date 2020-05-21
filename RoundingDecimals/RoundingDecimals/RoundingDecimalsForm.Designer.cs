namespace RoundingDecimals
{
    partial class frmRoundingDecimals
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
            this.lblRounding = new System.Windows.Forms.Label();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.btnRound = new System.Windows.Forms.Button();
            this.lblDecimal = new System.Windows.Forms.Label();
            this.nudNumRound = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumRound)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRounding
            // 
            this.lblRounding.AutoSize = true;
            this.lblRounding.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRounding.Location = new System.Drawing.Point(12, 109);
            this.lblRounding.Name = "lblRounding";
            this.lblRounding.Size = new System.Drawing.Size(467, 23);
            this.lblRounding.TabIndex = 1;
            this.lblRounding.Text = "How many decimal places are you rounding to?";
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(458, 57);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(100, 20);
            this.txtDecimal.TabIndex = 3;
            // 
            // btnRound
            // 
            this.btnRound.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRound.Location = new System.Drawing.Point(474, 183);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(96, 34);
            this.btnRound.TabIndex = 4;
            this.btnRound.Text = "Round";
            this.btnRound.UseVisualStyleBackColor = true;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // lblDecimal
            // 
            this.lblDecimal.AutoSize = true;
            this.lblDecimal.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecimal.Location = new System.Drawing.Point(38, 52);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(365, 23);
            this.lblDecimal.TabIndex = 5;
            this.lblDecimal.Text = "What decimal do you want to round?";
            // 
            // nudNumRound
            // 
            this.nudNumRound.Location = new System.Drawing.Point(504, 112);
            this.nudNumRound.Name = "nudNumRound";
            this.nudNumRound.Size = new System.Drawing.Size(120, 20);
            this.nudNumRound.TabIndex = 6;
            // 
            // frmRoundingDecimals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 243);
            this.Controls.Add(this.nudNumRound);
            this.Controls.Add(this.lblDecimal);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.lblRounding);
            this.Name = "frmRoundingDecimals";
            this.Text = "Rounding Decimals           by:  Joelle Ishimwe";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumRound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRounding;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.Button btnRound;
        private System.Windows.Forms.Label lblDecimal;
        private System.Windows.Forms.NumericUpDown nudNumRound;
    }
}

