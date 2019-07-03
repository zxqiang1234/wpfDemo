using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace Apptest1.page
{
    /// <summary>
    /// IndexPage.xaml 的交互逻辑
    /// </summary>
    public partial class IndexPage : Page
    {
        private List<DataItem> _data;
        public IndexPage()
        {
            InitializeComponent();
            //flexChart.Series.Clear();
            flexChart.AxisY.MajorGrid = true;
            flexChart.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            flexChart.AnimationSettings = C1.Chart.AnimationSettings.Load;
            flexChart.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            flexChart.AnimationLoad.Type = C1.Chart.AnimationType.Series;

        }
        public List<DataItem> Data
        {
            get
            {
                if (_data == null)
                {
                    _data = SeriesData.CreateData();
                }

                return _data;
            }
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
          
            string beginTime = BeginTime.SelectedDate.ToString().Substring(0,10);
            string endTime = EndTime.SelectedDate.ToString().Substring(0,10);
           flexChart.ItemsSource = SeriesData.CreateDataByTime(beginTime, endTime);
        }
    }
}
