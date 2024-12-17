using System.Data;
using Microsoft.Data.SqlClient;

namespace DBMS_SQL_EmployeeSales {
    public partial class DBMS_SQL_EmployeeSales : Form
    {
        public DBMS_SQL_EmployeeSales()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        public void connect()
        {
            string server = @".\SQLEXPRESS";
            string db = "northwind";
            string strConn = string.Format(@"Data Source={0};Initial Catalog={1};Integrated Security=True ;Encrypt=False", server, db);
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public void disconnect()
        {
            conn.Close();
        }

        private void showData(string sql, DataGridView dgv)
        {
            da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgv.DataSource = ds.Tables[0];
            dgvEmployee.DataSource = ds.Tables[0];
        }

        private void DBMS_SQL_EmployeeSales_Load(object sender, EventArgs e)
        {
            connect();
            string sqlQuery = "SELECT * FROM EmployeeSales ORDER BY EmployeeID ASC";
            showData(sqlQuery, dgvEmployee);
        }

        private void dgvEmployee_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int id = Convert.ToInt32(dgvEmployee.CurrentRow.Cells[0].Value);
                //MessageBox.Show(id.ToString(), "รหัสที่เลือก");
                string sqlQuery = "SELECT OrderID, CustomerID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry FROM OrderListByEmployee WHERE EmployeeID = @id ORDER BY orderID ASC";
                cmd = new SqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                    da.Fill(ds);
                dgvOrderList.DataSource = ds.Tables[0];
            }
        }
    }
}
