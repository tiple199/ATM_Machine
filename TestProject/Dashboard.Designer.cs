namespace TestProject
{
    partial class Dashboard
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
            this.btnMiniStatement = new System.Windows.Forms.Button();
            this.btnTransferMoney = new System.Windows.Forms.Button();
            this.btnCashWithdraw = new System.Windows.Forms.Button();
            this.btnBalanceInquiry = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMiniStatement
            // 
            this.btnMiniStatement.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMiniStatement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMiniStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiniStatement.ForeColor = System.Drawing.Color.White;
            this.btnMiniStatement.Location = new System.Drawing.Point(1360, 594);
            this.btnMiniStatement.Margin = new System.Windows.Forms.Padding(6);
            this.btnMiniStatement.Name = "btnMiniStatement";
            this.btnMiniStatement.Size = new System.Drawing.Size(279, 249);
            this.btnMiniStatement.TabIndex = 17;
            this.btnMiniStatement.Text = "Mini Statements";
            this.btnMiniStatement.UseVisualStyleBackColor = false;
            this.btnMiniStatement.Click += new System.EventHandler(this.btnMiniStatement_Click);
            // 
            // btnTransferMoney
            // 
            this.btnTransferMoney.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTransferMoney.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTransferMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferMoney.ForeColor = System.Drawing.Color.White;
            this.btnTransferMoney.Location = new System.Drawing.Point(941, 567);
            this.btnTransferMoney.Margin = new System.Windows.Forms.Padding(6);
            this.btnTransferMoney.Name = "btnTransferMoney";
            this.btnTransferMoney.Size = new System.Drawing.Size(303, 269);
            this.btnTransferMoney.TabIndex = 16;
            this.btnTransferMoney.Text = "Transfer Money";
            this.btnTransferMoney.UseVisualStyleBackColor = false;
            this.btnTransferMoney.Click += new System.EventHandler(this.btnTransferMoney_Click);
            // 
            // btnCashWithdraw
            // 
            this.btnCashWithdraw.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCashWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCashWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnCashWithdraw.Location = new System.Drawing.Point(557, 563);
            this.btnCashWithdraw.Margin = new System.Windows.Forms.Padding(6);
            this.btnCashWithdraw.Name = "btnCashWithdraw";
            this.btnCashWithdraw.Size = new System.Drawing.Size(284, 273);
            this.btnCashWithdraw.TabIndex = 15;
            this.btnCashWithdraw.Text = "Cash Withdraw";
            this.btnCashWithdraw.UseVisualStyleBackColor = false;
            this.btnCashWithdraw.Click += new System.EventHandler(this.btnCashWithdraw_Click);
            // 
            // btnBalanceInquiry
            // 
            this.btnBalanceInquiry.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBalanceInquiry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBalanceInquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalanceInquiry.ForeColor = System.Drawing.Color.White;
            this.btnBalanceInquiry.Location = new System.Drawing.Point(118, 567);
            this.btnBalanceInquiry.Margin = new System.Windows.Forms.Padding(6);
            this.btnBalanceInquiry.Name = "btnBalanceInquiry";
            this.btnBalanceInquiry.Size = new System.Drawing.Size(315, 269);
            this.btnBalanceInquiry.TabIndex = 14;
            this.btnBalanceInquiry.Text = "Balance Inquiry";
            this.btnBalanceInquiry.UseVisualStyleBackColor = false;
            this.btnBalanceInquiry.Click += new System.EventHandler(this.btnBalanceInquiry_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(217, 336);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(524, 85);
            this.label3.TabIndex = 13;
            this.label3.Text = "Select Service";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1756, 1179);
            this.Controls.Add(this.btnMiniStatement);
            this.Controls.Add(this.btnTransferMoney);
            this.Controls.Add(this.btnCashWithdraw);
            this.Controls.Add(this.btnBalanceInquiry);
            this.Controls.Add(this.label3);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMiniStatement;
        private System.Windows.Forms.Button btnTransferMoney;
        private System.Windows.Forms.Button btnCashWithdraw;
        private System.Windows.Forms.Button btnBalanceInquiry;
        private System.Windows.Forms.Label label3;
    }
}