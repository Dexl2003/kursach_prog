
using System.Collections;
using System.Data;

namespace kursach_prog
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            List <String[]> list_string = DataBaseConnector.ExecuteQuery(4);

            dataGridView1.Columns.Add("id","�������");
            dataGridView1.Columns.Add("name", "��������");
            dataGridView1.Columns.Add("quantity", "����������");
            dataGridView1.Columns.Add("price", "����");

            //dataGridView1.DataSource = list_string.Select(x => new { Value = x }).ToList();
            for (int i = 0; i < list_string.Count; i++)
            { 
                dataGridView1.Rows.Add(list_string[i]);
            }

            







        }



        

       

        private void top_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e){}

        

        private void sale_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e){}

        private void fullList_CheckedChanged(object sender, EventArgs e) 
        {
            
        }

        private void from_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void before_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}