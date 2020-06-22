using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsbActioner.Extensions
{
    public static class Extensions
    {
        public static void Sync(this ListView list, IEnumerable<ListViewItem> items)
        {
            IEnumerable<ListViewItem> toAdd = items.Where(n => !list.Items.ContainsKey(n.Name));
            IEnumerable<ListViewItem> toRemove = list.Items.Cast<ListViewItem>().Where(n => !items.Any(m => m.Name == n.Name));

            if(toRemove.Any())
                foreach(var r in toRemove)
                    list.Items.Remove(r);

            if(toAdd.Any())
                list.Items.AddRange(toAdd.ToArray());
        }
    }
}
