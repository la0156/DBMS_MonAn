using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_MonAn
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DBMS_MONANTinhTien.TinhTien' table. You can move, or remove it, as needed.
            this.TinhTienTableAdapter.Fill(this.DBMS_MONANTinhTien.TinhTien);

            this.reportViewer1.RefreshReport();
        }
    }
}
