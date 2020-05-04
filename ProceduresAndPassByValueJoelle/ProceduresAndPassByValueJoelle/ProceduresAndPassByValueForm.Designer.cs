namespace ProceduresAndPassByValueJoelle
{
    partial class frmProceduresAndPassByValue
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
            this.lblTempByUser = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtCelcius = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTempByUser
            // 
            this.lblTempByUser.AutoSize = true;
            this.lblTempByUser.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempByUser.Location = new System.Drawing.Point(22, 69);
            this.lblTempByUser.Name = "lblTempByUser";
            this.lblTempByUser.Size = new System.Drawing.Size(679, 80);
            this.lblTempByUser.TabIndex = 0;
            this.lblTempByUser.Text = "Enter a temperature (Celsius) to have \r\nit be displayed in Fahrenheit ";
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(532, 215);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(97, 46);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtCelcius
            // 
            this.txtCelcius.Location = new System.Drawing.Point(199, 234);
            this.txtCelcius.Name = "txtCelcius";
            this.txtCelcius.Size = new System.Drawing.Size(100, 20);
            this.txtCelcius.TabIndex = 3;
            // 
            // frmProceduresAndPassByValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCelcius);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblTempByUser);
            this.Name = "frmProceduresAndPassByValue";
            this.Text = "Procedures & Pass by Value            by:  Joelle Ishimwe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTempByUser;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtCelcius;
    }
}

