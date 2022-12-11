using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Game.Do
{
    internal class FirstCutScene
    {
        public static void PlayFirstCutScene()
        {
            Animation.WriteAt("Once upon on standart work...", 90, 20);
            Animation.WriteAt("Press Enter to continue.", 90, 22);
            ConsoleKey skipKey = Console.ReadKey().Key;
            int numberOfFrame = -1;
            while (numberOfFrame <= 24)
            {
                skipKey = Console.ReadKey().Key;
                if (skipKey == ConsoleKey.Enter)
                    numberOfFrame++;
                switch (numberOfFrame)
                {
                    case 0:
                        ZeroFrame();
                        break;
                    case 1:
                        FirstFrame();
                        Animation.WriteAt("Press Enter to continue.", 105, 2);
                        break;
                    case 2:
                        SecondFrame();
                        break;
                    case 3:
                        ThirdFrame();
                        break;
                    case 4:
                        FourthFrame();
                        break;
                    case 5:
                        FifthFrame();
                        break;
                    case 6:
                        SixthFrame();
                        break;
                    case 7:
                        SeventhFrame();
                        break;
                    case 8:
                        EighthFrame();
                        break;
                    case 9:
                        NinthFrame();
                        break;
                    case 10:
                        TenthFrame();
                        break;
                    case 11:
                        EleventhFrame();
                        break;
                    case 12:
                        TwelfthFrame();
                        break;
                    case 13:
                        ThirteenthFrame();
                        break;
                    case 14:
                        FourteenthFrame();
                        break;
                    case 15:
                        FifteenthFrame();
                        SixteenthFrame();
                        SeventeenthFrame();
                        EighteenthFrame();
                        NineteenthFrame();
                        TwentienthFrame();
                        TwentieFirstFrame();
                        break;
                    case 16:
                        FirstFrame();
                        TwentieSecondFrame();
                        break;
                    case 17:
                        TwentieThirdFrame();
                        break;
                    case 18:
                        TwentieFourthFrame();
                        break;
                    case 19:
                        TwentieFifthFrame();
                        TwentieSixthFrame();
                        TwentieSeventhFrame();
                        break;
                    case 20:
                        FirstFrame();
                        TwentieEigthFrame();
                        break;
                    case 21:
                        BrokenComputer.Computer();
                        break;
                    case 22:
                        ZeroFrame();
                        TwentieNinthFrame();
                        break;
                    case 23:
                        ThirtyFrame();
                        break;
                    case 24:
                        ThirtyFirstFrame();
                        break;
                }

            }

        }
        static int moveDelay = 100;
        static void ZeroFrame()
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.WindowWidth = 210;
            Console.BufferWidth = 210;
            Console.WindowHeight = 50;
            Console.BufferHeight = 50;
            DefaultSceneWithColleagues();

        }
        static void FirstFrame()
        {
            for (int i = 1; i <= 9; i++)
            {
                Thread.Sleep(700);
                Painter.Clock(140, 1, i);
                Thread.Sleep(100);
                Painter.Scanner(174, 9, i);
            }
        }
        static void SecondFrame()
        {
            Console.Clear();
            Console.CursorVisible = false;
            DefaultSceneWithColleagues();
            int x = 125; int y = 24;
            Animation.WriteAt("  ┌────────────────────┐", x, y++);
            Animation.WriteAt("  │   Yep, job done!   │", x, y++);
            Animation.WriteAt("  │ Who wants to go to │", x, y++);
            Animation.WriteAt("  │ the pub with me??  │", x, y++);
            Animation.WriteAt("<<└────────────────────┘", x, y++);
        }
        static void ThirdFrame()
        {
            int x = 104; int y = 38;
            Animation.WriteAt("  ┌─────────────────────┐", x, y++);
            Animation.WriteAt("  │ With great pleasure │", x, y++);
            Animation.WriteAt("<<└─────────────────────┘", x, y++);

        }
        static void FourthFrame()
        {
            int x = 41;
            int y = 34;
            Animation.WriteAt("┌────────────────────┐", x, y++);
            Animation.WriteAt("│    Sorry guys.     │", x, y++);
            Animation.WriteAt("│ I have to go home, │", x, y++);
            Animation.WriteAt("│ today is my son's  │", x, y++);
            Animation.WriteAt("│     birthday.      │", x, y++);
            Animation.WriteAt("└────────────────────┘>>", x, y++);
        }
        static void FifthFrame()
        {
            int x = 35;
            int y = 23;
            Animation.WriteAt(" ┌───────────────┐", x, y++);
            Animation.WriteAt(" │  Sorry duds.  │", x, y++);
            Animation.WriteAt(" │ I must end my │", x, y++);
            Animation.WriteAt(" │   project.    │", x, y++);
            Animation.WriteAt(" └───────────────┘>>", x, y++);
        }
        static void SixthFrame()
        {
            Console.Clear();
            Console.CursorVisible = false;
            DefaultSceneWithColleagues();
            int x = 125; int y = 24;
            Animation.WriteAt("  ┌───────────────┐", x, y++);
            Animation.WriteAt("  │    Ok guys.   │", x, y++);
            Animation.WriteAt("  │ Alan lets go! │", x, y++);
            Animation.WriteAt("<<└───────────────┘", x, y++);
        }
        static void SeventhFrame()
        {
            int x = 104; int y = 38;
            Animation.WriteAt("  ┌────────────┐", x, y++);
            Animation.WriteAt("  │ Lets go!!! │", x, y++);
            Animation.WriteAt("<<└────────────┘", x, y++);

        }
        static void EighthFrame()
        {
            Console.Clear();
            Console.CursorVisible = false;
            DefaultSceneWithOutTwoColleagues();
            int xFirstMan = 105; int yFirstMan = 27;

            Animation.WriteAt(" ,___,", xFirstMan, yFirstMan++);
            Animation.WriteAt(" |'_'|", xFirstMan, yFirstMan++);
            Animation.WriteAt(@" \___/", xFirstMan, yFirstMan++);
            Animation.WriteAt("{|  ^|}", xFirstMan, yFirstMan++);
            Animation.WriteAt("|├───┤|", xFirstMan, yFirstMan++);
            Animation.WriteAt(" │_|_│", xFirstMan, yFirstMan++);

            int xSeocndMan = 104; int ySecondMan = 36;
            Animation.WriteAt("   ┌─┐", xSeocndMan, ySecondMan++);
            Animation.WriteAt(" ─┬┴─┴┬─", xSeocndMan, ySecondMan++);
            Animation.WriteAt("  │0_0│", xSeocndMan, ySecondMan++);
            Animation.WriteAt(" ('---')", xSeocndMan, ySecondMan++);
            Animation.WriteAt(" |├───┤|", xSeocndMan, ySecondMan++);
            Animation.WriteAt("  │_|_│", xSeocndMan, ySecondMan++);
        }
        static void NinthFrame()
        {
            //Console.Clear();
            //Console.CursorVisible = false;
            //DefaultSceneWithOutTwoColleagues();
            int xFirstMan = 105; int yFirstMan = 27;

            Animation.WriteAt(" ,___,", xFirstMan, yFirstMan++);
            Animation.WriteAt(" |,,,|", xFirstMan, yFirstMan++);
            Animation.WriteAt(@" \___/", xFirstMan, yFirstMan++);
            Animation.WriteAt("{|___|}", xFirstMan, yFirstMan++);
            Animation.WriteAt("|├───┤|", xFirstMan, yFirstMan++);
            Animation.WriteAt(" │_|_│", xFirstMan, yFirstMan++);

            int xSeocndMan = 104; int ySecondMan = 36;
            Animation.WriteAt("   ┌─┐", xSeocndMan, ySecondMan++);
            Animation.WriteAt(" ─┬┴─┴┬─", xSeocndMan, ySecondMan++);
            Animation.WriteAt("  │   │ ", xSeocndMan, ySecondMan++);
            Animation.WriteAt(" ('---')", xSeocndMan, ySecondMan++);
            Animation.WriteAt(" |├───┤|", xSeocndMan, ySecondMan++);
            Animation.WriteAt("  │_|_│", xSeocndMan, ySecondMan++);
        }
        static void TenthFrame()
        {
            int x = 114; int y = 37;
            Animation.WriteAt("  ┌──────────┐", x, y++);
            Animation.WriteAt("  │ Good bye │", x, y++);
            Animation.WriteAt("<<└──────────┘", x, y++);

        }
        static void EleventhFrame()
        {
            int x = 114; int y = 27;
            Animation.WriteAt("  ┌───────────────────┐", x, y++);
            Animation.WriteAt("  │  See you tomorrow │", x, y++);
            Animation.WriteAt("<<└───────────────────┘", x, y++);


        }
        static void TwelfthFrame()
        {
            int x = 57;
            int y = 36;
            Animation.WriteAt("┌─────┐", x, y++);
            Animation.WriteAt("│ Bye │", x, y++);
            Animation.WriteAt("└─────┘>>", x, y++);
        }
        static void ThirteenthFrame()
        {
            int x = 33;
            int y = 24;
            Animation.WriteAt(" ┌─────────────────┐", x, y++);
            Animation.WriteAt(" │  See you later  │", x, y++);
            Animation.WriteAt(" └─────────────────┘>>", x, y++);

        }
        static void FourteenthFrame()
        {
            Console.Clear();
            Console.CursorVisible = false;
            DefaultSceneWithOutTwoColleagues();
            NinthFrame();
        }
        static void FifteenthFrame()
        {
            int x = 105;
            for (int y = 27; y >= 17; y--)
            {
                for (int i = 0; i <= 3; i++)
                {
                    switch (i)
                    {
                        case 0:
                            Animation.WriteAt(" ,___,", x, y);
                            Animation.WriteAt(" |,,,|", x, y + 1);
                            Animation.WriteAt(@" \___/", x, y + 2);
                            Animation.WriteAt("{|___|}", x, y + 3);
                            Animation.WriteAt("│├───┤│ ", x, y + 4);
                            Animation.WriteAt(" │_|_│  ", x, y + 5);
                            Animation.WriteAt("         ", x, y + 6);
                            //Animation.WriteAt("         ", x, y + 7);
                            Thread.Sleep(moveDelay);
                            y--;
                            break;
                        case 1:
                            Animation.WriteAt(" ,___,", x, y);
                            Animation.WriteAt(" |,,,|", x, y + 1);
                            Animation.WriteAt(@" \___/", x, y + 2);
                            Animation.WriteAt("{|___|}", x, y + 3);
                            Animation.WriteAt("│├───┤│ ", x, y + 4);
                            Animation.WriteAt(" └─┤_│  ", x, y + 5);
                            Animation.WriteAt("         ", x, y + 6);
                            Animation.WriteAt("         ", x, y + 7);
                            Thread.Sleep(moveDelay);
                            y--;
                            break;
                        case 2:
                            Animation.WriteAt(" ,___,", x, y);
                            Animation.WriteAt(" |,,,|", x, y + 1);
                            Animation.WriteAt(@" \___/", x, y + 2);
                            Animation.WriteAt("{|___|}", x, y + 3);
                            Animation.WriteAt("│├───┤│ ", x, y + 4);
                            Animation.WriteAt(" │_├─┘  ", x, y + 5);
                            Animation.WriteAt("         ", x, y + 6);
                            Animation.WriteAt("         ", x, y + 7);
                            Thread.Sleep(moveDelay);
                            y--;
                            break;
                        case 3:
                            Animation.WriteAt(" ,___,", x, y);
                            Animation.WriteAt(" |,,,|", x, y + 1);
                            Animation.WriteAt(@" \___/", x, y + 2);
                            Animation.WriteAt("{|___|}", x, y + 3);
                            Animation.WriteAt("│├───┤│ ", x, y + 4);
                            Animation.WriteAt(" └─┤_│  ", x, y + 5);
                            Animation.WriteAt("         ", x, y + 6);
                            Animation.WriteAt("         ", x, y + 7);
                            Thread.Sleep(moveDelay);
                            break;

                    }
                }
            }
        }
        static void SixteenthFrame()
        {
            int x = 105; int y = 17;
            for (; x <= 122; x++)
            {
                for (int i = 0; i <= 3; i++)
                {
                    switch (i)
                    {
                        case 0:
                            Animation.WriteAt("         ", x, y - 1);
                            Animation.WriteAt("  ,,,,, ", x, y);
                            Animation.WriteAt(@"  \  '│  ", x, y + 1);
                            Animation.WriteAt("   '──/  ", x, y + 2);
                            Animation.WriteAt("   │||│  ", x, y + 3);
                            Animation.WriteAt("   │__│  ", x, y + 4);
                            Animation.WriteAt("         ", x, y + 5);
                            Thread.Sleep(moveDelay);
                            x++;
                            break;
                        case 1:
                            Animation.WriteAt("         ", x, y - 1);
                            Animation.WriteAt("  ,,,,, ", x, y);
                            Animation.WriteAt(@"  \  '│  ", x, y + 1);
                            Animation.WriteAt("   '──/  ", x, y + 2);
                            Animation.WriteAt("   │||│  ", x, y + 3);
                            Animation.WriteAt("   │_─┘  ", x, y + 4);
                            Animation.WriteAt("         ", x, y + 5);
                            Thread.Sleep(moveDelay);
                            x++;
                            break;
                        case 2:
                            Animation.WriteAt("          ", x, y - 1);
                            Animation.WriteAt("  ,,,,, ", x, y);
                            Animation.WriteAt(@"  \  '│  ", x, y + 1);
                            Animation.WriteAt("   '──/  ", x, y + 2);
                            Animation.WriteAt("   │||│  ", x, y + 3);
                            Animation.WriteAt("   └─_│  ", x, y + 4);
                            Animation.WriteAt("         ", x, y + 5);
                            Thread.Sleep(moveDelay);
                            x++;
                            break;
                        case 3:
                            Animation.WriteAt("         ", x, y - 1);
                            Animation.WriteAt("  ,,,,, ", x, y);
                            Animation.WriteAt(@"  \  '│  ", x, y + 1);
                            Animation.WriteAt("   '──/  ", x, y + 2);
                            Animation.WriteAt("   │||│  ", x, y + 3);
                            Animation.WriteAt("   │_─┘  ", x, y + 4);
                            Animation.WriteAt("         ", x, y + 5);
                            Thread.Sleep(moveDelay);
                            break;
                    }
                }

            }
            Animation.WriteAt(" ,___,", x, y - 1);
            Animation.WriteAt(" |'_'|", x, y);
            Animation.WriteAt(@" \___/", x, y + 1);
            Animation.WriteAt("{|  ^|}", x, y + 2);
            Animation.WriteAt("|├───┤|", x, y + 3);
            Animation.WriteAt(" │_|_│", x, y + 4);
            Animation.WriteAt("         ", x, y + 5);
        }
        static void SeventeenthFrame()
        {
            int x = 104;
            for (int y = 36; y >= 20; y--)
            {
                for (int i = 0; i <= 3; i++)
                {
                    switch (i)
                    {
                        case 0:
                            Animation.WriteAt("   ┌─┐  ", x, y);
                            Animation.WriteAt(" ─┬┴─┴┬─  ", x, y + 1);
                            Animation.WriteAt("  │   │  ", x, y + 2);
                            Animation.WriteAt(" ('───') ", x, y + 3);
                            Animation.WriteAt(" │├───┤│ ", x, y + 4);
                            Animation.WriteAt("  │_|_│  ", x, y + 5);
                            Animation.WriteAt("         ", x, y + 6);
                            //Animation.WriteAt("         ", x, y + 7);
                            Thread.Sleep(moveDelay);
                            y--;
                            break;
                        case 1:
                            Animation.WriteAt("   ┌─┐  ", x, y);
                            Animation.WriteAt(" ─┬┴─┴┬─  ", x, y + 1);
                            Animation.WriteAt("  │   │  ", x, y + 2);
                            Animation.WriteAt(" ('───') ", x, y + 3);
                            Animation.WriteAt(" │├───┤│ ", x, y + 4);
                            Animation.WriteAt("  └─┤_│  ", x, y + 5);
                            Animation.WriteAt("         ", x, y + 6);
                            Animation.WriteAt("         ", x, y + 7);
                            Thread.Sleep(moveDelay);
                            y--;
                            break;
                        case 2:
                            Animation.WriteAt("   ┌─┐  ", x, y);
                            Animation.WriteAt(" ─┬┴─┴┬─  ", x, y + 1);
                            Animation.WriteAt("  │   │  ", x, y + 2);
                            Animation.WriteAt(" ('───') ", x, y + 3);
                            Animation.WriteAt(" │├───┤│ ", x, y + 4);
                            Animation.WriteAt("  │_├─┘  ", x, y + 5);
                            Animation.WriteAt("         ", x, y + 6);
                            Animation.WriteAt("         ", x, y + 7);
                            Thread.Sleep(moveDelay);
                            y--;
                            break;
                        case 3:
                            Animation.WriteAt("   ┌─┐  ", x, y);
                            Animation.WriteAt(" ─┬┴─┴┬─  ", x, y + 1);
                            Animation.WriteAt("  │   │  ", x, y + 2);
                            Animation.WriteAt(" ('───') ", x, y + 3);
                            Animation.WriteAt(" │├───┤│ ", x, y + 4);
                            Animation.WriteAt("  └─┤_│  ", x, y + 5);
                            Animation.WriteAt("         ", x, y + 6);
                            Animation.WriteAt("         ", x, y + 7);
                            Thread.Sleep(moveDelay);
                            break;

                    }
                }
            }
        }
        static void EighteenthFrame()
        {
            int x = 105; int y = 17;
            for (; x <= 110; x++)
            {
                for (int i = 0; i <= 3; i++)
                {
                    switch (i)
                    {
                        case 0:
                            Animation.WriteAt("   ┌──┐   ", x, y - 1);
                            Animation.WriteAt("  ─┼──┼─ ", x, y);
                            Animation.WriteAt("   │ '│  ", x, y + 1);
                            Animation.WriteAt("   '──'  ", x, y + 2);
                            Animation.WriteAt("   │||│  ", x, y + 3);
                            Animation.WriteAt("   │__│  ", x, y + 4);
                            Animation.WriteAt("         ", x, y + 5);
                            Thread.Sleep(moveDelay);
                            x++;
                            break;
                        case 1:
                            Animation.WriteAt("   ┌──┐   ", x, y - 1);
                            Animation.WriteAt("  ─┼──┼─ ", x, y);
                            Animation.WriteAt("   │ '│  ", x, y + 1);
                            Animation.WriteAt("   '──'  ", x, y + 2);
                            Animation.WriteAt("   │||│  ", x, y + 3);
                            Animation.WriteAt("   │_─┘  ", x, y + 4);
                            Animation.WriteAt("         ", x, y + 5);
                            Thread.Sleep(moveDelay);
                            x++;
                            break;
                        case 2:
                            Animation.WriteAt("   ┌──┐   ", x, y - 1);
                            Animation.WriteAt("  ─┼──┼─ ", x, y);
                            Animation.WriteAt("   │ '│  ", x, y + 1);
                            Animation.WriteAt("   '──'  ", x, y + 2);
                            Animation.WriteAt("   │||│  ", x, y + 3);
                            Animation.WriteAt("   └─_│  ", x, y + 4);
                            Animation.WriteAt("         ", x, y + 5);
                            Thread.Sleep(moveDelay);
                            x++;
                            break;
                        case 3:
                            Animation.WriteAt("   ┌──┐   ", x, y - 1);
                            Animation.WriteAt("  ─┼──┼─ ", x, y);
                            Animation.WriteAt("   │ '│  ", x, y + 1);
                            Animation.WriteAt("   '──'  ", x, y + 2);
                            Animation.WriteAt("   │||│  ", x, y + 3);
                            Animation.WriteAt("   │_─┘  ", x, y + 4);
                            Animation.WriteAt("         ", x, y + 5);
                            Thread.Sleep(moveDelay);
                            break;
                    }
                }


                Animation.WriteAt("   ┌─┐  ", x, y - 1);
                Animation.WriteAt(" ─┬┴─┴┬─", x, y);
                Animation.WriteAt("  │0_0│", x, y + 1);
                Animation.WriteAt(" ('---')", x, y + 2);
                Animation.WriteAt(" |├───┤|", x, y + 3);
                Animation.WriteAt("  │_|_│", x, y + 4);
                Animation.WriteAt("         ", x, y + 5);
            }

        }
        static void NineteenthFrame()
        {
            Painter.OpenedDoor(98, 6);
            int x = 111;
            for (int y = 16; y >= 12; y--)
            {
                for (int i = 0; i <= 3; i++)
                {
                    switch (i)
                    {
                        case 0:
                            Animation.WriteAt("   ┌─┐  ", x, y);
                            Animation.WriteAt(" ─┬┴─┴┬─  ", x, y + 1);
                            Animation.WriteAt("  │   │  ", x, y + 2);
                            Animation.WriteAt(" ('───') ", x, y + 3);
                            Animation.WriteAt(" │├───┤│ ", x, y + 4);
                            Animation.WriteAt("  │_|_│  ", x, y + 5);
                            Animation.WriteAt("         ", x, y + 6);
                            //Animation.WriteAt("         ", x, y + 7);
                            Thread.Sleep(moveDelay);
                            y--;
                            break;
                        case 1:
                            Animation.WriteAt("   ┌─┐  ", x, y);
                            Animation.WriteAt(" ─┬┴─┴┬─  ", x, y + 1);
                            Animation.WriteAt("  │   │  ", x, y + 2);
                            Animation.WriteAt(" ('───') ", x, y + 3);
                            Animation.WriteAt(" │├───┤│ ", x, y + 4);
                            Animation.WriteAt("  └─┤_│  ", x, y + 5);
                            Animation.WriteAt("         ", x, y + 6);
                            Animation.WriteAt("         ", x, y + 7);
                            Thread.Sleep(moveDelay);
                            y--;
                            break;
                        case 2:
                            Animation.WriteAt("   ┌─┐  ", x, y);
                            Animation.WriteAt(" ─┬┴─┴┬─  ", x, y + 1);
                            Animation.WriteAt("  │   │  ", x, y + 2);
                            Animation.WriteAt(" ('───') ", x, y + 3);
                            Animation.WriteAt(" │├───┤│ ", x, y + 4);
                            Animation.WriteAt("  │_├─┘  ", x, y + 5);
                            Animation.WriteAt("         ", x, y + 6);
                            Animation.WriteAt("         ", x, y + 7);
                            Thread.Sleep(moveDelay);
                            y--;
                            break;
                        case 3:
                            Animation.WriteAt("   ┌─┐  ", x, y);
                            Animation.WriteAt(" ─┬┴─┴┬─  ", x, y + 1);
                            Animation.WriteAt("  │   │  ", x, y + 2);
                            Animation.WriteAt(" ('───') ", x, y + 3);
                            Animation.WriteAt(" │├───┤│ ", x, y + 4);
                            Animation.WriteAt("  └─┤_│  ", x, y + 5);
                            Animation.WriteAt("         ", x, y + 6);
                            Animation.WriteAt("         ", x, y + 7);
                            Thread.Sleep(moveDelay);
                            break;

                    }
                }
                Painter.OpenedDoor(98, 6);
            }
        }
        static void TwentienthFrame()
        {
            int y = 17; int x = 120;
            for (; x > 112; x--)
            {
                for (int i = 0; i <= 3; i++)
                {
                    switch (i)
                    {
                        case 0:
                            Animation.WriteAt("           ", x, y - 1);
                            Animation.WriteAt(" ,,,,,     ", x, y);
                            Animation.WriteAt(" │'  /     ", x, y + 1);
                            Animation.WriteAt(@"  \__'      ", x, y + 2);
                            Animation.WriteAt("  │||│       ", x, y + 3);
                            Animation.WriteAt("  │__│      ", x, y + 4);
                            Animation.WriteAt("           ", x, y + 5);
                            Thread.Sleep(moveDelay);
                            x--;
                            break;
                        case 1:
                            Animation.WriteAt("           ", x, y - 1);
                            Animation.WriteAt(" ,,,,,     ", x, y);
                            Animation.WriteAt(" │'  /     ", x, y + 1);
                            Animation.WriteAt(@"  \__'      ", x, y + 2);
                            Animation.WriteAt("  │||│       ", x, y + 3);
                            Animation.WriteAt("  │_─┘      ", x, y + 4);
                            Animation.WriteAt("           ", x, y + 5);
                            Thread.Sleep(moveDelay);
                            x--;
                            break;
                        case 2:
                            Animation.WriteAt("           ", x, y - 1);
                            Animation.WriteAt(" ,,,,,     ", x, y);
                            Animation.WriteAt(" │'  /     ", x, y + 1);
                            Animation.WriteAt(@"  \__'      ", x, y + 2);
                            Animation.WriteAt("  │||│       ", x, y + 3);
                            Animation.WriteAt("  └─_│      ", x, y + 4);
                            Animation.WriteAt("           ", x, y + 5);
                            Thread.Sleep(moveDelay);
                            x--;
                            break;
                        case 3:
                            Animation.WriteAt("           ", x, y - 1);
                            Animation.WriteAt(" ,,,,,     ", x, y);
                            Animation.WriteAt(" │'  /     ", x, y + 1);
                            Animation.WriteAt(@"  \__'      ", x, y + 2);
                            Animation.WriteAt("  │||│       ", x, y + 3);
                            Animation.WriteAt("  │_─┘      ", x, y + 4);
                            Animation.WriteAt("           ", x, y + 5);
                            Thread.Sleep(moveDelay);
                            break;

                    }
                }
                //Painter.OpenedDoor(98, 6);
            }
            y--;
            Animation.WriteAt(" ,___,  ", x, y);
            Animation.WriteAt(" |,,,|  ", x, y + 1);
            Animation.WriteAt(@" \___/  ", x, y + 2);
            Animation.WriteAt("{|___|}  ", x, y + 3);
            Animation.WriteAt("│├───┤│   ", x, y + 4);
            Animation.WriteAt(" │_|_│    ", x, y + 5);
            Animation.WriteAt("         ", x, y + 6);
        }
        static void TwentieFirstFrame()
        {
            int x = 112; int y = 16;
            for (; y >= 12; y--)
            {
                for (int i = 0; i <= 3; i++)
                {
                    switch (i)
                    {
                        case 0:
                            Animation.WriteAt(" ,___,", x, y);
                            Animation.WriteAt(" |,,,|", x, y + 1);
                            Animation.WriteAt(@" \___/", x, y + 2);
                            Animation.WriteAt("{|___|}", x, y + 3);
                            Animation.WriteAt("│├───┤│ ", x, y + 4);
                            Animation.WriteAt(" │_|_│  ", x, y + 5);
                            Animation.WriteAt("         ", x, y + 6);
                            //Animation.WriteAt("         ", x, y + 7);
                            Thread.Sleep(moveDelay);
                            y--;
                            break;
                        case 1:
                            Animation.WriteAt(" ,___,", x, y);
                            Animation.WriteAt(" |,,,|", x, y + 1);
                            Animation.WriteAt(@" \___/", x, y + 2);
                            Animation.WriteAt("{|___|}", x, y + 3);
                            Animation.WriteAt("│├───┤│ ", x, y + 4);
                            Animation.WriteAt(" └─┤_│  ", x, y + 5);
                            Animation.WriteAt("         ", x, y + 6);
                            Animation.WriteAt("         ", x, y + 7);
                            Thread.Sleep(moveDelay);
                            y--;
                            break;
                        case 2:
                            Animation.WriteAt(" ,___,", x, y);
                            Animation.WriteAt(" |,,,|", x, y + 1);
                            Animation.WriteAt(@" \___/", x, y + 2);
                            Animation.WriteAt("{|___|}", x, y + 3);
                            Animation.WriteAt("│├───┤│ ", x, y + 4);
                            Animation.WriteAt(" │_├─┘  ", x, y + 5);
                            Animation.WriteAt("         ", x, y + 6);
                            Animation.WriteAt("         ", x, y + 7);
                            Thread.Sleep(moveDelay);
                            y--;
                            break;
                        case 3:
                            Animation.WriteAt(" ,___,", x, y);
                            Animation.WriteAt(" |,,,|", x, y + 1);
                            Animation.WriteAt(@" \___/", x, y + 2);
                            Animation.WriteAt("{|___|}", x, y + 3);
                            Animation.WriteAt("│├───┤│ ", x, y + 4);
                            Animation.WriteAt(" └─┤_│  ", x, y + 5);
                            Animation.WriteAt("         ", x, y + 6);
                            Animation.WriteAt("         ", x, y + 7);
                            Thread.Sleep(moveDelay);
                            break;

                    }
                }
            }
            Console.Clear();
            DefaultSceneWithOutTwoColleagues();
        }
        static void TwentieSecondFrame()
        {
            Console.Clear();
            Console.CursorVisible = false;
            DefaultSceneGg();
            int x = 76; int y = 37;

            Animation.WriteAt(" ┌───┐", x, y++);
            Animation.WriteAt(" │- -│", x, y++);
            Animation.WriteAt(" │ $ │", x, y++);
            Animation.WriteAt(@"/└───┘\", x, y++);
            Animation.WriteAt("|├───┤|", x, y++);
            Animation.WriteAt(" │_|_│", x, y++);
        }
        static void TwentieThirdFrame()
        {
            int x = 83;
            int y = 36;
            Animation.WriteAt("  ┌──────────┐", x, y++);
            Animation.WriteAt("  │  I must  │", x, y++);
            Animation.WriteAt("  │already go│", x, y++);
            Animation.WriteAt("<<└──────────┘", x, y++);
        }
        static void TwentieFourthFrame()
        {
            int x = 43;
            int y = 25;
            Animation.WriteAt(" ┌───────┐", x, y++);
            Animation.WriteAt(" │  Bye  │", x, y++);
            Animation.WriteAt(" └───────┘>>", x, y++);
        }
        static void TwentieFifthFrame()
        {
            Console.Clear();
            DefaultSceneGg();
            int x = 76;
            for (int y = 37; y >= 18; y--)
            {
                for (int i = 0; i <= 3; i++)
                {
                    switch (i)
                    {
                        case 0:
                            Animation.WriteAt(" ┌───┐", x, y);
                            Animation.WriteAt(" │   │", x, y + 1);
                            Animation.WriteAt(" │===│", x, y + 2);
                            Animation.WriteAt(@"/└───┘\", x, y + 3);
                            Animation.WriteAt("│├───┤│ ", x, y + 4);
                            Animation.WriteAt(" │_|_│  ", x, y + 5);
                            Animation.WriteAt("         ", x, y + 6);
                            //Animation.WriteAt("         ", x, y + 7);
                            Thread.Sleep(moveDelay);
                            y--;
                            break;
                        case 1:
                            Animation.WriteAt(" ┌───┐", x, y);
                            Animation.WriteAt(" │   │", x, y + 1);
                            Animation.WriteAt(" │===│", x, y + 2);
                            Animation.WriteAt(@"/└───┘\", x, y + 3);
                            Animation.WriteAt("│├───┤│ ", x, y + 4);
                            Animation.WriteAt(" └─┤_│  ", x, y + 5);
                            Animation.WriteAt("         ", x, y + 6);
                            Animation.WriteAt("         ", x, y + 7);
                            Thread.Sleep(moveDelay);
                            y--;
                            break;
                        case 2:
                            Animation.WriteAt(" ┌───┐", x, y);
                            Animation.WriteAt(" │   │", x, y + 1);
                            Animation.WriteAt(" │===│", x, y + 2);
                            Animation.WriteAt(@"/└───┘\", x, y + 3);
                            Animation.WriteAt("│├───┤│ ", x, y + 4);
                            Animation.WriteAt(" │_├─┘  ", x, y + 5);
                            Animation.WriteAt("         ", x, y + 6);
                            Animation.WriteAt("         ", x, y + 7);
                            Thread.Sleep(moveDelay);
                            y--;
                            break;
                        case 3:
                            Animation.WriteAt(" ┌───┐", x, y);
                            Animation.WriteAt(" │   │", x, y + 1);
                            Animation.WriteAt(" │===│", x, y + 2);
                            Animation.WriteAt(@"/└───┘\", x, y + 3);
                            Animation.WriteAt("│├───┤│ ", x, y + 4);
                            Animation.WriteAt(" └─┤_│  ", x, y + 5);
                            Animation.WriteAt("         ", x, y + 6);
                            Animation.WriteAt("         ", x, y + 7);
                            Thread.Sleep(moveDelay);
                            break;

                    }
                }
            }
        }
        static void TwentieSixthFrame()
        {
            Animation.WriteAt("         ", 76, 23);
            int x = 76; int y = 17;
            for (; x <= 110; x++)
            {
                for (int i = 0; i <= 3; i++)
                {
                    switch (i)
                    {
                        case 0:
                            Animation.WriteAt("  ┌──┐ ", x, y - 1);
                            Animation.WriteAt("  │ -│ ", x, y);
                            Animation.WriteAt("  │ $│ ", x, y + 1);
                            Animation.WriteAt("  └──┘ ", x, y + 2);
                            Animation.WriteAt("  │||│  ", x, y + 3);
                            Animation.WriteAt("  │__│  ", x, y + 4);
                            Animation.WriteAt("         ", x, y + 5);
                            Thread.Sleep(moveDelay);
                            x++;
                            break;
                        case 1:
                            Animation.WriteAt("  ┌──┐ ", x, y - 1);
                            Animation.WriteAt("  │ -│ ", x, y);
                            Animation.WriteAt("  │ $│ ", x, y + 1);
                            Animation.WriteAt("  └──┘ ", x, y + 2);
                            Animation.WriteAt("  │||│  ", x, y + 3);
                            Animation.WriteAt("  │_─┘  ", x, y + 4);
                            Animation.WriteAt("         ", x, y + 5);
                            Thread.Sleep(moveDelay);
                            x++;
                            break;
                        case 2:
                            Animation.WriteAt("  ┌──┐ ", x, y - 1);
                            Animation.WriteAt("  │ -│ ", x, y);
                            Animation.WriteAt("  │ $│ ", x, y + 1);
                            Animation.WriteAt("  └──┘ ", x, y + 2);
                            Animation.WriteAt("  │||│  ", x, y + 3);
                            Animation.WriteAt("  └─_│  ", x, y + 4);
                            Animation.WriteAt("         ", x, y + 5);
                            Thread.Sleep(moveDelay);
                            x++;
                            break;
                        case 3:
                            Animation.WriteAt("  ┌──┐ ", x, y - 1);
                            Animation.WriteAt("  │ -│ ", x, y);
                            Animation.WriteAt("  │ $│ ", x, y + 1);
                            Animation.WriteAt("  └──┘ ", x, y + 2);
                            Animation.WriteAt("  │||│  ", x, y + 3);
                            Animation.WriteAt("  │_─┘  ", x, y + 4);
                            Animation.WriteAt("         ", x, y + 5);
                            Thread.Sleep(moveDelay);
                            break;
                    }
                }
            }
            y--;
            Animation.WriteAt(" ┌───┐", x, y);
            Animation.WriteAt(" │   │", x, y + 1);
            Animation.WriteAt(" │===│", x, y + 2);
            Animation.WriteAt(@"/└───┘\", x, y + 3);
            Animation.WriteAt("│├───┤│ ", x, y + 4);
            Animation.WriteAt(" │_|_│  ", x, y + 5);
            Animation.WriteAt("        ", x, y + 6);
            Painter.OpenedDoor(98, 6);
        }
        static void TwentieSeventhFrame()
        {
            int x = 112;
            for (int y = 16; y >= 9; y--)
            {
                for (int i = 0; i <= 3; i++)
                {
                    switch (i)
                    {
                        case 0:
                            Animation.WriteAt(" ┌───┐", x, y);
                            Animation.WriteAt(" │   │", x, y + 1);
                            Animation.WriteAt(" │===│", x, y + 2);
                            Animation.WriteAt(@"/└───┘\", x, y + 3);
                            Animation.WriteAt("│├───┤│ ", x, y + 4);
                            Animation.WriteAt(" │_|_│  ", x, y + 5);
                            Animation.WriteAt("         ", x, y + 6);
                            //Animation.WriteAt("         ", x, y + 7);
                            Thread.Sleep(moveDelay);
                            y--;
                            break;
                        case 1:
                            Animation.WriteAt(" ┌───┐", x, y);
                            Animation.WriteAt(" │   │", x, y + 1);
                            Animation.WriteAt(" │===│", x, y + 2);
                            Animation.WriteAt(@"/└───┘\", x, y + 3);
                            Animation.WriteAt("│├───┤│ ", x, y + 4);
                            Animation.WriteAt(" └─┤_│  ", x, y + 5);
                            Animation.WriteAt("         ", x, y + 6);
                            Animation.WriteAt("         ", x, y + 7);
                            Thread.Sleep(moveDelay);
                            y--;
                            break;
                        case 2:
                            Animation.WriteAt(" ┌───┐", x, y);
                            Animation.WriteAt(" │   │", x, y + 1);
                            Animation.WriteAt(" │===│", x, y + 2);
                            Animation.WriteAt(@"/└───┘\", x, y + 3);
                            Animation.WriteAt("│├───┤│ ", x, y + 4);
                            Animation.WriteAt(" │_├─┘  ", x, y + 5);
                            Animation.WriteAt("         ", x, y + 6);
                            Animation.WriteAt("         ", x, y + 7);
                            Thread.Sleep(moveDelay);
                            y--;
                            break;
                        case 3:
                            Animation.WriteAt(" ┌───┐", x, y);
                            Animation.WriteAt(" │   │", x, y + 1);
                            Animation.WriteAt(" │===│", x, y + 2);
                            Animation.WriteAt(@"/└───┘\", x, y + 3);
                            Animation.WriteAt("│├───┤│ ", x, y + 4);
                            Animation.WriteAt(" └─┤_│  ", x, y + 5);
                            Animation.WriteAt("         ", x, y + 6);
                            Animation.WriteAt("         ", x, y + 7);
                            Thread.Sleep(moveDelay);
                            break;

                    }
                }
            }
            Console.Clear();
            DefaultSceneGg();
        }
        static void TwentieEigthFrame()
        {
            int x = 27;
            int y = 23;
            Animation.WriteAt(" ┌──────────────────────┐", x, y++);
            Animation.WriteAt(" │  It remains to save  │", x, y++);
            Animation.WriteAt(" │ the project and the  │", x, y++);
            Animation.WriteAt(" │      work is done    │", x, y++);
            Animation.WriteAt(" └──────────────────────┘>>", x, y++);
            Thread.Sleep(1000);
            Animation.WriteAt("Press Enter to save.", 95, 2);
        }
        static void TwentieNinthFrame()
        {
            Console.Clear();
            DefaultSceneGg();
            int x = 31;
            int y = 23;
            Animation.WriteAt(" ┌───────────────────┐", x, y++);
            Animation.WriteAt(" │   What happened   │", x, y++);
            Animation.WriteAt(" │  to the computer? │", x, y++);
            Animation.WriteAt(" └───────────────────┘>>", x, y++);
        }
        static void ThirtyFrame()
        {
            Console.Clear();
            DefaultSceneGg();
            int x = 34;
            int y = 23;
            Animation.WriteAt(" ┌────────────────┐", x, y++);
            Animation.WriteAt(" │     I think    │", x, y++);
            Animation.WriteAt(" │ It's a malware │", x, y++);
            Animation.WriteAt(" └────────────────┘>>", x, y++);
        }
        static void ThirtyFirstFrame()
        {
            //Console.Clear();
            //DefaultSceneGg();
            int x = 32;
            int y = 22;
            Animation.WriteAt(" ┌──────────────────┐", x, y++);
            Animation.WriteAt(" │   I can't save   │", x, y++);
            Animation.WriteAt(" │ the project,have │", x, y++);
            Animation.WriteAt(" │ to call the Boss │", x, y++);
            Animation.WriteAt(" └──────────────────┘>>", x, y++);
            Thread.Sleep(1700);
            Animation.WriteAt("Go to the telephone and ", 95, 2);
            Animation.WriteAt("press Enter to call the Boss.", 92, 3);
        }
        public static void DefaultSceneWithColleagues()
        {
            Console.Write(@"|     
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
|                                                                                                                                                                                                               |
|                          ____                          ____                          ____                          ____                                                                                       |
|                         ||""""||                        ||""""||                        ||""""||                        ||""""||                                                                                      |
|                         ||__||                        ,---,|                        ||__||                        ,___,|                                                                                      |
|                         [ -=.]`)                      │___│]`)                      [ -=.]`)                      |,,,|]`)                                                                                    |
|                        |------|                      (|___|)|                      |------|                      ||___|-|                                                                                     |
|                        |  --  |                      |\_║_/ |                      |  --  |                      |{_║_} |                                                                                     |
|                        |------|                      ||=║=|-|                      |------|                      ||=║=|-|                                                                                     |
|                          ___                           | |                           ___                           | |                                                                                        |
|                         |___|                                                       |___|                                                                                                                     |
|                         |_ _|                                                       |_ _|                                                                                  _________                          |
|                           ║                                                           ║                                                                                   / ,,____, \:.                       |
|                         |=║=|      ___                                              |=║=|                                    ___                                          |_||[][]|_|:  :                     |
|                          | |      |___|                                              | |                                    |___|                                  \----    / [][] \   :  :--\                |
|                                   |_ _|                                                                                     |_ _|                                  |\      |________|   ..    \               |
|                                     ║                            ┌───┐                          ┌─┐                           ║                                    | |------------------------|               |
|                                   |===|                          │- -│                        ─┬┴─┴┬─                       |===|                                  | |===========|________|---|               |
|                                    |'|                           │ # │                         │0_0│                         |'|                                     |           |        |___|               |
|                                     ____                        /└───┘\                       ('---')                         ____                                                                            |
|                                    |    |                       \ ____/                       \ ____/                        |    |                                                                           |
|                                    |[--]|                        |[--]|                        |[--]|                        |[--]|                                                                           |
|                                  ('[____]                      ('[____]                      ('[____]                      ('[____]                                                                           |
|                                   |------|                      |------|                      |------|                      |------|                                                                          |
|                                   |______|                      |______|                      |______|                      |______|                                                                          |
|                                   |      |                      |      |                      |      |                      |      |                                                                          |
|                                                                                                                                                                                                               |");
        }
        public static void DefaultSceneWithOutTwoColleagues()
        {
            Console.Write(@"|     
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
|                         |___|                                                       |___|                         |___|                                                                                       |
|                         |_ _|                                                       |_ _|                         |_ _|                                                    _________                          |
|                           ║                                                           ║                             ║                                                     / ,,____, \:.                       |
|                         |=║=|      ___                                              |=║=|      ___                |=║=|      ___                                          |_||[][]|_|:  :                     |
|                          | |      |___|                                              | |      |___|                | |      |___|                                  \----    / [][] \   :  :--\                |
|                                   |_ _|                          ┌───┐                        |_ _|                         |_ _|                                  |\      |________|   ..    \               |
|                                     ║                            │- -│                          ║                             ║                                    | |------------------------|               |
|                                   |===|                          │ # │                        |===|                         |===|                                  | |===========|________|---|               |
|                                    |'|                          /└───┘\                        |'|                           |'|                                     |           |        |___|               |
|                                     ____                        \ ____/                         ____                          ____                                                                            |
|                                    |    |                        |    |                        |    |                        |    |                                                                           |
|                                    |[--]|                        |[--]|                        |[--]|                        |[--]|                                                                           |
|                                  ('[____]                      ('[____]                      ('[____]                      ('[____]                                                                           |
|                                   |------|                      |------|                      |------|                      |------|                                                                          |
|                                   |______|                      |______|                      |______|                      |______|                                                                          |
|                                   |      |                      |      |                      |      |                      |      |                                                                          |
|                                                                                                                                                                                                               |");
        }

        public static void DefaultSceneGg()
        {
            Console.Write(@"|     
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
|                                     ║                             ║                             ║                             ║                                    | |------------------------|               |
|                                   |===|                         |===|                         |===|                         |===|                                  | |===========|________|---|               |
|                                    |'|                           |'|                           |'|                           |'|                                     |           |        |___|               |
|                                     ____                          ____                          ____                          ____                                                                            |
|                                    |    |                        |    |                        |    |                        |    |                                                                           |
|                                    |[--]|                        |[--]|                        |[--]|                        |[--]|                                                                           |
|                                  ('[____]                      ('[____]                      ('[____]                      ('[____]                                                                           |
|                                   |------|                      |------|                      |------|                      |------|                                                                          |
|                                   |______|                      |______|                      |______|                      |______|                                                                          |
|                                   |      |                      |      |                      |      |                      |      |                                                                          |
|                                                                                                                                                                                                               |");

        }
    }
}
