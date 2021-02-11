using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Drawing;

namespace Haunted_Mansion
{
    public class ProgramUI
    {   //ITEMS
        public static Item frontDoor = new Item(
            "FRONT DOOR",
            "There is a FRONT DOOR that leads outside to the North",
            "This large, oak entry door is locked and will need a key to open",
            false,
            false,
            "This large, oak door is locked");
        public static Item footprints = new Item(
            "FOOTPRINTS",
            "There are muddy FOOTPRINTS on the floor",
            "These are the largest FOOTPRINTS that you've ever seen. You do not want to get kicked by the wearer of these shoes!",
            false,
            false,
            "You cannot do anything with these");
        public static Item coatCloset = new Item(
            "COAT CLOSET",
            "There is a COAT CLOSET in the Corner",
            "The COAT CLOSET is empty.",
            true,
            false,
            "How do you plan on using the COAT CLOSET?");
        public static Item window2 = new Item(
           "WINDOW",
           "You see a WINDOW on the West wall",
           "You look out the WINDOW overlooking a large hedge maze",
           false,
           false,
           "The window is jammed");
        public static Item window1 = new Item(
           "WINDOW",
           "You see a WINDOW on the North wall",
           "You look out the WINDOW in to the front yard and see two large dogs... oops... make that wolves!",
           false,
           false,
           "The window is jammed");
        public static Item cabinets = new Item(
            "CABINETS",
           "You see CABINETS on both sides of the SINK",
           "You look in the CABINETS and find them empty, but riddled with mold!",
           true,
           false,
           "Use the CABINETS for what exactly?");
        public static Item drawers = new Item(
           "DRAWERS",
           "You see several DRAWERS under the SINK",
           "You see a rusty KNIFE in the drawer",
           true,
           false,
           "You amuse yourself by opening and shutting the DRAWERS rapidly");
        public static Item sink = new Item(
            "SINK",
           "You see an old stainless SINK",
           "The SINK is covered in rust and mold",
           false,
           false,
           "You turn on the faucet, but it appears that water is shut off");
        public static Item counterTop = new Item(
            "COUNTERTOP",
           "You see an cracked granite COUNTERTOP",
           "The COUNTERTOP is covered in blood, but there is some rotted MEAT here",
           false,
           false,
           "Were you planning on prepping some food?");
        public static Item knife = new Item(
            "KNIFE",
            "You find a KNIFE in one of the drawers ",
            "This KNIFE seems pretty old, but it' still sharp",
            true,
            false,
            "You added the KNIFE to your inventory");
        public static Item meat = new Item(
            "MEAT",
            "You see several pieces of MEAT",
            "This rotted MEAT smells terrible, but may be good for something",
            true,
            false,
            "You added the rotted MEAT to your inventory");
        public static Item bed = new Item(
            "BED",
            "You see a luxurious BED in the middle of the room",
            "This large BED has a solid oak frame and looks very comfy",
            false,
            false,
            "You think about taking a nap, but decide that it may not be in your best interest.");
        public static Item bookshelf = new Item(
            "BOOKSHELF",
            "You see a large BOOKSHELF on the East wall",
            "This bookshelf has several books that seem to be written in an odd language.",
            false,
            false,
            "The books crumble in your hands as you attempt to move them.");
        public static Item painting = new Item(
            "PAINTING",
            "You see an old PAINTING on the West wall",
            "This is a PAINTING of an large manor. You wonder if it's a picture of this place.",
            false,
            false,
            "You adjust the PAINTING and a trap door opens in the middle of the floor.");
        public static Item diningRoomTable = new Item(
            "DINING ROOM TABLE",
            "You see a DINING ROOM TABLE sitting in the middle of the room.",
            "This square-shaped DINNING ROOM TABLE is big enough to sit 12 people.",
            false,
            false,
            "You have nothing to eat.");
        public static Item wineCabinet = new Item(
            "WINE CABINET",
            "You see a WINE CABINET on the Eastern wall",
            "The WINE CABINET has glass doors and you can see an unopened bottle of WINE inside.",
            true,
            false,
            "You open the WINE CABINET to find a bottle of WINE.");
        public static Item wine = new Item(
            "WINE",
            "You see an unopend bottle of WINE in the cabinet.",
            "This bottle of Merlot is dated 1862. I wonder if it's still good.",
            true,
            false,
            "You add the WINE to your inventory.");
        public static Item corkscrew = new Item(
            "CORKSCREW",
            "You see a CORKSCREW sitting on the bottom step.",
            "This CORKSCREW still seems usable.",
            true,
            false,
            "You add the CORKSCREW to your inventory.");
        public static Item fireplace = new Item(
            "FIREPLACE",
            "There is a FIREPLACE on the South Wall",
            "This is a large, gothic FIREPLACE. There appears to be dry wood inside",
            false,
            false,
            "You need something to start a fire.");
        public static Item mirror = new Item(
            "MIRROR",
            "You see a large MIRROR above the fireplace",
            "You see handprints smudged on the MIRROR and as you look closer, you see a figure dash across the room behind you in your reflection.",
            false,
            false,
            "You say 'MIRROR, MIRROR on the wall' but nothing happens.");
        public static Item toilet = new Item(
            "TOILET",
            "You see a small TOILET on the South wall.",
            "The TOILET is filled with... do you really need a description? The water appears to be off.",
            false,
            false,
            "Do you really need to get that badly?");
        public static Item pedestalSink = new Item(
            "PEDESTAL SINK",
            "You see a small PEDESTAL SINK on the East wall.",
            "The PEDESTAL SINK is made of marble with antique brass handles and faucet. The inside of the PEDESTAL SINK is moldy.",
            false,
            false,
            "You turn the handles but nothing happens");
        public static Item bathroomMirror = new Item(
            "BATHROOM MIRROR",
            "There is a small BATHROOM MIRROR above the PEDESTAL SINK.",
            "There appears to be specks of blood on the BATHROOM MIRROR.",
            false,
            false,
            "You look at your reflection in the BATHROOM MIRROR and notice that you have a big pimple on your nose.");
        public static Item bathtub = new Item(
            "BATHTUB",
            "There is an old cast iron BATHTUB against the North Wall",
            "This gothic style BATHTUB has claw feet and most of the glazing has eroded. The faucet handles are broken.",
            false,
            false,
            "While you certainly need a shower, you should probably try to get out of here first!");
        public static Item skeletonKey = new Item(
            "SKELETON KEY",
            "You see an old SKELETON KEY on the floor",
            "You've never seen a key like this... I wonder what it goes to",
            true,
            false,
            "You add the SKELETON KEY to your inventory.");

        // ROOMS
        public static Room frontEntrance = new Room(
            "This is the FRONT ENTRANCE. There are muddy FOOTPRINTS on the floor near the FRONT DOOR.",
            new List<Item> { frontDoor, footprints, coatCloset, window2 },
            new List<string> { "HALLWAY", "to the East" }
            );
        public static Room hallway = new Room(
            "\nYou are in a T-shaped HALLWAY.",
            new List<Item> { window1 },
            new List<string> { "FRONT ENTRANCE", "to the West", "KITCHEN", "to the East", "LIVING ROOM", "to the South" });
        public static Room kitchen = new Room(
           "You find yourself in the KITCHEN. The walls and floors are lined with worn and broken tiles. On the east wall you see CABINETS and DRAWERS on either side of the SINK and COUNTER TOP.",
            new List<Item> { cabinets, drawers, sink, counterTop, knife, meat },
            new List<string> { "HALLWAY", "to the West", "DINING ROOM", "to the South" });
        public static Room guestBedroom = new Room(
            "This appears to be the GUEST BEDROOM. A luxurious BED is in the middle of the room with a BOOKSHELF on the Eastern wall and a WINDOW looking out the West Wall.",
            new List<Item> { bed, bookshelf, window2 },
            new List<string> { "DOWNSTAIRS LANDING", "to the south" });
        public static Room livingRoom = new Room(
            "This is the LIVING ROOM. The walls are lind the the same wallpaper as the Great Room... Ewww...who decorated this place.",
            new List<Item> { painting },
            new List<string> { "GREAT ROOM", "to the South", "HALLWAY", "to the North" });
        public static Room diningRoom = new Room(
            " In the middle of this formal DINING ROOM is a large oak DINING ROOM TABLE. An unopened WINE BOTTLE sits in the wine cabinet",
            new List<Item> { diningRoomTable, wineCabinet, wine },
            new List<string> { "KITCHEN", "to the North", "GUEST BATHROOM", "to the South" });
        public static Room downstairsLanding = new Room(
            "You are at the DOWNSTAIRS LANDING at the bottom of a winding staircase leading upwards.",
            new List<Item> { corkscrew },
            new List<string> { "GREAT ROOM", "can be accessed East", "GUEST BEDROOM", "to the North", "UPSTAIRS LAINDING", "up the staircase" });
        public static Room greatRoom = new Room(
            "This is the GREAT ROOM. The walls are lined with worn, antique wallpaper and the hardwood floors are stained with blood.",
            new List<Item> { fireplace, mirror },
            new List<string> { "LIVING ROOM", "to the North", "DOWNSTAIRS LANDING", "to the West", "GUEST BATHROOM", "to the East" });
        public static Room guestBathroom = new Room(
            "This is the GUEST BATRHOM. You see a TOILET on the South wall and a PEDESTAL SINK and BATHROOM MIRROR",
            new List<Item> { toilet, pedestalSink, bathroomMirror },
            new List<string> { "GREAT ROOM", "to the West", "DINING ROOM", "to the North" });
        public static Room upstairsLanding = new Room(
            "This is the UPSTAIRS LANDING. There are stairs leading back down to the lower level and an open door leads EAST to a large bedroom.",
            new List<Item> { },
            new List<string> { "DDWNSTAIRS LANDING", "down the stairs", "MASTER BEDROOM", "to the East" });
        public static Room masterBedroom = new Room(
            "This is the MASTER BEDROOM. An open door leads NORTH to a large MASTER BATHROOM and West leads to the UPSTAIRS LANDING. You see a large BED in the middle of the room.",
            new List<Item> { bed },
            new List<string> {"MASTER BATHROOM", "can be seen at the North wall.", "UPSTAIRS lANDING", "through the West doorway." });
        public static Room masterBathroom = new Room(
            "This is the Master Bathroom. There is an old cast iron BATHTUB and a hole in floor where the toilet and sink used to be. You also see an old SKELETON KEY on the floor. An open door leads SOUTH back to the Master Bedroom.",
            new List<Item> { bathtub, skeletonKey },
            new List<string> { "MASTER BEDROOM", "to the South through the door."}
            );

        public Dictionary<string, Room> RoomDictionary = new Dictionary<string, Room>
        {
            {"FRONT ENTRANCE" , frontEntrance },
            {"HALLWAY", hallway },
            {"KITCHEN", kitchen },
            {"GUEST BEDROOM", guestBedroom },
            {"LIVING ROOM", livingRoom },
            {"DINING ROOM", diningRoom },
            {"DOWNSTAIRS LANDING", downstairsLanding },
            {"GREAT ROOM", greatRoom },
            {"GUEST BATHROOM", guestBathroom }
        };

        public List<Item> inventory = new List<Item>();

        public void Run()
        {
            Room currentRoom = greatRoom;
            bool adventure = true;

                        Console.Clear();
                        //Title Screen
                        Console.WriteLine(@"


                        ██░ ██  ▄▄▄       █    ██  ███▄    █ ▄▄▄█████▓▓█████ ▓█████▄     ███▄ ▄███▓ ▄▄▄       ███▄    █   ██████  ██▓ ▒█████   ███▄    █ 
                        ▓██░ ██▒▒████▄     ██  ▓██▒ ██ ▀█   █ ▓  ██▒ ▓▒▓█   ▀ ▒██▀ ██▌   ▓██▒▀█▀ ██▒▒████▄     ██ ▀█   █ ▒██    ▒ ▓██▒▒██▒  ██▒ ██ ▀█   █ 
                        ▒██▀▀██░▒██  ▀█▄  ▓██  ▒██░▓██  ▀█ ██▒▒ ▓██░ ▒░▒███   ░██   █▌   ▓██    ▓██░▒██  ▀█▄  ▓██  ▀█ ██▒░ ▓██▄   ▒██▒▒██░  ██▒▓██  ▀█ ██▒
                        ░▓█ ░██ ░██▄▄▄▄██ ▓▓█  ░██░▓██▒  ▐▌██▒░ ▓██▓ ░ ▒▓█  ▄ ░▓█▄   ▌   ▒██    ▒██ ░██▄▄▄▄██ ▓██▒  ▐▌██▒  ▒   ██▒░██░▒██   ██░▓██▒  ▐▌██▒
                        ░▓█▒░██▓ ▓█   ▓██▒▒▒█████▓ ▒██░   ▓██░  ▒██▒ ░ ░▒████▒░▒████▓    ▒██▒   ░██▒ ▓█   ▓██▒▒██░   ▓██░▒██████▒▒░██░░ ████▓▒░▒██░   ▓██░
                         ▒ ░░▒░▒ ▒▒   ▓▒█░░▒▓▒ ▒ ▒ ░ ▒░   ▒ ▒   ▒ ░░   ░░ ▒░ ░ ▒▒▓  ▒    ░ ▒░   ░  ░ ▒▒   ▓▒█░░ ▒░   ▒ ▒ ▒ ▒▓▒ ▒ ░░▓  ░ ▒░▒░▒░ ░ ▒░   ▒ ▒ 
                         ▒ ░▒░ ░  ▒   ▒▒ ░░░▒░ ░ ░ ░ ░░   ░ ▒░    ░     ░ ░  ░ ░ ▒  ▒    ░  ░      ░  ▒   ▒▒ ░░ ░░   ░ ▒░░ ░▒  ░ ░ ▒ ░  ░ ▒ ▒░ ░ ░░   ░ ▒░
                         ░  ░░ ░  ░   ▒    ░░░ ░ ░    ░   ░ ░   ░         ░    ░ ░  ░    ░      ░     ░   ▒      ░   ░ ░ ░  ░  ░   ▒ ░░ ░ ░ ▒     ░   ░ ░ 
                         ░  ░  ░      ░  ░   ░              ░             ░  ░   ░              ░         ░  ░         ░       ░   ░      ░ ░           ░ 
                                                                   ░     ");
                        Console.WriteLine("\t\t Can You Escape the Horror!\n\n" +
                        "Hello Random Victim\n" +
                        "Please state your name:");

                        string charName = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"Hello {charName}.\n" +
                            $"Welcome to the Haunted Mansion.\n\n" +
                        $"Press any key to begin.");
                        Console.ReadKey();
                                    for (int i = 100; i >= 1; i -= 5)
                                    {
                                        // Flashing screen and beeps

                                        Console.Clear();
                                        Thread.Sleep(i);
                                        Console.Write("Everything goes black.");
                                        Console.Beep(i + 100, i + 100);
                                        Thread.Sleep(i);
                                    }

                                    Console.WriteLine("\n\nYour ears are ringing and your head hurts.\n");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("You are unsure where you are or how you got here.\n\n" +
                                        "You open your eyes and find yourself in an strange room.\n\n" +
                                        "Press any key to look around.");
                                    Console.ReadKey();

            while (adventure)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\tDESCRTIPTION");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{currentRoom.RoomDesc}");
                if (currentRoom.Items.Count != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\tOBJECTS");
                    Console.ForegroundColor = ConsoleColor.White;
                    for (int i = 0; i < currentRoom.Items.Count; i++)
                    {
                        Console.WriteLine(currentRoom.Items[i].ShortDesc);
                    }
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\tEXITS");
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < currentRoom.Exits.Count; i += 2)
                {
                    Console.WriteLine($"{currentRoom.Exits[i]} {currentRoom.Exits[i + 1]}");
                }
                Console.Write("\n_________________________\n" +
                    "Type HELP for Help Screen\n" +
               $"What now {charName}:");

                string input = Console.ReadLine().ToUpper();

                if (input == "HELP")
                {
                    Console.WriteLine("HELP SCREEN\n" +
                        "\tType GO 'room' to walk around the mansion.\n" +
                        "\ti.e. GO KITCHEN || GO HALLWAY\n\n" +
                        "\tType EXAMINE 'objects' in the room.\n" +
                        "\ti.e. EXAMINE SINK || EXAMINE HAMMER\n\n" +
                     //   "\tType OPEN 'object' to open objects (if they can be opened)\n" +
                     //   "\ti.e. OPEN CABINET || OPEN TRAPDOOR\n\n" +
                        "\tType GET 'item' to pick up items and add them to your inventory.\n" +
                        "\ti.e. GET HAMMER\n\n" +
                        "\tType INVENTORY to list currently held items.\n" +
                        "\ti.e. INVENTORY\n\n" +
                        "\tType USE 'item' 'object' to use an inventory item on an object.\n" +
                        "\ti.e. USE KEY DOOR\n\n");

                    Console.Write("Continue...");
                    Console.ReadKey();
                }
                else if (input.StartsWith("GO "))
                {
                    bool exitAvailable = false;
                    foreach (string move in currentRoom.Exits)
                    {
                        if (input.Contains(move) && RoomDictionary.ContainsKey(move))
                        {
                            currentRoom = RoomDictionary[move];
                            exitAvailable = true;
                            break;
                        }
                    }
                    if (!exitAvailable)
                    {
                        Console.WriteLine("You run in to a wall and are now dizzy");
                        Console.ReadKey();
                    }
                }
                else if (input.StartsWith("EXAMINE "))
                {
                    bool itemAvailable = false;
                    foreach (Item item in currentRoom.Items)
                    {
                        if (input.Contains(item.Name))
                        {
                            Console.WriteLine(item.LongDesc);
                            Console.ReadKey();
                            itemAvailable = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Your head may need examaned.");
                            Console.ReadKey();
                        }
                    }
                }
                else if (input.StartsWith("GET "))
                {
                    bool itemAvailable = false;
                    foreach (Item item in currentRoom.Items)
                    {
                        if (input.Contains(item.Name) && item.CharItem == true)
                        {
                            currentRoom.Items.Remove(item);
                            inventory.Add(item);
                            Console.WriteLine(item.Output);
                            Console.ReadKey();
                            break;
                        }
                    }
                }
                else if (input == "INVENTORY")
                {
                    foreach (Item item in inventory)
                    {
                        Console.WriteLine(item.Name);
                    }
                    Console.ReadKey();
                }
                else if (input.StartsWith("USE "))
                {
                    bool itemAvailable = false;
                    foreach(Item item in inventory)
                    {
                        if (input.Contains(item.Name) && input.Contains("DOOR"))
                        {
                            if (currentRoom == frontEntrance)
                            {
                                Console.WriteLine("You unlock the FRONT DOOR.");
                                Console.WriteLine("Freedom... You have escaped the Haunted Mansion");
                                Console.ReadKey();
                                adventure = false;
                            }
                        }
                    }
                }
                else
                {
                    Random random = new Random();
                    int error = random.Next(1, 5);
                    switch (error)
                    {
                        case 1:
                            Console.WriteLine("Sorry, Is that English?");
                            Console.Write("Continue...");
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.WriteLine("Are you sure? The last guy who did got eaten!");
                            Console.Write("Continue...");
                            Console.ReadKey();
                            break;
                        case 3:
                            int wait = 250;
                            Console.WriteLine("Automating self destruct sequence!\n" +
                                "Press any key to continue...");
                            Console.ReadKey();
                            Thread.Sleep(wait);
                            Console.Beep(200, 100);
                            Console.Write("5! ");
                            Thread.Sleep(wait);
                            Console.Beep(200, 100);
                            Console.Write("4! ");
                            Thread.Sleep(wait);
                            Console.Beep(200, 100);
                            Console.Write("3! ");
                            Thread.Sleep(wait);
                            Console.Beep(200, 100);
                            Console.Write("2! ");
                            Thread.Sleep(wait);
                            Console.Beep(400, 200); Console.Beep(400, 200); Console.Beep(400, 200); Console.Beep(400, 1000);
                            Console.WriteLine("Just Kidding!!!");
                            Console.Write("Continue...");
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.WriteLine("Sorry, Is that English");
                            Console.Write("Continue...");
                            Console.ReadKey();
                            break;
                    }
                }
            }
        }
    }
}


