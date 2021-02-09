using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Haunted_Mansion.ProgramUI;

namespace Haunted_Mansion
{
    public class Rooms
    {
        public string RoomDesc { get; }
        public List<string> Exits { get; }
        public List<CharItem> CharItems { get; }
        public string <Actions> actions { get; }
        public Lists<RoomItems> Items { get; }

        // Room constructor
        // Room Description
        // Exits
        // Char Items - can be added to inventory
        // Action/Event flags in rooms
        // Room Items - can be examined for clues
        public Rooms(string roomDesc, List<string> exits, List<CharItem> charItems, List<Actions> actions, List<RoomItems> roomItems)
        {
            RoomDesc = roomDesc;
            Exits = exits;
            CharItems = charItems;
            Actions = actions;
            RoomItems = roomItems;
        }

        // Get item from room
        public void RemoveItem(Item item)
        {
            if (Items.Contains(item))
            {
                Items.Remove(item);
                //Add item to inventory
            }
        }
        public void Actions(Action Activity);
        {
            if (Actions.Contains(Activity))
            {
                Events.Remove(Activity)
    }
}
    }
}
