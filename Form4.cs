using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Kinoteatr
{
    public partial class Form4 : Form
    {
        public static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = seans.accdb";
        private OleDbConnection myConnection;
        public Form4()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO seansesTable ([kinoName],[kinoTime]) VALUES " + "('" + textBox1.Text + "','" + textBox2.Text + "')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            
            this.Close();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seansDataSet.seansesTable". При необходимости она может быть перемещена или удалена.
            this.seansesTableTableAdapter.Fill(this.seansDataSet.seansesTable);

        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}
