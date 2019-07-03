using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Windows;

namespace Apptest1
{
    class SeriesData
    {

        public static List<DataItem> CreateData()
        {
            //var data = new List<DataItem>();

            string sql = "select * from imp_user where julianday(createTime) >= julianday('"+ DateTime.Now .AddDays(-7)+ "')  and  julianday(createTime)<=julianday('"+ DateTime.Now+ "')";
            SQLiteConnection con = new SQLiteConnection(SqlHelp.GetConnectionStringsConfig(""));
            //创建命令对象
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            con.Open();
            SQLiteDataReader reader = cmd.ExecuteReader();

            var chart1Data = new List<DataItem>();
            try
            {
                if (reader.HasRows)
                {


                    DataItem user = null;
                    while (reader.Read())
                    {
                        user = new DataItem(Convert.ToDateTime(reader["createTime"].ToString()), Convert.ToInt16(reader["age"].ToString()));

                        chart1Data.Add(user);
                    }

                }

            }
            catch (Exception ss)
            {
                MessageBox.Show("" + ss);


            }
            finally
            {
                con.Close();
                cmd = null;
                con.Dispose();
            }
            return chart1Data;
        }

        public static List<DataItem> CreateDataByTime(string beginTime,string endTime)
        {
            string sql = "select * from imp_user where julianday(createTime) >= julianday('" + beginTime + "')  and  julianday(createTime)<=julianday('" + endTime + "')";
            SQLiteConnection con = new SQLiteConnection(SqlHelp.GetConnectionStringsConfig(""));
            //创建命令对象
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            con.Open();
            SQLiteDataReader reader = cmd.ExecuteReader();

            var chart1Data = new List<DataItem>();
            try
            {
                if (reader.HasRows)
                {


                    DataItem user = null;
                    while (reader.Read())
                    {
                        user = new DataItem(DateTime.Parse(reader["createTime"].ToString()), Convert.ToInt16(reader["age"].ToString()));
                        chart1Data.Add(user);
                    }

                }

            }
            catch (Exception ss)
            {
                MessageBox.Show("" + ss);


            }
            finally
            {
                con.Close();
                cmd = null;
                con.Dispose();
            }
            return chart1Data;
        }

    }
    public class DataItem
    {
        public DataItem(DateTime dataTime, int wd)
        {
            DataTime = dataTime;
            Wd = wd;
        }

        public DateTime DataTime { get; set; }
        public int Wd { get; set; }
    }
}
