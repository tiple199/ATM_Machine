namespace TestProject
{
    partial class Balance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Balance));
            this.label1 = new System.Windows.Forms.Label();
            this.pbReturnCard = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPrintRecipt = new System.Windows.Forms.Button();
            this.txtbalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturnCard)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1313, 823);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 85);
            this.label1.TabIndex = 27;
            this.label1.Text = "Return Card";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbReturnCard
            // 
            this.pbReturnCard.Image = ((System.Drawing.Image)(resources.GetObject("pbReturnCard.Image")));
            this.pbReturnCard.Location = new System.Drawing.Point(1147, 784);
            this.pbReturnCard.Margin = new System.Windows.Forms.Padding(6);
            this.pbReturnCard.Name = "pbReturnCard";
            this.pbReturnCard.Size = new System.Drawing.Size(140, 135);
            this.pbReturnCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReturnCard.TabIndex = 26;
            this.pbReturnCard.TabStop = false;
            this.pbReturnCard.Click += new System.EventHandler(this.pbReturnCard_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(40, 807);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(198, 112);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPrintRecipt
            // 
            this.btnPrintRecipt.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPrintRecipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintRecipt.ForeColor = System.Drawing.Color.White;
            this.btnPrintRecipt.Location = new System.Drawing.Point(434, 613);
            this.btnPrintRecipt.Margin = new System.Windows.Forms.Padding(6);
            this.btnPrintRecipt.Name = "btnPrintRecipt";
            this.btnPrintRecipt.Size = new System.Drawing.Size(738, 112);
            this.btnPrintRecipt.TabIndex = 24;
            this.btnPrintRecipt.Text = "Print Recipt";
            this.btnPrintRecipt.UseVisualStyleBackColor = false;
            this.btnPrintRecipt.Click += new System.EventHandler(this.btnPrintRecipt_Click);
            // 
            // txtbalance
            // 
            this.txtbalance.AutoSize = true;
            this.txtbalance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbalance.ForeColor = System.Drawing.Color.White;
            this.txtbalance.Location = new System.Drawing.Point(784, 469);
            this.txtbalance.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(311, 85);
            this.txtbalance.TabIndex = 23;
            this.txtbalance.Text = "0000.00";
            this.txtbalance.Click += new System.EventHandler(this.txtbalance_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(431, 469);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 85);
            this.label2.TabIndex = 22;
            this.label2.Text = "Số dư:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(633, 257);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 85);
            this.label3.TabIndex = 21;
            this.label3.Text = "Balance";
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1803, 1176);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbReturnCard);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrintRecipt);
            this.Controls.Add(this.txtbalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "Balance";
            this.Text = "Balance";
            this.Load += new System.EventHandler(this.Balance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbReturnCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbReturnCard;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPrintRecipt;
        private System.Windows.Forms.Label txtbalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}