using SQlite;
namespace DZ
{
    public partial class all_button : Form
    {
        SQlite.DataBase db = new DataBase();
        public all_button()
        {
            InitializeComponent();
            SQlite.DataBase.dgv = datagrid;
            db.Start();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            register app = new register();
            app.Show();
        }

        private void take_Click(object sender, EventArgs e)
        {
            int rowindex = datagrid.CurrentCell.RowIndex;
            int columnindex = datagrid.CurrentCell.ColumnIndex;

            db.Change_Count("-", datagrid.Rows[rowindex].Cells[2].Value.ToString(), datagrid.Rows[rowindex].Cells[4].Value.ToString());
            db.Refresh("0");
        }

        private void give_Click(object sender, EventArgs e)
        {
            int rowindex = datagrid.CurrentCell.RowIndex;
            int columnindex = datagrid.CurrentCell.ColumnIndex;
            db.Change_Count("+", datagrid.Rows[rowindex].Cells[2].Value.ToString(), datagrid.Rows[rowindex].Cells[4].Value.ToString());
            db.Refresh("0");
        }

        private void Count_Button_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            db.Refresh("1");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int rowindex = datagrid.CurrentCell.RowIndex;
            db.Delete(datagrid.Rows[rowindex].Cells[2].Value.ToString());
            db.Refresh("0");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Count_Button.Checked = false;
            db.Refresh("0");
        }
    }
}