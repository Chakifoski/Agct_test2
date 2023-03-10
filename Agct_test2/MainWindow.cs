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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using Sunny.UI.Win32;


namespace Agct_test2
{
    public partial class MainWindow : Form
    {
        //定义链接
        public MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        public MySqlConnection connection;


        public MainWindow()
        {
            InitializeComponent();
            builder.UserID = "root";
            builder.Password = "No1LikeU.";
            builder.Server = "47.115.208.50";
            builder.Database = "iot_agct_data";
            connection = new MySqlConnection(builder.ConnectionString);

            //初始化时间
            ucledDataTime1.Value = DateTime.Now;

            try
            {
                //打开数据库连接
                connection.Open();
                MessageBox.Show("成功连接服务器：" + builder.Server + "\n" + "成功连接数据库：" + builder.Database);

                //载入数据并读取进度条
                string my_query = "SELECT * FROM env_data ORDER BY id DESC LIMIT 1";
/*                "select * from data where id = 1"*/
                MySqlCommand my_cmd = new MySqlCommand(my_query, connection);
                MySqlDataReader my_dataReader = my_cmd.ExecuteReader();

                my_dataReader.Read();

                //绑定温湿度计1
                int temp1 = Convert.ToInt32(my_dataReader["temp1"]);
                ucThermometer1.Value = temp1;
                int hum1 = Convert.ToInt32(my_dataReader["hum1"]);
                ucMeter1.Value = hum1;

                //绑定温湿度计2
                int temp2 = Convert.ToInt32(my_dataReader["temp2"]);
                ucThermometer2.Value = temp2;
                int hum2 = Convert.ToInt32(my_dataReader["hum2"]);
                ucMeter2.Value = hum2;

                //绑定温湿度计3
                int temp3 = Convert.ToInt32(my_dataReader["temp3"]);
                ucThermometer3.Value = temp3;
                int hum3 = Convert.ToInt32(my_dataReader["hum3"]);
                ucMeter3.Value = hum3;

                //绑定二氧化碳浓度
                int co2 = Convert.ToInt32(my_dataReader["co2"]);
                ucProcessWave1.Value = co2;

                //绑定光照强度
                int light = Convert.ToInt32(my_dataReader["light"]);
                ucProcessEllipse1.Value = light;

                //关闭读取进度条
                my_dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }





        //查看历史数据按钮
        private void buttonViewData_Click(object sender, EventArgs e)
        {
            DataView dtv = new DataView();
            dtv.ShowDialog(this);
        }

        //刷新按钮
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                //初始化时间
                ucledDataTime1.Value = DateTime.Now;

                //载入数据并读取进度条
                string my_query = "SELECT * FROM env_data ORDER BY id DESC LIMIT 1";
                MySqlCommand my_cmd = new MySqlCommand(my_query, connection);
                MySqlDataReader my_dataReader = my_cmd.ExecuteReader();

                my_dataReader.Read();

                //绑定温湿度计1
                int temp1 = Convert.ToInt32(my_dataReader["temp1"]);
                ucThermometer1.Value = temp1;
                int hum1 = Convert.ToInt32(my_dataReader["hum1"]);
                ucMeter1.Value = hum1;

                //绑定温湿度计2
                int temp2 = Convert.ToInt32(my_dataReader["temp2"]);
                ucThermometer2.Value = temp2;
                int hum2 = Convert.ToInt32(my_dataReader["hum2"]);
                ucMeter2.Value = hum2;

                //绑定温湿度计3
                int temp3 = Convert.ToInt32(my_dataReader["temp3"]);
                ucThermometer3.Value = temp3;
                int hum3 = Convert.ToInt32(my_dataReader["hum3"]);
                ucMeter3.Value = hum3;

                //绑定二氧化碳浓度
                int co2 = Convert.ToInt32(my_dataReader["co2"]);
                ucProcessWave1.Value = co2;

                //绑定光照强度
                int light = Convert.ToInt32(my_dataReader["light"]);
                ucProcessEllipse1.Value = light;

                //关闭读取进度条
                my_dataReader.Close();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
