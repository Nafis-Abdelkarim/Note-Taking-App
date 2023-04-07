using System.Data;

namespace Note_Taking_App
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //instance the datatable and adding columns
            table = new DataTable();
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Note", typeof(string));

            dataGridView.DataSource = table;
            dataGridView.Columns["Title"].Width = 94;
            dataGridView.Columns["Note"].Width = 94;

        }

        //The clear function 
        private void clear_Click(object sender, EventArgs e)
        {
            titleBox.Clear();
            noteBox.Clear();
        }

        //The save function
        private void save_Click(object sender, EventArgs e)
        {
            table.Rows.Add(titleBox.Text, noteBox.Text);

            titleBox.Clear();
            noteBox.Clear();
        }

        //The read function
        private void read_Click(object sender, EventArgs e)
        {
            int index = dataGridView.CurrentCell.RowIndex;

            if (index > -1)
            {
                titleBox.Text = table.Rows[index].ItemArray[0].ToString();
                noteBox.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        //The delete function 
        private void delete_Click(object sender, EventArgs e)
        {
            int index = dataGridView.CurrentCell.RowIndex;

            table.Rows[index].Delete();
        }
    }
}