using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace Agct_test2
{
    public partial class DataView : Form
    {
        public DataView()
        {
            InitializeComponent();
        }

        public MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        public MySqlConnection connection;




        //进行连接按钮
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            builder.UserID = "root";
            builder.Password = "root";
            builder.Server = "47.115.208.50";
            builder.Database = "iot_agct_service";
            connection = new MySqlConnection(builder.ConnectionString);
            try
            {
                //打开数据库连接
                connection.Open();
                MessageBox.Show("成功连接服务器："+builder.Server+"\n"+"成功连接数据库："+builder.Database);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //数据查询按钮
        private void buttonQuery_Click(object sender, EventArgs e)
        {
            string sql = "select * from data";
            MySqlDataAdapter mda = new MySqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            mda.Fill(ds, "data");
            //显示数据
            dataGridView1.DataSource = ds.Tables["data"];
            connection.Close();
        }

        //删除数据
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string sql = "delete from data where id = "+textBox1.Text;
            MySqlDataAdapter mda = new MySqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            mda.Fill(ds, "data");
            connection.Close();
        }
    }
}
