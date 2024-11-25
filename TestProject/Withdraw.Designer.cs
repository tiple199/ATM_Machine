namespace TestProject
{
    partial class Withdraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Withdraw));
            this.pbReturnCard = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn1000000 = new System.Windows.Forms.Button();
            this.btn500000 = new System.Windows.Forms.Button();
            this.btn200000 = new System.Windows.Forms.Button();
            this.btn100000 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturnCard)).BeginInit();
            this.SuspendLayout();
            // 
            // pbReturnCard
            // 
            this.pbReturnCard.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pbReturnCard.Image = ((System.Drawing.Image)(resources.GetObject("pbReturnCard.Image")));
            this.pbReturnCard.Location = new System.Drawing.Point(1158, 771);
            this.pbReturnCard.Margin = new System.Windows.Forms.Padding(6);
            this.pbReturnCard.Name = "pbReturnCard";
            this.pbReturnCard.Size = new System.Drawing.Size(140, 135);
            this.pbReturnCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReturnCard.TabIndex = 44;
            this.pbReturnCard.TabStop = false;
            this.pbReturnCard.Click += new System.EventHandler(this.pbReturnCard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1297, 793);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 85);
            this.label1.TabIndex = 43;
            this.label1.Text = "Return Card";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(15, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(198, 112);
            this.btnBack.TabIndex = 42;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.Location = new System.Drawing.Point(408, 725);
            this.btnWithdraw.Margin = new System.Windows.Forms.Padding(6);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(738, 112);
            this.btnWithdraw.TabIndex = 41;
            this.btnWithdraw.Text = "Rút tiền";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAmount.Location = new System.Drawing.Point(408, 628);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(6);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(734, 71);
            this.txtAmount.TabIndex = 40;
            this.txtAmount.Text = "0000.00";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(463, 516);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(683, 85);
            this.label3.TabIndex = 39;
            this.label3.Text = "Nhập tiền muốn rút";
            // 
            // btn1000000
            // 
            this.btn1000000.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn1000000.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1000000.ForeColor = System.Drawing.Color.White;
            this.btn1000000.Location = new System.Drawing.Point(900, 380);
            this.btn1000000.Margin = new System.Windows.Forms.Padding(6);
            this.btn1000000.Name = "btn1000000";
            this.btn1000000.Size = new System.Drawing.Size(368, 112);
            this.btn1000000.TabIndex = 38;
            this.btn1000000.Text = "1000000";
            this.btn1000000.UseVisualStyleBackColor = false;
            this.btn1000000.Click += new System.EventHandler(this.btn1000000_Click);
            // 
            // btn500000
            // 
            this.btn500000.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn500000.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn500000.ForeColor = System.Drawing.Color.White;
            this.btn500000.Location = new System.Drawing.Point(305, 380);
            this.btn500000.Margin = new System.Windows.Forms.Padding(6);
            this.btn500000.Name = "btn500000";
            this.btn500000.Size = new System.Drawing.Size(358, 112);
            this.btn500000.TabIndex = 37;
            this.btn500000.Text = "500000";
            this.btn500000.UseVisualStyleBackColor = false;
            this.btn500000.Click += new System.EventHandler(this.btn500000_Click);
            // 
            // btn200000
            // 
            this.btn200000.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn200000.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn200000.ForeColor = System.Drawing.Color.White;
            this.btn200000.Location = new System.Drawing.Point(900, 203);
            this.btn200000.Margin = new System.Windows.Forms.Padding(6);
            this.btn200000.Name = "btn200000";
            this.btn200000.Size = new System.Drawing.Size(368, 112);
            this.btn200000.TabIndex = 36;
            this.btn200000.Text = "200000";
            this.btn200000.UseVisualStyleBackColor = false;
            this.btn200000.Click += new System.EventHandler(this.btn200000_Click);
            // 
            // btn100000
            // 
            this.btn100000.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn100000.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn100000.ForeColor = System.Drawing.Color.White;
            this.btn100000.Location = new System.Drawing.Point(296, 203);
            this.btn100000.Margin = new System.Windows.Forms.Padding(6);
            this.btn100000.Name = "btn100000";
            this.btn100000.Size = new System.Drawing.Size(358, 112);
            this.btn100000.TabIndex = 35;
            this.btn100000.Text = "100000";
            this.btn100000.UseVisualStyleBackColor = false;
            this.btn100000.Click += new System.EventHandler(this.btn100000_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(494, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(683, 85);
            this.label2.TabIndex = 34;
            this.label2.Text = "Chọn tiền muốn rút";
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1824, 954);
            this.Controls.Add(this.pbReturnCard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn1000000);
            this.Controls.Add(this.btn500000);
            this.Controls.Add(this.btn200000);
            this.Controls.Add(this.btn100000);
            this.Controls.Add(this.label2);
            this.Name = "Withdraw";
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbReturnCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbReturnCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn1000000;
        private System.Windows.Forms.Button btn500000;
        private System.Windows.Forms.Button btn200000;
        private System.Windows.Forms.Button btn100000;
        private System.Windows.Forms.Label label2;
    }
}