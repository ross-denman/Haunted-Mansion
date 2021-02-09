using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haunted_Mansion
{
    public class ProgramUI
    {
        public enum CharItem { crowbar, torch, knife, ropes, skeeltonkey }
        public List<CharItem> inventory = new List<CharItem>();
        public

    }
    public void Run()
    {
        StartingRoom room = greatRoom;
        bool alive = true;
        Console.Clear();
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
        while (alive)
        {
            Console.WriteLine(room.Splash);
            string command = Console.ReadLine().ToLower();
            // I clear the console before parsing the command, because
            //   I want the response at the top of the screen.
            // I also don't want to clear the screen until after the
            //   Console.ReadLine statement, so the user can still see the text
            Console.Clear();
            if (command.StartsWith("go ") || command.StartsWith("exit"))
            {
                // Here is some pseudocode to describe what's happening here:

                // Loop through the available exits
                //   If the room has an exit that matches the command
                //     Then change the current room to that room
                // (after the loop)
                // If no valid room name can be found in their command
                //   Then say "Go where??"
                // (that last part is what the "foundExit" variable is for)

                bool foundExit = false;
                foreach (string exit in room.Exits)
                {
                    if (!foundExit &&
                        command.Contains(exit) &&
                        RoomDictionary.ContainsKey(exit))
                    {
                        room = RoomDictionary[exit];
                        foundExit = true;
                        break;
                    }
                }
                if (!foundExit)
                {
                    Console.WriteLine("Uh... Go where?");
                }
            }
            else if (command.StartsWith("get ") || command.StartsWith("take ") || command.StartsWith("grab "))
            {
                // I use similar logic here
                bool foundItem = false;
                foreach (Item item in room.Items)
                {
                    if (!foundItem && command.Contains(item.ToString()))
                    {
                        Random rand = new Random();
                        int flavorTextChoice = rand.Next(0, 3);
                        string flavorText;
                        switch (flavorTextChoice)
                        {
                            case 0:
                                flavorText = ". Don't break it.";
                                break;
                            case 1:
                                flavorText = ". Good for you.";
                                break;
                            case 2:
                            default:
                                flavorText = ". Fantastic.";
                                break;
                        }
                        Console.WriteLine("You found a(n) " + item.ToString() + flavorText);
                        room.RemoveItem(item);
                        inventory.Add(item);
                        foundItem = true;
                        break;
                    }
                }
                if (!foundItem)
                {
                    Console.WriteLine("I don't know what you're talking about.");
                }
            }
            else if (command.StartsWith("look ") || command.StartsWith("check "))
            {
                // I haven't used this yet. Maybe the player can examine things in
                //   the room to unlock secrets. I don't know yet...
                Console.WriteLine("It looks fine.");
            }
            else if (command.StartsWith("use ") || command.StartsWith("activate "))
            {
                bool eventTriggered = false;
                string eventMessage = "(Error: Event message not found)";
                if (room.Events.Count > 0)
                {
                    foreach (Event roomEvent in room.Events)
                    {
                        if (!command.Contains(roomEvent.useTrigger))
                        {
                            continue;
                        }
                        if (roomEvent.Type == EventType.newExit)
                        {
                            room.AddExit(roomEvent.EventResult.ResultDestination);
                            eventTriggered = true;
                            eventMessage = roomEvent.EventResult.ResultMessage;
                        }
                        else
                        {
                            inventory.Add(roomEvent.EventResult.ResultItem);
                            eventTriggered = true;
                            eventMessage = roomEvent.EventResult.ResultMessage;
                        }
                    }
                }
                if (!eventTriggered)
                {
                    Console.WriteLine("I doubt you know how.");
                }
                else
                {
                    Console.WriteLine(eventMessage);
                }
            }
            else
            {
                Console.WriteLine("*BUUUUURP* What?");
            }
        }
    }
