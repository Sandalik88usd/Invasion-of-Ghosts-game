using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Game.Do
{
    internal class BrokenComputer
    {
        static void ComputerPrograms()
        {
            int x = 9; int y = 7;
            Animation.WriteAt("┌───────────────────┐", x, y++);
            Animation.WriteAt("│Word         _ <> x│", x, y++);
            Animation.WriteAt("├───────────────────┤", x, y++);
            for (int i = 0; i < 10; i++)
                Animation.WriteAt("│                   │", x, y++);
            Animation.WriteAt("└───────────────────┘", x, y++);
            Thread.Sleep(1000);
            x = 26; y = 6;
            Animation.WriteAt("┌───────────────────┐", x, y++);
            Animation.WriteAt("│Browser      _ <> x│", x, y++);
            Animation.WriteAt("├───────────────────┤", x, y++);
            for (int i = 0; i < 13; i++)
                Animation.WriteAt("│                   │", x, y++);
            Animation.WriteAt("└───────────────────┘", x, y++);
            Thread.Sleep(1000);
            x += 17; y = 4;
            Animation.WriteAt("┌────────────────────────────────────────────┐", x, y++);
            Animation.WriteAt("│Exel                                  _ <> x│", x, y++);
            Animation.WriteAt("├────────────────────────────────────────────┤", x, y++);
            Animation.WriteAt("│                                            │", x, y++);
            Animation.WriteAt("│   ▲                                        │", x, y++);
            Animation.WriteAt("│ 32│         Graph                          │", x, y++);
            Animation.WriteAt("│   │                           79           │", x, y++);
            Animation.WriteAt("│   ├──────────────────────────────►         │", x, y++);
            Animation.WriteAt("│   │                                        │", x, y++);
            Animation.WriteAt("│   │               45                       │", x, y++);
            Animation.WriteAt("│   ├──────────────────►                     │", x, y++);
            Animation.WriteAt("│   │                                        │", x, y++);
            Animation.WriteAt("│   │                    67                  │", x, y++);
            Animation.WriteAt("│   ├───────────────────────►                │", x, y++);
            Animation.WriteAt("│   │                                        │", x, y++);
            Animation.WriteAt("│   │                                        │", x, y++);
            Animation.WriteAt("│   └──────────────────────────────────►     │", x, y++);
            Animation.WriteAt("│                                     89     │", x, y++);
            Animation.WriteAt("│                                            │", x, y++);
            Animation.WriteAt("│                                            │", x, y++);
            Animation.WriteAt("└────────────────────────────────────────────┘", x, y++);


        }
        static void WhiteScreen()
        {
            Thread.Sleep(1000);
            for (int j = 0; j < 100; j++)
            {
                for (int i = 0; i < 35; i++)
                    Animation.WriteAt("█", j, i);
            }
        }
        static void ComputerInterface()
        {
            Clear();
            CursorVisible = false;
            WindowWidth = 100;
            WindowHeight = 35;
            BufferWidth = 100;
            BufferHeight = 35;
            for (int i = 0; i < 99; i++)
            {
                Animation.WriteAt("▄", i, 0);
                Animation.WriteAt("▄", i, 33);
                Animation.WriteAt("▬", i, 28);
            }
            for (int i = 1; i < 34; i++)
            {
                Animation.WriteAt("█", 0, i);
                Animation.WriteAt("█", 98, i);
            }
            Animation.WriteAt(" ■ ■ ", 2, 30);
            Animation.WriteAt(" ■ ■ ", 2, 31);

            Animation.WriteAt("┌─_", 10, 29);
            Animation.WriteAt("│--│", 10, 30);
            Animation.WriteAt("└──┘", 10, 31);

            Animation.WriteAt("┌──┐", 17, 29);
            Animation.WriteAt("│ X│", 17, 30);
            Animation.WriteAt("└──┘", 17, 31);
            Animation.WriteAt("▬▬▬▬", 17, 32);

            Animation.WriteAt("┌──┐", 24, 29);
            Animation.WriteAt("│ W│", 24, 30);
            Animation.WriteAt("└──┘", 24, 31);

            Animation.WriteAt("┌──┐", 31, 29);
            Animation.WriteAt("│Pw│", 31, 30);
            Animation.WriteAt("└──┘", 31, 31);

        }
        static void GhostOnScreen()
        {
            int x = 30; int y = 5;
            Animation.WriteAt("┌───────────────────────────┐", x, y++);
            Animation.WriteAt("│            .--,           │", x, y++);
            Animation.WriteAt("│           /  (            │", x, y++);
            Animation.WriteAt(@"│          /    \           │", x, y++);
            Animation.WriteAt(@"│         /      \          │", x, y++);
            Animation.WriteAt(@"│        /  0  0  \         │", x, y++);
            Animation.WriteAt(@"│((()   |    ()    |   ())),│", x, y++);
            Animation.WriteAt(@"│\  ()  (  .____.  )  ()  / │", x, y++);
            Animation.WriteAt(@"│ |` \_/ \  `""`  / \_/ ` |  │", x, y++);
            Animation.WriteAt(@"│ |       `.'--'.`       |  │", x, y++);
            Animation.WriteAt(@"│  \        `""`         /   │", x, y++);
            Animation.WriteAt(@"│   \                  /    │", x, y++);
            Animation.WriteAt(@"│    `.              .'    ,│", x, y++);
            Animation.WriteAt(@"│     |`             |  _.'|│", x, y++);
            Animation.WriteAt(@"│     |              `-'  / │", x, y++);
            Animation.WriteAt(@"│      `.____________.-'    │", x, y++);
            Animation.WriteAt(@"│___________________________│", x, y++);
            Animation.WriteAt(@"│           BOO!!!          │", x, y++);
            Animation.WriteAt(@"└───────────────────────────┘", x, y++);
            Thread.Sleep(700);

        }
        public static void Computer()
        {
            for (int i = 0; i < 3; i++)
            {
                ComputerInterface();
                ComputerPrograms();
                WhiteScreen();
                ComputerInterface();
                GhostOnScreen();
            }
            ComputerInterface();
            ComputerPrograms();
        }
    }
}
