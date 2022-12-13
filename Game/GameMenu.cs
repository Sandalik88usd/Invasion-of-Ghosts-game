using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Game
{
    internal class GameMenu
    {
        public static void TextInMenu()
        {
            CursorVisible = false;
            Clear();
            Write(@" 

                             .-') _      (`-.     ('-.      .-')                              .-') _  
                            ( OO ) )   _(OO  )_  ( OO ).-. ( OO ).                           ( OO ) ) 
                 ,-.-') ,--./ ,--,',--(_/   ,. \ / . --. /(_)---\_)  ,-.-')  .-'),-----. ,--./ ,--,'  
                 |  |OO)|   \ |  |\\   \   /(__/ | \-.  \ /    _ |   |  |OO)( OO'  .-.  '|   \ |  |\  
                 |  |  \|    \|  | )\   \ /   /.-'-'  |  |\  :` `.   |  |  \/   |  | |  ||    \|  | ) 
                 |  |(_/|  .     |/  \   '   /, \| |_.'  | '..`''.)  |  |(_/\_) |  |\|  ||  .     |/  
                ,|  |_.'|  |\    |    \     /__) |  .-.  |.-._)   \ ,|  |_.'  \ |  | |  ||  |\    |   
               (_|  |   |  | \   |     \   /     |  | |  |\       /(_|  |      `'  '-'  '|  | \   |   
                 `--'   `--'  `--'      `-'      `--' `--' `-----'   `--'        `-----' `--'  `--'   ");
            SetCursorPosition(50, 12);
            Write(" |P L A Y|");
            SetCursorPosition(47, 12);
            Write(">>");
            SetCursorPosition(50, 14);
            Write("|A B O U T|");
            SetCursorPosition(50, 16);
            Write(" |E X I T|");
        }
        

        public static void ChooseButton(ref int coordinate)
        {
            const int MaxCoordinate = 16;
            const int MinCoordinate = 10;
            coordinate = 12;
            ConsoleKey key = Console.ReadKey(true).Key;
            while (key != ConsoleKey.Enter)
            {
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.DownArrow:
                        if (coordinate == MaxCoordinate)
                        {
                            SetCursorPosition(47, coordinate);
                            Write("  ");
                            coordinate = MinCoordinate;

                        }
                        SetCursorPosition(47, coordinate);
                        Write("  ");
                        SetCursorPosition(47, coordinate += 2);
                        Write(">>");
                        break;

                    case ConsoleKey.UpArrow:
                        if (coordinate == MinCoordinate + 2)
                        {
                            SetCursorPosition(47, coordinate);
                            Write("  ");
                            coordinate = MaxCoordinate + 2;

                        }
                        SetCursorPosition(47, coordinate);
                        Write("  ");
                        SetCursorPosition(47, coordinate -= 2);
                        Write(">>");
                        break;

                }
            }
            PressButton(ref coordinate);
        }
        public static void PressButton(ref int coordinate)
        {
            switch (coordinate)
            {
                case 12:
                    PlayGame.StartWorkRoom();
                    break;
                case 14:
                    GameMenu.AboutGame(ref coordinate);
                    break;
                case 16:
                    GameMenu.ExitGame(ref coordinate);
                    break;
            }

        }
        public static void AboutGame(ref int coordinate)
        {
            Clear();
            Animation.WriteAt("This is a short story game about the best office worker", 30,10);
            Animation.WriteAt("who is addicted to the movie \"Ghostbusters\".", 34, 12);
            Animation.WriteAt("made by Serhii Okara", 20, 15);
            ConsoleKey key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Escape)
            {
                TextInMenu();
                ChooseButton(ref coordinate);
            }

        }
        public static void ExitGame(ref int coordinate)
        {
            Clear();
            Animation.WriteAt("I hope you enjoy this game.", 48, 10);
            Animation.WriteAt("Press Esc to come back or any key to exit.", 42, 11);
            ConsoleKey key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Escape)
            {
                TextInMenu();
                ChooseButton(ref coordinate);
            }
        }
    }
}


