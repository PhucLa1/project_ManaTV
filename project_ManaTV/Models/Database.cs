using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace project_ManaTV.Models
{
    internal class Database
    {
        string connectionString = $"Server={ConfigurationManager.AppSettings["SERVER"]};" +
           $"Database={ConfigurationManager.AppSettings["DATABASE"]};" +
           $"Integrated Security={ConfigurationManager.AppSettings["Integrated_Security"]};";
        //string connectionString = $"Server={config.SERVER};Database={config.DATABASE};Integrated Security={config.Integrated_Security};";
        SqlConnection con;
        private SqlCommand command;
        private SqlDataReader reader;

        public Database()
        {
            con = new SqlConnection();
            con.ConnectionString = connectionString;
            command = new SqlCommand();
            command.Connection = con;
            con.Open();

        }



        public void Disconnect()
        {
            if (con.State == ConnectionState.Open) 
            {
                con.Close(); 
                con.Dispose(); 
            }
        }

        //Dung de lay cau truy van 
        public void SetQuery(string sql)
        {
            this.command.CommandText = sql;
        }
        private List<string> getValueOfQuery()
        {
            List<string> result = new List<string>();
            MatchCollection matches = Regex.Matches(command.CommandText, @"\@\w+");

            foreach (Match match in matches)
            {
                string parameterName = match.Value;
                result.Add(parameterName);
            }
            return result;
        }

        //Dung de danh cho nhung cau lenh update,insert
        public SqlDataReader Excute(params object[] parameters)
        {
            if (reader != null && !reader.IsClosed)
            {
                reader.Close();
            }
            if (parameters != null)
                {
                    List<string> res = getValueOfQuery();
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        command.Parameters.AddWithValue(res[i], parameters[i]);
                    }
                }
                reader = command.ExecuteReader();
                command.Parameters.Clear();
                return reader;
        }

        //Lay nhieu dong du lieu

        public List<Dictionary<string,object>> LoadAllRows(params object[] parameters)
        {
            List<Dictionary<string, object>> res = new List<Dictionary<string, object>> { };
            if (reader != null && !reader.IsClosed)
            {
                reader.Close();
            }
            using (reader = Excute(parameters)) 
            {
                while (reader.Read())
                {
                    Dictionary<string, object> row = new Dictionary<string, object>();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row[reader.GetName(i)] = reader.GetValue(i);
                    }
                    res.Add(row);
                }
            }
            return res;
        }

        public Dictionary<string,object> LoadRow(params object[] parameters)
        {
            if (reader != null && !reader.IsClosed)
            {
                reader.Close();
            }
            Dictionary<string,object> res = new Dictionary<string,object>();
            using (SqlDataReader reader = Excute(parameters))
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        res[reader.GetName(i)] = reader.GetValue(i);
                    }
                }
            }
            return res;
        }


        //Thêm hàm thêm, sửa, xóa
        //Sửa : Sp.Table("Work").Update("")
        //Xóa : 
        //Thêm : 
        //Lấy ra toàn bộ : 
        //Lấy theo id :   
        //Bây giờ muốn : Sp.Table("work").Add("1,1,null,null,1,1");

    }
}
