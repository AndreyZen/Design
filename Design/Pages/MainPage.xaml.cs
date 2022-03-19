using Design.Classes;
using Design.UserControls;
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
            DataObject.AddPastingHandler(TboxPriceDown, NoPaste);
            DataObject.AddPastingHandler(TboxPriceUp, NoPaste);
            DataObject.AddPastingHandler(TBoxSearch, NoPaste);
            //SearchTabControl.Items.Add(TabBuilder.CreateTab("ёоу я хедер", new List<Supplier>() { new Supplier() { company = "ёоу я компания"} }, TabHeader_CloseButtonClicked));
        }

        private void PropertyElement_Drop(object sender, DragEventArgs e)
        {
            var lvitem = (sender as ListViewItem);
            var index = LViewProperties.Items.IndexOf(lvitem);
            LViewProperties.Items.Remove(draggedItem);
            LViewProperties.Items.Insert(index, draggedItem);

        }

        private void PropertyElement_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                draggedItem = (sender as ListViewItem);
                var grid = draggedItem.Content as Grid;
                var text = (grid.Children[grid.Children.Count - 1] as TextBlock).Text;
                DragDrop.DoDragDrop(grid, text, DragDropEffects.Move);
            }
            catch { }
        }


        private async void TBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                if (!string.IsNullOrWhiteSpace(TBoxSearch.Text))
                {
                    (Application.Current.MainWindow as MainWindow).TBoxState.Text = "Busy";
                    await Task.Delay(1);
                    SearchTabControl.Items.Add(TabBuilder.CreateTab(TBoxSearch.Text, Parse(), TabHeader_CloseButtonClicked));
                    (Application.Current.MainWindow as MainWindow).TBoxState.Text = "Ready";
                }

            }
        }

        private void TabHeader_CloseButtonClicked(object sender, EventArgs e)
        {
            SearchTabControl.Items.Remove(sender as TabItem);
        }

        private List<Supplier> Parse()
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
            var lvItems = LViewProperties.Items;
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


            list = list.OrderBy(p => p.GetType().GetProperty(GetPropByID(properties[0])).GetValue(p)).
                ThenBy(p => p.GetType().GetProperty(GetPropByID(properties[1])).GetValue(p))
                .ThenBy(p => p.GetType().GetProperty(GetPropByID(properties[2])).GetValue(p))
                .ThenBy(p => p.GetType().GetProperty(GetPropByID(properties[3])).GetValue(p))
                .ThenBy(p => p.GetType().GetProperty(GetPropByID(properties[4])).GetValue(p))
                .ThenBy(p => p.GetType().GetProperty(GetPropByID(properties[5])).GetValue(p)).ToList();
            try
            {
                if (!string.IsNullOrWhiteSpace(TboxPriceUp.Text))
                    list = list.Where(x => x.price.HasValue ? (x.price.Value >= Convert.ToSingle(TboxPriceUp.Text)) : true).ToList();
                if (!string.IsNullOrWhiteSpace(TboxPriceDown.Text))
                    list = list.Where(x => x.price.HasValue ? x.price.Value <= Convert.ToSingle(TboxPriceDown.Text) : true).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка: Неправильное заполнение полей!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }


            return list;
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

        private void NoPaste(object sender, DataObjectPastingEventArgs e)
        {
            e.CancelCommand();
        }
    }
}
