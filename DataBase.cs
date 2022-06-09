using System.Data.SQLite;
using System.Data;

namespace SQlite
{
    public partial class DataBase
    {
        public static DataGridView dgv = new DataGridView();
        private static SQLiteDataAdapter da = new SQLiteDataAdapter();
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        private SQLiteConnection sqlite_conn = new SQLiteConnection();
        public void Start()
        {
            sqlite_conn = CreateConnection();
            CreateTable(sqlite_conn);
            DisplayTable(sqlite_conn, "0");
        }
        public void Refresh(string form)
        {
            sqlite_conn = CreateConnection();
            DisplayTable(sqlite_conn, form);
        }
        public void Create(string udk, string author, string name, string year, string count)
        {
            sqlite_conn = CreateConnection();
            Add(sqlite_conn, udk, author, name, year, count);
        }
        public void Change_Count(string value, string id, string count)
        {
            sqlite_conn = CreateConnection();
            if ((value == "+") && (Int32.Parse(count) >= 0))
                Change(sqlite_conn, value,id);
            if ((value == "-") && (Int32.Parse(count) >= 1))
                Change(sqlite_conn, value,id);
        }
        public void Delete(string id)
        {
            sqlite_conn = CreateConnection();
            DeleteBook(sqlite_conn, id);
        }
        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection("Data Source=database.db; Version = 3; New = True; Compress = True; ");
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception)
            {

            }
            return sqlite_conn;
        }

        private void CreateTable(SQLiteConnection conn)
        {
                SQLiteCommand sqlite_cmd;
                string Createsql = "create table if not exists Books(UDK VARCHAR(6)," +
                                                                    "Contacts VARCHAR(100)," +
                                                                    "Name VARCHAR(1000) UNIQUE," +
                                                                    "Year VARCHAR(4)," +
                                                                    "Count VARCHAR(100))";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = Createsql;
                sqlite_cmd.ExecuteNonQuery();
        }
        private void DisplayTable(SQLiteConnection conn, string form)
        {
            string sql = "";
            if ( form == "0")
                sql = ("SELECT * FROM Books");
            if (form == "1")
                sql = ("SELECT * FROM Books WHERE COUNT > 0");
            da = new SQLiteDataAdapter(sql, conn);
            ds.Reset(); da.Fill(ds);
            dt = ds.Tables[0];
            dgv.DataSource = dt;
        }
        private void Add(SQLiteConnection conn, string udk, string author, string name, string year, string count)
        {
            try
            {
                SQLiteCommand sqlite_cmd;
                string sql = "INSERT INTO Books (UDK, Contacts, Name, Year, Count) " +
                    $"VALUES ('{udk}','{author}','{name}','{year}','{count}')";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = sql;
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Change(SQLiteConnection conn, string value, string id)
        {
            SQLiteCommand sqlite_cmd;
            string? sql;
            switch (value)
            {
                case "+":
                    sql = $"UPDATE Books SET count = count + 1 WHERE name ='{id}'";
                    break;
                case "-":
                    sql = $"UPDATE Books SET count = count - 1 WHERE name ='{id}'";
                    break;
                default:
                    sql = null;
                    break;
            }
            if (sql != null)
            {
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = sql;
                sqlite_cmd.ExecuteNonQuery();
            }
        }
        private void DeleteBook(SQLiteConnection conn, string id)
        {
            SQLiteCommand sqlite_cmd;
            string sql = $"DELETE FROM Books WHERE name ='{id}'";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = sql;
            sqlite_cmd.ExecuteNonQuery();
        }
    }
}