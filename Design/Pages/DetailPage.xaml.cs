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
        private List<Supplier> _suppliers = new List<Supplier>();
        private Supplier _supplier;
        public DetailPage(Supplier supplier, List<Supplier> suppliers)
        {
            InitializeComponent();
            GridDetail.DataContext = supplier;
            _supplier = supplier;
            _suppliers = suppliers;
            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs routedEventArgs)
        {
            Axes = new[] { "Цена", "Количество тендеров", "Выручка", "Успешность" };
            ChartAnalytics.Axis = Axes;

            ChartAnalytics.Lines = new ObservableCollection<ChartLine> {
                                                            new ChartLine {
                                                                              LineColor = Colors.Red,
                                                                              FillColor = Color.FromArgb(128, 255, 0, 0),
                                                                              LineThickness = 2,
                                                                              PointDataSource = new List<double> { (double)_suppliers.Average(x => x.price ?? 0) / _suppliers.Max(x => x.price.HasValue ? x.price.Value : 1),
                                                                              (double)_suppliers.Average(x => x.tenders_count) / ((double)_suppliers.Max(x => x.tenders_count != 0 ? x.tenders_count : 1)),
                                                                                  1,
                                                                                  1 },
                                                                              Name = "Среднее значение"
                                                                          },
                                                            new ChartLine {
                                                                              LineColor = Colors.Blue,
                                                                              FillColor = Color.FromArgb(128, 0, 0, 255),
                                                                              LineThickness = 2,
                                                                              PointDataSource = new List<double> { 
                                                                                  (double)(_supplier.price ?? 0.0) / _suppliers.Max(x => x.price.HasValue ? x.price.Value : 1),
                                                                                  (double)_supplier.tenders_count / ((double)_suppliers.Max(x => x.tenders_count != 0 ? x.tenders_count : 1)),
                                                                                  1,
                                                                                  1 },
                                                                              Name = "Значение поставщика"
                                                                          }
                                                        };
        }

        public string[] Axes { get; set; }
        public ObservableCollection<ChartLine> Lines { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppData.MainFrame.GoBack();
        }
    }
}
