using Design.Classes;
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

namespace Design.Pages
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            List<Supplier> suppliers = new List<Supplier>();
            suppliers.Add(new Supplier
            {
                price = 14877207.31F,
                amount = "Количество не указано",
                date_publish = "28.02.2022 12:28",
                company = "ООО САЛАИР",
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
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Lv_Selected(object sender, RoutedEventArgs e)
        {
        }
    }
}
