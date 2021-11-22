using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace GUI_MonAn
{
    public partial class ThongKe : Form
    {
        private SqlConnection Conn = dbConnectionData.HamKetNoi();
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBMS_MONANBill.BILL' table. You can move, or remove it, as needed.
            this.bILLTableAdapter.Fill(this.dBMS_MONANBill.BILL);
            // TODO: This line of code loads data into the 'dBMS_MONANDataSet.MenuMonAn' table. You can move, or remove it, as needed.
            this.menuMonAnTableAdapter.Fill(this.dBMS_MONANDataSet.MenuMonAn);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }



        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
