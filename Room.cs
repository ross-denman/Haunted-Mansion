using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Haunted_Mansion.ProgramUI;

namespace Haunted_Mansion
{
    public class Room
    {
        public string RoomDesc { get; set; }
        public List<Item> Items { get; set; }
        public List<string> Exits { get; set; }
        //public string Events { get; set; }
        public Room(string roomDesc, List<Item> items, List<string> exits)
        {
            RoomDesc = roomDesc;
            Items = items;
            Exits = exits;
        }
    }
}