using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Wpf;
namespace AnakKost.View
{
    /// <summary>
    /// Interaction logic for Grafic.xaml
    /// </summary>
    public partial class Grafic : UserControl
    {
        private Controller.GraficController controller;
       
        //private Model.MainPageModel modelmainpage;

        bool hasil;

        public void Tampildata()
        {
            controller.Selectdatagrafic();
            
           
        }
   
        public Grafic()
        {
            InitializeComponent();
            controller = new Controller.GraficController(this);
            
            Tampildata();
   
            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Pengeluaran",
                    Values = new ChartValues<double> {10000,20000,35000,8000,1000, 2000, 3000 }
                },
             

            };

            Labels = new[] { "Senin", "Selasa", "Rabu", "Kamis", "Jum'at","Sabtu","Ahad" };
            YFormatter = value => value + (" IDR");

            //modifying the series collection will animate and update the chart
           

            //modifying any series values will also animate and update the chart
        

            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }
        }
    }


