using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Apptest1
{
    /// <summary>
    /// Echart.xaml 的交互逻辑
    /// </summary>
    public partial class Echart : Window
    {
      static  string _sqlAddres = SqlHelp.GetConnectionStringsConfig("DownloadPath");
        public Echart()
        {
            InitializeComponent();
        }




        public SQLiteDataReader getSQLiteDataReader(string constr,string sql) {
            //创建连接对象
            SQLiteConnection con = new SQLiteConnection(constr);
            //创建命令对象
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            con.Open();
            try
            {
                SQLiteDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception e) {
                MessageBox.Show("账号密码错误" + e);
            }
            finally {
                con.Close();
                cmd = null;
                con.Dispose();
            }
            return null;
        }


        private void TabItem_MouseMove_1(object sender, MouseEventArgs e)
        {
            //var part_text= this.LeftTabControl.Template.FindName("PART_Text", this.LeftTabControl);
            //null
        }

        private void LeftTabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
            var tabselect = (TabControl)sender;
            var item = ((TabItem)tabselect.SelectedItem).Tag;
            this.pageContainer.Source = new Uri("page/"+ item+".xaml", UriKind.RelativeOrAbsolute);
        }

        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            var eventArg = new MouseWheelEventArgs(e.MouseDevice, e.Timestamp, e.Delta);
            eventArg.RoutedEvent = UIElement.MouseWheelEvent;
            eventArg.Source = sender;
            scrollViewer.RaiseEvent(eventArg);

        }
    }
}
