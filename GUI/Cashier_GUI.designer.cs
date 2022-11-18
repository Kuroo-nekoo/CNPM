namespace GUI
{
    partial class Cashier_GUI
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
            this.components = new System.ComponentModel.Container();
            this.flpCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.flpSelectedItem = new System.Windows.Forms.FlowLayoutPanel();
            this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpCategory
            // 
            this.flpCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpCategory.Location = new System.Drawing.Point(0, 0);
            this.flpCategory.Margin = new System.Windows.Forms.Padding(4);
            this.flpCategory.Name = "flpCategory";
            this.flpCategory.Size = new System.Drawing.Size(267, 574);
            this.flpCategory.TabIndex = 0;
            // 
            // flpSelectedItem
            // 
            this.flpSelectedItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpSelectedItem.Location = new System.Drawing.Point(0, 4);
            this.flpSelectedItem.Margin = new System.Windows.Forms.Padding(4);
            this.flpSelectedItem.Name = "flpSelectedItem";
            this.flpSelectedItem.Size = new System.Drawing.Size(577, 432);
            this.flpSelectedItem.TabIndex = 1;
            // 
            // flpMain
            // 
            this.flpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpMain.Location = new System.Drawing.Point(275, 0);
            this.flpMain.Margin = new System.Windows.Forms.Padding(4);
            this.flpMain.Name = "flpMain";
            this.flpMain.Size = new System.Drawing.Size(383, 574);
            this.flpMain.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTotal);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.flpSelectedItem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(666, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 574);
            this.panel1.TabIndex = 0;
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Red;
            this.lbTotal.Location = new System.Drawing.Point(4, 440);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(573, 36);
            this.lbTotal.TabIndex = 3;
            this.lbTotal.Text = "label1";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(4, 480);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(573, 90);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thanh toán";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cashier_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 574);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpMain);
            this.Controls.Add(this.flpCategory);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cashier_GUI";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Cashier_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpCategory;
        private System.Windows.Forms.FlowLayoutPanel flpSelectedItem;
        private System.Windows.Forms.FlowLayoutPanel flpMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbTotal;
    }
}