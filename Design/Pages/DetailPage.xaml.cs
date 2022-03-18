using Design.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfCharts;

namespace Design.Pages
{
    /// <summary>
    /// Interaction logic for DetailPage.xaml
    /// </summary>
    public partial class DetailPage : Page
    {
        private readonly Random random = new Random(1234);
        public DetailPage(Supplier supplier)
        {
            InitializeComponent();
            GridDetail.DataContext = supplier;
            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs routedEventArgs)
        {
            Axes = new[] { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6", "Item 7" };
            ChartAnalytics.Axis = Axes;

            ChartAnalytics.Lines = new ObservableCollection<ChartLine> {
                                                            new ChartLine {
                                                                              LineColor = Colors.Red,
                                                                              FillColor = Color.FromArgb(128, 255, 0, 0),
                                                                              LineThickness = 2,
                                                                              PointDataSource = GenerateRandomDataSet(Axes.Length),
                                                                              Name = "Chart 1"
                                                                          },
                                                            new ChartLine {
                                                                              LineColor = Colors.Blue,
                                                                              FillColor = Color.FromArgb(128, 0, 0, 255),
                                                                              LineThickness = 2,
                                                                              PointDataSource = GenerateRandomDataSet(Axes.Length),
                                                                              Name = "Chart 2"
                                                                          }
                                                        };
        }
        public List<double> GenerateRandomDataSet(int nmbrOfPoints)
        {
            var pts = new List<double>(nmbrOfPoints);
            for (var i = 0; i < nmbrOfPoints; i++)
            {
                pts.Add(random.NextDouble());
            }
            return pts;
        }

        public string[] Axes { get; set; }
        public ObservableCollection<ChartLine> Lines { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppData.MainFrame.GoBack();
        }
    }
}
