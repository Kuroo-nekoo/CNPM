namespace GUI
{
    partial class Payment_GUI
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
                this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
                this.lbExcess = new System.Windows.Forms.Label();
                this.label4 = new System.Windows.Forms.Label();
                this.lbTotal = new System.Windows.Forms.Label();
                this.label2 = new System.Windows.Forms.Label();
                this.tbReceive = new System.Windows.Forms.TextBox();
                this.label1 = new System.Windows.Forms.Label();
                this.btPrint = new System.Windows.Forms.Button();
                this.tableLayoutPanel1.SuspendLayout();
                this.SuspendLayout();
                // 
                // tableLayoutPanel1
                // 
                this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                this.tableLayoutPanel1.ColumnCount = 2;
                this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.21317F));
                this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.78683F));
                this.tableLayoutPanel1.Controls.Add(this.lbExcess, 1, 2);
                this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
                this.tableLayoutPanel1.Controls.Add(this.lbTotal, 1, 0);
                this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
                this.tableLayoutPanel1.Controls.Add(this.tbReceive, 1, 1);
                this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
                this.tableLayoutPanel1.Location = new System.Drawing.Point(207, 175);
                this.tableLayoutPanel1.Name = "tableLayoutPanel1";
                this.tableLayoutPanel1.RowCount = 3;
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
                this.tableLayoutPanel1.Size = new System.Drawing.Size(319, 100);
                this.tableLayoutPanel1.TabIndex = 0;
                // 
                // lbExcess
                // 
                this.lbExcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
                this.lbExcess.AutoSize = true;
                this.lbExcess.Location = new System.Drawing.Point(93, 75);
                this.lbExcess.Name = "lbExcess";
                this.lbExcess.Size = new System.Drawing.Size(223, 16);
                this.lbExcess.TabIndex = 7;
                this.lbExcess.Text = "label5";
                // 
                // label4
                // 
                this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
                this.label4.AutoSize = true;
                this.label4.Location = new System.Drawing.Point(3, 75);
                this.label4.Name = "label4";
                this.label4.Size = new System.Drawing.Size(84, 16);
                this.label4.TabIndex = 6;
                this.label4.Text = "Tiền thừa";
                // 
                // lbTotal
                // 
                this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
                this.lbTotal.AutoSize = true;
                this.lbTotal.Location = new System.Drawing.Point(93, 8);
                this.lbTotal.Name = "lbTotal";
                this.lbTotal.Size = new System.Drawing.Size(223, 16);
                this.lbTotal.TabIndex = 5;
                this.lbTotal.Text = "label3";
                // 
                // label2
                // 
                this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
                this.label2.AutoSize = true;
                this.label2.Location = new System.Drawing.Point(3, 41);
                this.label2.Name = "label2";
                this.label2.Size = new System.Drawing.Size(84, 16);
                this.label2.TabIndex = 4;
                this.label2.Text = "Khách trả";
                // 
                // tbReceive
                // 
                this.tbReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
                this.tbReceive.Location = new System.Drawing.Point(93, 38);
                this.tbReceive.Name = "tbReceive";
                this.tbReceive.Size = new System.Drawing.Size(223, 22);
                this.tbReceive.TabIndex = 2;
                this.tbReceive.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
                this.tbReceive.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
                // 
                // label1
                // 
                this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
                this.label1.AutoSize = true;
                this.label1.Location = new System.Drawing.Point(3, 8);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(84, 16);
                this.label1.TabIndex = 3;
                this.label1.Text = "Tổng tiền";
                // 
                // btPrint
                // 
                this.btPrint.Location = new System.Drawing.Point(662, 388);
                this.btPrint.Name = "btPrint";
                this.btPrint.Size = new System.Drawing.Size(126, 50);
                this.btPrint.TabIndex = 1;
                this.btPrint.Text = "Xác nhận";
                this.btPrint.UseVisualStyleBackColor = true;
                // 
                // Payment
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(800, 450);
                this.Controls.Add(this.btPrint);
                this.Controls.Add(this.tableLayoutPanel1);
                this.Name = "Payment";
                this.Text = "Payment";
                this.Load += new System.EventHandler(this.Payment_Load);
                this.tableLayoutPanel1.ResumeLayout(false);
                this.tableLayoutPanel1.PerformLayout();
                this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbReceive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbExcess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btPrint;
    }
}