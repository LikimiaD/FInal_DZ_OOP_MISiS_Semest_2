using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQlite;

namespace DZ
{
    public partial class register : Form
    {
        SQlite.DataBase db = new DataBase();
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((udk.Text.Length > 6) || (int.TryParse(udk.Text, out int numericValue)))
                if ((author.Text.Length != 0) && (name.Text.Length != 0))
                    if ((year.Text.Length > 4) || (int.TryParse(year.Text, out int numericValue1)))
                        if ((year.Text.Length > 4) || (int.TryParse(count.Text, out int numericValue2)))
                        {
                            db.Create(udk.Text, author.Text, name.Text, year.Text, count.Text);
                            db.Refresh("0");
                            this.Close();
                        }
                        else
                            MessageBox.Show("Количество должен соддержать набор цифр");
                    else
                    MessageBox.Show("Год должен соддержать набор цифр до 4 символов");
                else
                    MessageBox.Show("Поле ФИО или Название литературы не могут быть пустыми");
            else
                MessageBox.Show("УДК должен соддержать набор цифр до 6 символов");
        }
    }
}
