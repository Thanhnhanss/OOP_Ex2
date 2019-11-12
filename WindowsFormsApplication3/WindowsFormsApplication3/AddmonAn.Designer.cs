namespace WindowsFormsApplication3
{
    partial class AddmonAn
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
            this.lblTenmon = new System.Windows.Forms.Label();
            this.lblGiatien = new System.Windows.Forms.Label();
            this.txtTenmon = new System.Windows.Forms.TextBox();
            this.txtGiatien = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTenmon
            // 
            this.lblTenmon.AutoSize = true;
            this.lblTenmon.Location = new System.Drawing.Point(13, 13);
            this.lblTenmon.Name = "lblTenmon";
            this.lblTenmon.Size = new System.Drawing.Size(52, 13);
            this.lblTenmon.TabIndex = 0;
            this.lblTenmon.Text = "Ten mon:";
            // 
            // lblGiatien
            // 
            this.lblGiatien.AutoSize = true;
            this.lblGiatien.Location = new System.Drawing.Point(13, 60);
            this.lblGiatien.Name = "lblGiatien";
            this.lblGiatien.Size = new System.Drawing.Size(46, 13);
            this.lblGiatien.TabIndex = 1;
            this.lblGiatien.Text = "Gia tien:";
            // 
            // txtTenmon
            // 
            this.txtTenmon.Location = new System.Drawing.Point(74, 14);
            this.txtTenmon.Name = "txtTenmon";
            this.txtTenmon.Size = new System.Drawing.Size(112, 20);
            this.txtTenmon.TabIndex = 2;
            // 
            // txtGiatien
            // 
            this.txtGiatien.Location = new System.Drawing.Point(74, 53);
            this.txtGiatien.Name = "txtGiatien";
            this.txtGiatien.Size = new System.Drawing.Size(112, 20);
            this.txtGiatien.TabIndex = 3;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(62, 93);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // AddmonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 135);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtGiatien);
            this.Controls.Add(this.txtTenmon);
            this.Controls.Add(this.lblGiatien);
            this.Controls.Add(this.lblTenmon);
            this.Name = "AddmonAn";
            this.Text = "AdđAnsang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenmon;
        private System.Windows.Forms.Label lblGiatien;
        private System.Windows.Forms.TextBox txtTenmon;
        private System.Windows.Forms.TextBox txtGiatien;
        private System.Windows.Forms.Button btnLuu;
    }
}