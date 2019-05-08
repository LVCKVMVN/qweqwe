using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ses4DataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.ses4DataSet.User);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.userTableAdapter.InsertQuery(textBox1.Text,textBox2.Text);
            this.userTableAdapter.Fill(this.ses4DataSet.User);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.userTableAdapter.UpdateQuery((textBox1.Text, textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
