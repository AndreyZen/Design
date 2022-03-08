using Design.Classes;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Design.Pages
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private ListViewItem draggedItem;
        private List<int> properties = new List<int>();
        public MainPage()
        {
            InitializeComponent();
            List<Supplier> suppliers = new List<Supplier>();
            suppliers.Add(new Supplier
            {
                price = 14877207.31F,
                amount = "Количество не указано",
                date_publish = "28.02.2022 12:28",
                company = "ООО САЛАИР - Тестовый показ",
                inn = "7715857460",
                ogrn = "1117746211197",
                kpp = "770201001",
                okpo = "90648710",
                register_date = "22 марта 2011 года",
                rating = 342,
                address = "129110, г. Москва, ул. Щепкина, д. 42, стр. 2А, эт/пом/ком 8/1/1",
                kapital = "1 000 000 руб.",
                fin_info = "Выручка:выросла до5,5 млрд руб.34%",
                advantages = "Долгое время работы; Большой уставный капитал; Не входит в реестр недобросовестных поставщиков; Нет связей с дисквалифицированными лицами; Нет массовых руководителей и учредителей; Нет сообщений о банкротстве; Прибыль в прошлом отчетном периоде; Уплачены налоги за прошлый отчетный период; Нет долгов по исполнительным производствам; Высокая среднесписочная численность работников;",
                phone = null,
                email = "koreneva7@mail.ru",
                web_site = null
            });
            LvItems.ItemsSource = suppliers;
        }

        private void Lv_Drop(object sender, DragEventArgs e)
        {
            var lvitem = (sender as ListViewItem);
            var index = Lv.Items.IndexOf(lvitem);
            Lv.Items.Remove(draggedItem);
            Lv.Items.Insert(index, draggedItem);

        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var grid = (sender as Grid);
            draggedItem = grid.Parent as ListViewItem;
            var text = (grid.Children[grid.Children.Count - 1] as TextBlock).Text;
            DragDrop.DoDragDrop(grid, text, DragDropEffects.Move);
            
        }

        private void Lv_Selected(object sender, RoutedEventArgs e)
        {
            var sup = LvItems.SelectedItem as Supplier;
            if(sup != null)
                AppData.MainFrame.Navigate(new DetailPage(sup));
            LvItems.SelectedItem = null;
        }


        private void TBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {

                string text = TBoxSearch.Text.Replace(" ", "+");

                ScriptEngine engine = Python.CreateEngine();
                ScriptScope scope = engine.CreateScope();
                ICollection<string> searchPaths = engine.GetSearchPaths();
                searchPaths.Add("Python34\\Lib");
                searchPaths.Add("venv\\Lib");
                searchPaths.Add("venv\\Lib\\site-packages");
                engine.SetSearchPaths(searchPaths);
                engine.ExecuteFile("main.py", scope);
                dynamic square = scope.GetVariable("main");
                // вызываем функцию и получаем результат
                dynamic result = square(text);

                properties.Clear();
                var lvItems = Lv.Items;
                for (int i = 0; i < lvItems.Count; i++)
                {
                    ListViewItem item = lvItems[i] as ListViewItem;
                    var elements = (item.Content as Grid).Children;
                    var id = int.Parse((elements[elements.Count - 1] as TextBlock).Text);
                    properties.Add(id);
                }
                List<Supplier> list = new List<Supplier>();
                var companies = File.ReadAllText("company.json");
                list = JsonConvert.DeserializeObject<List<Supplier>>(companies);
                LvItems.ItemsSource = list.OrderBy(p => p.GetType().GetProperty(GetPropByID(properties[0])).GetValue(p)).
                    ThenBy(p => p.GetType().GetProperty(GetPropByID(properties[1])).GetValue(p))
                    .ThenBy(p => p.GetType().GetProperty(GetPropByID(properties[2])).GetValue(p))
                    .ThenBy(p => p.GetType().GetProperty(GetPropByID(properties[3])).GetValue(p))
                    .ThenBy(p => p.GetType().GetProperty(GetPropByID(properties[4])).GetValue(p))
                    .ThenBy(p => p.GetType().GetProperty(GetPropByID(properties[5])).GetValue(p)).ToList();

            }
        }
        private string GetPropByID(int id)
        {
            switch (id)
            {
                case 0:
                    return "price";
                case 1:
                    return "register_date";
                case 2:
                    return "rating";
                case 3:
                    return "fin_info";
                case 4:
                    return "advantages_count";
                case 5:
                    return "disadvantages_count";
                default:
                    break;
            }
            return "";
        }
    }
}
