namespace GUI.CustomControl
{
    partial class SelectedItemFlowLayoutPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbName = new System.Windows.Forms.Label();
            this.btRemove = new System.Windows.Forms.Button();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btIncrese = new System.Windows.Forms.Button();
            this.btDecrease = new System.Windows.Forms.Button();
            this.lbPrice = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btSizeS = new System.Windows.Forms.Button();
            this.btSizeM = new System.Windows.Forms.Button();
            this.btSizeL = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(193, 64);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 16);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "label1";
            // 
            // btRemove
            // 
            this.btRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRemove.Location = new System.Drawing.Point(519, 3);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(40, 40);
            this.btRemove.TabIndex = 3;
            this.btRemove.Text = "x";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // tbAmount
            // 
            this.tbAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAmount.Location = new System.Drawing.Point(433, 159);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(60, 22);
            this.tbAmount.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-114, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 100);
            this.panel1.TabIndex = 5;
            // 
            // btIncrese
            // 
            this.btIncrese.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btIncrese.Location = new System.Drawing.Point(499, 140);
            this.btIncrese.Name = "btIncrese";
            this.btIncrese.Size = new System.Drawing.Size(60, 60);
            this.btIncrese.TabIndex = 2;
            this.btIncrese.Text = "+";
            this.btIncrese.UseVisualStyleBackColor = true;
            this.btIncrese.Click += new System.EventHandler(this.btIncrese_Click);
            // 
            // btDecrease
            // 
            this.btDecrease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDecrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDecrease.Location = new System.Drawing.Point(367, 140);
            this.btDecrease.Name = "btDecrease";
            this.btDecrease.Size = new System.Drawing.Size(60, 60);
            this.btDecrease.TabIndex = 1;
            this.btDecrease.Text = "-";
            this.btDecrease.UseVisualStyleBackColor = true;
            this.btDecrease.Click += new System.EventHandler(this.btDecrease_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(193, 151);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(22, 16);
            this.lbPrice.TabIndex = 6;
            this.lbPrice.Text = "0d";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btSizeL);
            this.panel2.Controls.Add(this.btSizeM);
            this.panel2.Controls.Add(this.btSizeS);
            this.panel2.Controls.Add(this.btDecrease);
            this.panel2.Controls.Add(this.btIncrese);
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Controls.Add(this.tbAmount);
            this.panel2.Controls.Add(this.btRemove);
            this.panel2.Controls.Add(this.lbPrice);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 205);
            this.panel2.TabIndex = 7;
            // 
            // btSizeS
            // 
            this.btSizeS.Location = new System.Drawing.Point(367, 64);
            this.btSizeS.Name = "btSizeS";
            this.btSizeS.Size = new System.Drawing.Size(60, 60);
            this.btSizeS.TabIndex = 7;
            this.btSizeS.Text = "S";
            this.btSizeS.UseVisualStyleBackColor = true;
            this.btSizeS.Click += new System.EventHandler(this.btSizeS_Click);
            // 
            // btSizeM
            // 
            this.btSizeM.Location = new System.Drawing.Point(433, 64);
            this.btSizeM.Name = "btSizeM";
            this.btSizeM.Size = new System.Drawing.Size(60, 60);
            this.btSizeM.TabIndex = 8;
            this.btSizeM.Text = "M";
            this.btSizeM.UseVisualStyleBackColor = true;
            this.btSizeM.Click += new System.EventHandler(this.btSizeM_Click);
            // 
            // btSizeL
            // 
            this.btSizeL.Location = new System.Drawing.Point(499, 64);
            this.btSizeL.Name = "btSizeL";
            this.btSizeL.Size = new System.Drawing.Size(60, 60);
            this.btSizeL.TabIndex = 9;
            this.btSizeL.Text = "L";
            this.btSizeL.UseVisualStyleBackColor = true;
            this.btSizeL.Click += new System.EventHandler(this.btSizeL_Click);
            // 
            // SelectedItemFlowLayoutPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SelectedItemFlowLayoutPanel";
            this.Size = new System.Drawing.Size(570, 211);
            this.Load += new System.EventHandler(this.SelectedItemFlowLayoutPanel_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btIncrese;
        private System.Windows.Forms.Button btDecrease;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btSizeL;
        private System.Windows.Forms.Button btSizeM;
        private System.Windows.Forms.Button btSizeS;
    }
}
