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

namespace Kinoteatr
{
    public partial class Form3 : Form
    {
        Button[] places = new Button[10];
        public static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = seans.accdb";
        private OleDbConnection myConnection;
        bool[] free=new bool[10];
        public Form3()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
        }
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
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seansDataSet.seansesTable". При необходимости она может быть перемещена или удалена.
            this.seansesTableTableAdapter.Fill(this.seansDataSet.seansesTable);
            Fill();
            places[0] = button1;
            places[1] = button2;
            places[2] = button3;
            places[3] = button4;
            places[4] = button5;
            places[5] = button6;
            places[6] = button7;
            places[7] = button8;
            places[8] = button9;
            places[9] = button10;

        }
        public void GetPlaces()
        {
            string query = "SELECT place0 FROM seansesTable WHERE kinoName = " + "'"+name+"'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            string res0 = command.ExecuteScalar().ToString();
            if (res0 != "1") free[0] = true; else free[0] = false;
            string query1 = "SELECT place1 FROM seansesTable WHERE kinoName = " + "'" + name + "'";
            OleDbCommand command1 = new OleDbCommand(query1, myConnection);
            string res1 = command1.ExecuteScalar().ToString();
            if (res1 != "1") free[1] = true;else free[1]=false;
            string query2= "SELECT place2 FROM seansesTable WHERE kinoName = " + "'" + name + "'";
            OleDbCommand command2 = new OleDbCommand(query2, myConnection);
            string res2 = command2.ExecuteScalar().ToString();
            if (res2 != "1") free[2] = true; else free[2] = false;
            string query3 = "SELECT place3 FROM seansesTable WHERE  kinoName= " + "'" + name + "'";
            OleDbCommand command3 = new OleDbCommand(query3, myConnection);
            string res3 = command3.ExecuteScalar().ToString();
            if (res3 != "1") free[3] = true; else free[3] = false;
            string query4 = "SELECT place4 FROM seansesTable WHERE kinoName = " + "'" + name + "'";
            OleDbCommand command4 = new OleDbCommand(query4, myConnection);
            string res4 = command4.ExecuteScalar().ToString();
            if (res4 != "1") free[4] = true; else free[4] = false;
            string query5 = "SELECT place5 FROM seansesTable WHERE kinoName = " + "'" + name + "'";
            OleDbCommand command5 = new OleDbCommand(query5, myConnection);
            string res5= command5.ExecuteScalar().ToString();
            if (res5 != "1") free[5] = true; else free[5] = false;
            string query6 = "SELECT place6 FROM seansesTable WHERE  kinoName= " + "'" + name + "'";
            OleDbCommand command6 = new OleDbCommand(query6, myConnection);
            string res6 = command6.ExecuteScalar().ToString();
            if (res6 != "1") free[6] = true; else free[6] = false;
            string query7 = "SELECT place7 FROM seansesTable WHERE kinoName = " + "'" + name + "'";
            OleDbCommand command7 = new OleDbCommand(query7, myConnection);
            string res7 = command7.ExecuteScalar().ToString();
            if (res7 != "1") free[7] = true; else free[7] = false;
            string query8 = "SELECT place8 FROM seansesTable WHERE  kinoName= " + "'" + name + "'";
            OleDbCommand command8 = new OleDbCommand(query8, myConnection);
            string res8 = command8.ExecuteScalar().ToString();
            if (res8!= "1") free[8] = true; else free[8] = false;
            string query9 = "SELECT place9 FROM seansesTable WHERE kinoName = " + "'" + name + "'";
            OleDbCommand command9 = new OleDbCommand(query9, myConnection);
            string res9 = command9.ExecuteScalar().ToString();
            if (res9 != "1") free[9] = true; else free[9] = false;
            

        }
        public string name;
        public void Check()
        {
            name = listBox1.SelectedItem.ToString();
            GetPlaces();
            for (int i = 0; i < places.Length; i++)
            {
                places[i].Enabled = free[i];
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Check();


        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string query = "UPDATE seansesTable SET place9 = 1 WHERE kinoName=" + "'" + name + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            Check();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string query = "UPDATE seansesTable SET place8 = 1 WHERE kinoName=" + "'" + name + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            Check();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string query = "UPDATE seansesTable SET place7 = 1 WHERE kinoName=" + "'" + name + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            Check();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string query = "UPDATE seansesTable SET place6 = 1 WHERE kinoName=" + "'" + name + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            Check();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query = "UPDATE seansesTable SET place5 = 1 WHERE kinoName=" + "'" + name + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            Check();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "UPDATE seansesTable SET place4 = 1 WHERE kinoName=" + "'" + name + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            Check();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "UPDATE seansesTable SET place3 = 1 WHERE kinoName=" + "'" + name + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            Check();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "UPDATE seansesTable SET place2 = 1 WHERE kinoName=" + "'" + name + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            Check();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "UPDATE seansesTable SET place1 = 1 WHERE kinoName=" + "'" + name + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            Check();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "UPDATE seansesTable SET place0 = 1 WHERE kinoName=" + "'" + name + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            Check();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
