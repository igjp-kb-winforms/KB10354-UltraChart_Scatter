using Infragistics.UltraChart.Shared.Styles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltraChart_Scatter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ultraChart1.ChartType = ChartType.ScatterChart;

            BindingList<DataPoint> list = new BindingList<DataPoint>();
            list.Add(new DataPoint() { Name = "テスト1", Value1 = 4, Value2 = 5 });
            list.Add(new DataPoint() { Name = "テスト2", Value1 = 4, Value2 = 7 });
            list.Add(new DataPoint() { Name = "テスト3", Value1 = 7, Value2 = 4 });
            list.Add(new DataPoint() { Name = "テスト4", Value1 = 2, Value2 = 6 });
            list.Add(new DataPoint() { Name = "テスト5", Value1 = 3, Value2 = 2 });

            ultraChart1.ScatterChart.ColumnX = 1;
            ultraChart1.ScatterChart.ColumnY = 2;

            ultraChart1.DataSource = list;
            ultraChart1.DataBind();
        }

        public class DataPoint
        {
            public string Name { get; set; }
            public int Value1 { get; set; }
            public int Value2 { get; set; }
        }
    }
}
