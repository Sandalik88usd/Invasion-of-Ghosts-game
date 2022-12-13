using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Do
{
    internal class End
    {
        public static void EndOfGame()
        {
            Console.Clear();
            FinalScene();
            Console.Clear();
            Console.CursorVisible = false;
            Console.WindowWidth = 210;
            Console.BufferWidth = 210;
            Console.WindowHeight = 50;
            Console.BufferHeight = 50;
            Animation.WriteAt("End of Game", 15, 5);
            Console.ReadKey();
        }
        public static void FinalScene()
        {
            Thread SleepParticle = new Thread(Sleep);
            Thread ClockMove = new Thread(Clock);
            FirstCutScene.DefaultSceneGg();
            ClockMove.Start();
            Thread.Sleep(300);
            SleepParticle.Start();
            Thread.Sleep(8000);
            WakeUp();
        }
        static void Sleep()
        {
            int x = 51; int y = 25;
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Animation.WriteAt("Z", x, y);
                    Animation.WriteAt(" ", x + 2, y + 2);
                    x -= 2;
                    y -= 2;
                    Thread.Sleep(700);
                }
                Animation.WriteAt(" ", x + 2, y + 2);
                x = 51;
                y = 25;
            }

        }
        static void WakeUp()
        {
            DefaultSceneWithTalking();
            Animation.HeadOfMainCharacter(5, 39);
            //Animation.TalkingMouth(9, 42, 50);
            int number = 0;
            for (int j = 0; j < 4; j++)
            {
                Phrases(number++);
                for (int i = 0; i < 5; i++)
                    Animation.TalkingMouth(9, 45, 50);
            }
        }
        static void Phrases(int number)
        {
            int y = 39;
            int x = 35;
            switch (number)
            {
                case 0:
                    Animation.WriteAt("Oh what happened to me?", x, y);
                    break;
                case 1:
                    Animation.WriteAt("It was just a dream, I can't believe it.", x, y + 2);
                    break;
                case 2:
                    Animation.WriteAt("But the ghosts were so real.", x, y + 4);
                    break;
                case 3:
                    Animation.WriteAt("  .-.   ", 150, 18);
                    Animation.WriteAt(" (* *)  ", 150, 19);
                    Animation.WriteAt(" / ° \\ ", 150, 20);
                    Animation.WriteAt("^(   \\^", 150, 21);
                    Animation.WriteAt("  \\ (_,", 150, 22);
                    Animation.WriteAt("   '-'", 150, 23);
                    Animation.WriteAt("Stop, what?", x, y + 6);
                    break;
                case 4:
                    Console.Clear();
                    Console.Write("  ______           _          __                              \r\n |  ____|         | |        / _|                             \r\n | |__   _ __   __| |   ___ | |_    __ _  __ _ _ __ ___   ___ \r\n |  __| | '_ \\ / _` |  / _ \\|  _|  / _` |/ _` | '_ ` _ \\ / _ \\\r\n | |____| | | | (_| | | (_) | |   | (_| | (_| | | | | | |  __/\r\n |______|_| |_|\\__,_|  \\___/|_|    \\__, |\\__,_|_| |_| |_|\\___|\r\n                                    __/ |                     \r\n                                   |___/                      ");
                    break;
            }
        }
        static void Clock()
        {
            for (int i = 0; i < 10; i++)
            {
                Painter.Clock(140, 1, i);
                Thread.Sleep(900);
            }
        }
        static void DefaultSceneWithTalking()
        {
            Console.Write(@"
|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|                                                                                                                                            _______                                                            |
|                                                                                                                                           /   |   \                                                           |
|                                       ╔═════════════╗                            x@x                                                      | ' | ' |                                                           |
|                                       ║   ,,,,,,,   ║                           /\ /\                                                     |-  .  -|                                                           |
|                                       ║   │ 0 0 │   ║                           | | X                                                     | '   ' |                                                           |
|                                       ║   │  ─  │   ║                           X | |                        __________                   \___|___/                                                           |
|                                       ║  (`─────`)  ║                           x X x@                      |  __  __  |                                                                                      |
|                                       ║   |─────|   ║                           | X x                       | |  ||  | |                                                                                      |
|                                       ║<Best Worker>║                           x x X                       | |  ||  | |                                                                                      |
|                                       ╚═════════════╝                           X @ |                       | |__||__| |                                                                                      |
|                                                                                 X | |                       |  __  __()|                                                     __________                       |
|                                                                                _|___|_                      | |  ||  | |                                                    |  ______--|                      |
|                                                                               \       /                     | |  ||  | |                                                  \-`-/.::::.\-'\                     |
|                                                                                |: : :|                      | |__||__| |                                                   | `________'─|                     |
================================================================================ `_____'======================|__________|=================================================  |======|_____|======================
|                                                                                                                                                                            |      |     |                     |
|                                                                                                                                                                                                               |
|                                                                                                                                                                                                               |
|                                                                                                                                                                                                               |
|                                                                                                                                                                                                               |
|                                                                                                                                                                                                               |
|                                                                                                                                                                                                               |
|                          ____                          ____                          ____                          ____                                                                                       |
|                         ||""""||                        ||""""||                        ||""""||                        ||""""||                                                                                      |
|                         ||__||                        ,---,|                        ||__||                        ||__||                                                                                      |
|                         [ -=.]`)                      │___│]`)                      [ -=.]`)                      [ -=.]`)                                                                                    |
|                        |------|                      (|___|)|                      |------|                      |------|                                                                                     |
|                        |  --  |                      |\_║_/ |                      |  --  |                      |  --  |                                                                                     |
|                        |------|                      ||=║=|-|                      |------|                      |------|                                                                                     |
|                          ___                           | |                           ___                           ___                                                                                        |
|                         |___|                                                       |___|                         |___|                                                   _________                           |
|                         |_ _|                                                       |_ _|                         |_ _|                                                  / ,,____, \:.                        |
|                           ║                                                           ║                             ║                                                    |_||[][]|_|:  :                      |
|                         |=║=|      ___                           ___                |=║=|      ___                |=║=|      ___                                           / [][] \   :  :                    |
|                          | |      |___|                         |___|                | |      |___|                | |      |___|                                  \---   |________|   ..----\                |
|                                   |_ _|                         |_ _|                         |_ _|                         |_ _|                                  |\                         \               |
┌───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐
│                         │                                                                                                                                                                                     │
│                         │                                                                                                                                                                                     │
│                         │                                                                                                                                                                                     │
│                         │                                                                                                                                                                                     │
│                         │                                                                                                                                                                                     │
│                         │                                                                                                                                                                                     │
│                         │                                                                                                                                                                                     │
│                         │                                                                                                                                                                                     │
│                         │                                                                                                                                                                                     │
│                         │                                                                                                                                                                                     │
│                         │                                                                                                                                                                                     │
└───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
        }
    }
}
