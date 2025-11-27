using System;
using System.Collections.Generic;

namespace MonstersBrowser
{
    internal class Program
    {
        // key = monster name, value = (HP, Attack)
        static Dictionary<string, (int HP, int Attack)> monsters = new()
        {
            { "Delulu Wraith",        (140, 35) },
            { "Rizz Overlord",        (110, 45) },
            { "Sigma Lone Wolf",      (170, 40) },
            { "Gigachad Titan",       (190, 50) },
            { "Skibidi Toilet Fiend", (160, 30) },
            { "Gyat Beast",           (150, 45) },
            { "GOAT Champion",        (200, 55) }
        };

        static void Main(string[] args)
        {
            Console.Title = "MonsterBrowserApp // Gen-Z Console Edition";
            RunMainMenu();
        }

        // ===================== MAIN MENU =====================

        static void RunMainMenu()
        {
            while (true)
            {
                Console.Clear();
                PrintTitle("MONSTERBROWSER // MAIN MENU // NO CAP");

                Console.WriteLine("Pick one option, try not to be mid:");

                WriteGreenLine("  1. Travel   - menu works, content is still cooking");
                WriteGreenLine("  2. Journal  - contains Monsters, real part of the game");
                WriteGreenLine("  3. Exit     - rage quit moment");

                Console.WriteLine();

                int mainOption = ReadOption("Choose your vibe (1-3): ", 1, 3);

                switch (mainOption)
                {
                    case 1: RunTravelMenu(); break;
                    case 2: RunJournalMenu(); break;
                    case 3:
                        Console.Clear();
                        PrintTitle("APP SHUTDOWN // TOOK THE L");
                        Console.WriteLine("Program closed. Go touch grass, for real.");
                        Pause();
                        return;
                }
            }
        }

        // ===================== TRAVEL MENU =====================

        static void RunTravelMenu()
        {
            while (true)
            {
                Console.Clear();
                PrintTitle("TRAVEL MENU // LORE WALKING");

                Console.WriteLine("Alright explorer, what's the move:");

                WriteRedLine("  1. Explore          - feature is imaginary, like your hopes");
                WriteRedLine("  2. Search For Items - loot is delulu right now");
                WriteGreenLine("  3. Back To Ship     - actually works, W feature");

                Console.WriteLine();

                int travelOption = ReadOption("Pick a number (1-3): ", 1, 3);

                switch (travelOption)
                {
                    case 1:
                        Console.WriteLine();
                        WriteRedLine("Explore is pure fiction. You're walking in empty lore space.");
                        Pause();
                        break;

                    case 2:
                        Console.WriteLine();
                        WriteRedLine("Inventory empty. You looted air. Massive L.");
                        Pause();
                        break;

                    case 3:
                        Console.WriteLine();
                        WriteGreenLine("Returning to Main Menu like a true Sigma. W.");
                        Pause();
                        return;
                }
            }
        }

        // ===================== JOURNAL MENU =====================

        static void RunJournalMenu()
        {
            while (true)
            {
                Console.Clear();
                PrintTitle("JOURNAL MENU // LORE ARCHIVE");

                Console.WriteLine("Welcome to the lore vault — where chaos stays organized:");

                WriteGreenLine("  1. Monsters - fully working feature, peak gameplay");
                WriteRedLine("  2. Planets  - pure concept, delulu energy");
                WriteRedLine("  3. Items    - Work In Pain mode, zero implementation");
                WriteGreenLine("  4. Back     - returns to main menu, certified W");

                Console.WriteLine();

                int journalOption = ReadOption("Pick something (1-4): ", 1, 4);

                switch (journalOption)
                {
                    case 1: RunMonstersMenu(); break;
                    case 2:
                        Console.WriteLine();
                        WriteRedLine("Planets page exists only in my imagination right now.");
                        Pause();
                        break;
                    case 3:
                        Console.WriteLine();
                        WriteRedLine("Items page was promised, then ghosted. Classic dev move.");
                        Pause();
                        break;
                    case 4:
                        Console.WriteLine();
                        WriteGreenLine("Returning to Main Menu like nothing happened.");
                        Pause();
                        return;
                }
            }
        }

        // ===================== MONSTERS MENU =====================

        static void RunMonstersMenu()
        {
            while (true)
            {
                Console.Clear();
                PrintTitle("MONSTERS // GEN Z BESTIARY // PEAK CONTENT");

                PrintMonsters(monsters);

                Console.WriteLine();
                Console.WriteLine("Options:");

                WriteGreenLine("  1. Filter by Name - REAL feature, not mid at all");
                WriteGreenLine("  2. Back           - clean escape like leaving a dead groupchat");

                Console.WriteLine();

                int chooseOption = ReadOption("Select (1-2): ", 1, 2);

                switch (chooseOption)
                {
                    case 1:
                        Console.WriteLine();
                        Console.Write("Enter part of a monster name (or type chaos): ");
                        string input = Console.ReadLine() ?? string.Empty;

                        bool foundAny = false;
                        Console.WriteLine();

                        foreach (var monster in monsters)
                        {
                            if (monster.Key.Contains(input, StringComparison.OrdinalIgnoreCase))
                            {
                                WriteGreenLine("MATCH -> " + monster.Key +
                                               " | HP: " + monster.Value.HP +
                                               " | ATK: " + monster.Value.Attack);
                                foundAny = true;
                            }
                        }

                        if (!foundAny)
                        {
                            WriteRedLine("No monsters found matching: \"" + input + "\".");
                            Console.WriteLine("That search input was kinda cringe ngl.");
                            Console.WriteLine();
                            Console.WriteLine("Here’s the real squad:");
                            PrintMonsters(monsters);
                        }

                        Pause();
                        break;

                    case 2:
                        Console.WriteLine();
                        WriteGreenLine("Leaving Monsters like you just muted a drama groupchat.");
                        Pause();
                        return;
                }
            }
        }

        // ===================== UI UTILS =====================

        static void PrintTitle(string title)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine(" " + title);
            Console.WriteLine("==================================================");
            Console.WriteLine();
        }

        static void PrintMonsters(Dictionary<string, (int HP, int Attack)> list)
        {
            Console.WriteLine("Gen Z Monster Collection (No mid creatures allowed):");
            Console.WriteLine("--------------------------------------------------");
            foreach (var m in list)
            {
                Console.WriteLine("- " + m.Key + " | HP: " + m.Value.HP + " | ATK: " + m.Value.Attack);
            }
            Console.WriteLine("--------------------------------------------------");
        }

        static int ReadOption(string msg, int min, int max)
        {
            while (true)
            {
                Console.Write(msg);
                string input = Console.ReadLine();

                if (int.TryParse(input, out int n) && n >= min && n <= max)
                    return n;

                WriteRedLine("Invalid option. Type a real number, not a delulu one.");
            }
        }

        static void Pause()
        {
            Console.WriteLine();
            Console.Write("Press ENTER to continue like nothing happened...");
            Console.ReadLine();
        }

        static void WriteGreenLine(string t)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(t);
            Console.ResetColor();
        }

        static void WriteRedLine(string t)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(t);
            Console.ResetColor();
        }
    }
}
