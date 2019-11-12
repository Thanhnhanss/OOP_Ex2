namespace WindowsFormsApplication3
{
    partial class ViewAnSangForm
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
            this.grdAnSang = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.themMonAnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdAnSang)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdAnSang
            // 
            this.grdAnSang.AllowUserToAddRows = false;
            this.grdAnSang.AllowUserToDeleteRows = false;
            this.grdAnSang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAnSang.Location = new System.Drawing.Point(1, 55);
            this.grdAnSang.Name = "grdAnSang";
            this.grdAnSang.ReadOnly = true;
            this.grdAnSang.Size = new System.Drawing.Size(417, 226);
            this.grdAnSang.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themMonAnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(417, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // themMonAnToolStripMenuItem
            // 
            this.themMonAnToolStripMenuItem.Name = "themMonAnToolStripMenuItem";
            this.themMonAnToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.themMonAnToolStripMenuItem.Text = "Them mon an";
            // 
            // ViewAnSangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 279);
            this.Controls.Add(this.grdAnSang);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ViewAnSangForm";
            this.Text = "MENU";
            ((System.ComponentModel.ISupportInitialize)(this.grdAnSang)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdAnSang;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem themMonAnToolStripMenuItem;

    }
}

