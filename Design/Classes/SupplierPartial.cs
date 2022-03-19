using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Classes
{
    public partial class Supplier
    {
        public string price_text => price.HasValue ? $"{Math.Round(price.Value, 5)} ₽" : "Не указана";

        public int advantages_count => advantages?.Split(';').Length ?? 0;
        public int disadvantages_count => disadvantages?.Split(';').Length ?? 0;

        public string advantages_fromat
        {
            get
            {
                var list = advantages?.Split(';').Select(x => x.Insert(0, "• ")).ToList();
                list.RemoveAt(advantages_count - 1);
                return (list.Count == 0 ? null : string.Join("\n", list)) ?? "Информация отсутствует";
            }

        }

        public string disadvantages_fromat
        {
            get
            {
                var list = disadvantages?.Split(';').Select(x => x.Insert(0, "• ")).ToList();
                list.RemoveAt(disadvantages_count - 1);
                return (list.Count == 0 ? null : string.Join("\n", list)) ?? "Информация отсутствует";
            }
        }

        public int tenders_count
        {
            get
            {
                var str = amount_sum_lots.Split(':')[1].Split(' ')[0];
                if (int.TryParse(str, out int result)){
                    return result;
                }
                return 0;
            }
        }
    }
}
