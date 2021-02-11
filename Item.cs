using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haunted_Mansion
{
    public class Item
    {
        public string Name { get; set; }
        public string ShortDesc { get; set; }
        public string LongDesc { get; set; }
        public bool CharItem { get; set; }
        public bool Container { get; set; }
        public string Output { get; set; }
        public Item(string name, string shortDesc, string longDesc, bool charItem, bool container, string output)
        {
            Name = name;
            ShortDesc = shortDesc;
            LongDesc = longDesc;
            CharItem = charItem;
            Container = container;
            Output = output;
        }
    }
}
