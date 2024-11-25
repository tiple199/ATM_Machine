namespace TestProject
{
    partial class Trans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trans));
            this.label3 = new System.Windows.Forms.Label();
            this.lbCurrentBalance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtAccNo = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.pbReturnCard = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcurrentbalance = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturnCard)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(593, 437);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 48);
            this.label3.TabIndex = 42;
            this.label3.Text = "Amount";
            // 
            // lbCurrentBalance
            // 
            this.lbCurrentBalance.AutoSize = true;
            this.lbCurrentBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentBalance.ForeColor = System.Drawing.Color.White;
            this.lbCurrentBalance.Location = new System.Drawing.Point(109, -119);
            this.lbCurrentBalance.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCurrentBalance.Name = "lbCurrentBalance";
            this.lbCurrentBalance.Size = new System.Drawing.Size(170, 48);
            this.lbCurrentBalance.TabIndex = 43;
            this.lbCurrentBalance.Text = "0000.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(-247, -119);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(344, 48);
            this.label5.TabIndex = 44;
            this.label5.Text = "Current Balance: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(593, 285);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 48);
            this.label2.TabIndex = 45;
            this.label2.Text = "Enter Acc. Number:";
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Location = new System.Drawing.Point(793, 601);
            this.btnTransfer.Margin = new System.Windows.Forms.Padding(6);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(278, 112);
            this.btnTransfer.TabIndex = 41;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(807, 285);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 85);
            this.label4.TabIndex = 40;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAmount.Location = new System.Drawing.Point(603, 491);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(6);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(646, 71);
            this.txtAmount.TabIndex = 38;
            this.txtAmount.Text = "xxxx";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAmount_MouseClick);
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // txtAccNo
            // 
            this.txtAccNo.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccNo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAccNo.Location = new System.Drawing.Point(603, 339);
            this.txtAccNo.Margin = new System.Windows.Forms.Padding(6);
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(646, 71);
            this.txtAccNo.TabIndex = 39;
            this.txtAccNo.Text = "xxxx-xxxx-xxxx-xxxx";
            this.txtAccNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAccNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbAccNo_MouseClick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(-237, 1001);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(198, 112);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // pbReturnCard
            // 
            this.pbReturnCard.Image = ((System.Drawing.Image)(resources.GetObject("pbReturnCard.Image")));
            this.pbReturnCard.Location = new System.Drawing.Point(1207, 782);
            this.pbReturnCard.Margin = new System.Windows.Forms.Padding(6);
            this.pbReturnCard.Name = "pbReturnCard";
            this.pbReturnCard.Size = new System.Drawing.Size(140, 135);
            this.pbReturnCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReturnCard.TabIndex = 35;
            this.pbReturnCard.TabStop = false;
            this.pbReturnCard.Click += new System.EventHandler(this.pbReturnCard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1372, 811);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 85);
            this.label1.TabIndex = 34;
            this.label1.Text = "Return Card";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(31, 865);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 112);
            this.button1.TabIndex = 46;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcurrentbalance
            // 
            this.txtcurrentbalance.AutoSize = true;
            this.txtcurrentbalance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtcurrentbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcurrentbalance.ForeColor = System.Drawing.Color.White;
            this.txtcurrentbalance.Location = new System.Drawing.Point(379, 38);
            this.txtcurrentbalance.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtcurrentbalance.Name = "txtcurrentbalance";
            this.txtcurrentbalance.Size = new System.Drawing.Size(170, 48);
            this.txtcurrentbalance.TabIndex = 47;
            this.txtcurrentbalance.Text = "0000.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(344, 48);
            this.label7.TabIndex = 48;
            this.label7.Text = "Current Balance: ";
            // 
            // Trans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1837, 976);
            this.Controls.Add(this.txtcurrentbalance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbCurrentBalance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtAccNo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pbReturnCard);
            this.Controls.Add(this.label1);
            this.Name = "Trans";
            this.Text = "Trans";
            this.Load += new System.EventHandler(this.Trans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbReturnCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCurrentBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtAccNo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pbReturnCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtcurrentbalance;
        private System.Windows.Forms.Label label7;
    }
}