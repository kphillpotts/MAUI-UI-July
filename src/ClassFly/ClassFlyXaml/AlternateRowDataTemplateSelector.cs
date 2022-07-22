using ClassFly.Core.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFlyXaml
{
    public class AlternateRowDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate EvenTemplate { get; set; }
        public DataTemplate UnevenTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            int index;
            var itemSource = ((CollectionView)container).ItemsSource;
            if (itemSource is IList list)
            {
                index = list.IndexOf(item);
            }
            else
            {
                index = ((IEnumerable<Object>)itemSource).ToList().IndexOf(item);
            }

            return index % 2 == 0 ? EvenTemplate : UnevenTemplate;
        }
    }
}
