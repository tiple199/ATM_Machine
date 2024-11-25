namespace TestProject
{
    partial class Login
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
            this.lg = new System.Windows.Forms.Button();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lg
            // 
            this.lg.BackColor = System.Drawing.Color.RoyalBlue;
            this.lg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lg.ForeColor = System.Drawing.Color.White;
            this.lg.Location = new System.Drawing.Point(915, 596);
            this.lg.Margin = new System.Windows.Forms.Padding(6);
            this.lg.Name = "lg";
            this.lg.Size = new System.Drawing.Size(278, 112);
            this.lg.TabIndex = 12;
            this.lg.Text = "Enter";
            this.lg.UseVisualStyleBackColor = false;
            this.lg.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtPin
            // 
            this.txtPin.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPin.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPin.Location = new System.Drawing.Point(126, 684);
            this.txtPin.Margin = new System.Windows.Forms.Padding(6);
            this.txtPin.Name = "txtPin";
            this.txtPin.PasswordChar = '*';
            this.txtPin.Size = new System.Drawing.Size(646, 71);
            this.txtPin.TabIndex = 11;
            this.txtPin.Text = "xxxx";
            this.txtPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPin_MouseClick);
            this.txtPin.TextChanged += new System.EventHandler(this.txtPin_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(128, 614);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 48);
            this.label3.TabIndex = 14;
            this.label3.Text = "Enter Pin:";
            // 
            // txtCardNo
            // 
            this.txtCardNo.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCardNo.Location = new System.Drawing.Point(113, 496);
            this.txtCardNo.Margin = new System.Windows.Forms.Padding(6);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(646, 71);
            this.txtCardNo.TabIndex = 10;
            this.txtCardNo.Text = "xxxx-xxxx-xxxx-xxxx";
            this.txtCardNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCardNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCardNo_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(118, 388);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 48);
            this.label2.TabIndex = 13;
            this.label2.Text = "Enter Card Number:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 1051);
            this.Controls.Add(this.lg);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCardNo);
            this.Controls.Add(this.label2);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lg;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Label label2;
    }
}