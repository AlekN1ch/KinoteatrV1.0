using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinoteatr
{
    public partial class Form2 : Form
    {
        public static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = seans.accdb";
        private OleDbConnection myConnection;
        public static bool[] freePlace= new bool[10];
        public Form2()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seansDataSet.seansesTable". При необходимости она может быть перемещена или удалена.
            this.seansesTableTableAdapter.Fill(this.seansDataSet.seansesTable);
            Fill();

        }
        public static List<string> seanses=new List<string>();
        public void Fill()
        {
            string query = "SELECT kinoName FROM seansesTable ORDER BY Код";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            listBox1.Items.Clear();
            while (reader.Read())
            {
                listBox1.Items.Add(reader[0].ToString());
            }
            reader.Close();
            foreach (var item in listBox1.Items)
            {
                seanses.Add(item.ToString());
            }
            

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.seansesTableTableAdapter.Fill(this.seansDataSet.seansesTable);
            Fill();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
    
    
}
