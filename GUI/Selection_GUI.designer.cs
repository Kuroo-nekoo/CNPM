namespace GUI
{
    partial class Selection_GUI
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
            this.btCashier = new System.Windows.Forms.Button();
            this.btWarehouseManagement = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCashier
            // 
            this.btCashier.Location = new System.Drawing.Point(222, 214);
            this.btCashier.Name = "btCashier";
            this.btCashier.Size = new System.Drawing.Size(99, 23);
            this.btCashier.TabIndex = 0;
            this.btCashier.Text = "Thu ngân";
            this.btCashier.UseVisualStyleBackColor = true;
            this.btCashier.Click += new System.EventHandler(this.btCashier_Click);
            // 
            // btWarehouseManagement
            // 
            this.btWarehouseManagement.Location = new System.Drawing.Point(349, 214);
            this.btWarehouseManagement.Name = "btWarehouseManagement";
            this.btWarehouseManagement.Size = new System.Drawing.Size(104, 23);
            this.btWarehouseManagement.TabIndex = 2;
            this.btWarehouseManagement.Text = "Quản lý kho";
            this.btWarehouseManagement.UseVisualStyleBackColor = true;
            this.btWarehouseManagement.Click += new System.EventHandler(this.btWarehouseManagement_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Quản lý";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btWarehouseManagement);
            this.Controls.Add(this.btCashier);
            this.Name = "Selection";
            this.Text = ",";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCashier;
        private System.Windows.Forms.Button btWarehouseManagement;
        private System.Windows.Forms.Button button1;
    }
}