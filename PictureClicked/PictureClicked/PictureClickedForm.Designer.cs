namespace PictureClicked
{
    partial class frmPictureClicked
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
            this.picCard = new System.Windows.Forms.PictureBox();
            this.lblClick = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).BeginInit();
            this.SuspendLayout();
            // 
            // picCard
            // 
            this.picCard.Image = global::PictureClicked.Properties.Resources.QS;
            this.picCard.Location = new System.Drawing.Point(75, 29);
            this.picCard.Name = "picCard";
            this.picCard.Size = new System.Drawing.Size(186, 227);
            this.picCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCard.TabIndex = 0;
            this.picCard.TabStop = false;
            this.picCard.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblClick
            // 
            this.lblClick.AutoSize = true;
            this.lblClick.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClick.Location = new System.Drawing.Point(362, 127);
            this.lblClick.Name = "lblClick";
            this.lblClick.Size = new System.Drawing.Size(216, 26);
            this.lblClick.TabIndex = 1;
            this.lblClick.Text = "Click on the picture";
            // 
            // frmPictureClicked
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 282);
            this.Controls.Add(this.lblClick);
            this.Controls.Add(this.picCard);
            this.Name = "frmPictureClicked";
            this.Text = "Picture Clicked                      by:    Joelle Ishimwe ";
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCard;
        private System.Windows.Forms.Label lblClick;
    }
}

