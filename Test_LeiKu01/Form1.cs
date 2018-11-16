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
namespace Test_LeiKu01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyProject01.MainForm main = new MyProject01.MainForm();
            MyProject01.QueryForm query = new MyProject01.QueryForm();
            navigatorEx1.ShowAddBtn = true;
            navigatorEx1.AddButton("xxx", selectAll);
            query.Show();
            //main.Show();
            //main.Show();
            
        }

        private void selectAll(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        string MyConnectionString = "Server=localhost;Database=hap_train;Uid=root;Pwd=root";

        private void buttonEx1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT EMPLOYEE_ID,NAME FROM hr_employee";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridViewEx1.DataSource = ds.Tables[0].DefaultView;
                Mes.Core.Service.MessageService.ShowMessage("show message");

                Mes.Core.Utility.BindDataUtil.comboBoxBindData(Mes.Core.ApplicationObject.ComboBoxInitType.SQL, "SELECT NAME FROM hr_employee", this.comboBoxEx1);
                Mes.Core.Utility.BindDataUtil.comboBoxBindData(Mes.Core.ApplicationObject.ComboBoxInitType.FASTWITHNULL, "SYS_LANGUAGE", this.comboBoxEx1);
            }
            catch (Exception)
            {
                throw;
            }
            finally {
                if (connection.State == ConnectionState.Open) {
                    connection.Clone();
                }
            }
        }
    }
}
