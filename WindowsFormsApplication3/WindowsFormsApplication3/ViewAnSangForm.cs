using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class ViewAnSangForm : Form
    {
        public ViewAnSangForm()
        {
            InitializeComponent();
            this.Load += ViewAnSangForm_Load;
            this.grdAnSang.Click += grdAnSang_Click;
        }

        void grdAnSang_Click(object sender, EventArgs e)
        {
            var form = new AddmonAn();
            form.ShowDialog();
            this.ShowAnSangList();
        }

        void ViewAnSangForm_Load(object sender, EventArgs e)
        {
            this.ShowAnSangList();
        }
        private void ShowAnSangList()
        {
            QuanAnEntities db = new QuanAnEntities();
            var list = db.AnSangs.ToArray();
            this.grdAnSang.DataSource = list;
           
        }
    }
}
