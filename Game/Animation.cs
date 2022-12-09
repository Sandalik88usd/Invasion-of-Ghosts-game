using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Animation
    {
        protected static int origRow;
        protected static int origCol;
        public static void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(origCol + x, origRow + y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }
        public static void Boss(int x, int y)
        {
            WriteAt(@" ┌──┬───────┬──┐", x, y++);
            WriteAt(@"┌┴──┘'''''''└──┴┐", x, y++);
            WriteAt(@"│     \   /     │", x, y++);
            WriteAt(@"│ ────     ──── │", x, y++);
            WriteAt(@"\--()--│_│--()--/", x, y++);
            WriteAt(@"│      └─┘      │", x, y++);
            WriteAt(@"│..           ..│", x, y++);
            WriteAt(@"│ ..         . .│", x, y++);
            WriteAt(@"└┐. ... .. ....┌┘", x, y++);
            WriteAt(@" └────┬───┬────┘ ", x, y++);
            WriteAt(@"      │|||│      ", x, y++);
            WriteAt(@" ┌────┴───┴────┐ ", x, y++);
            WriteAt(@"┌┘ , '   ,  '  └┐", x, y++);
            WriteAt(@"│  │ ,       │ ,│", x, y++);
            WriteAt(@"│, │ ., '  , │.,│", x, y++);
            WriteAt(@"│  │         │  │", x, y++);
            WriteAt(@"│, │  , . ,  │ ,│", x, y++);
            WriteAt(@"│||│         │||│", x, y++);
            WriteAt(@"│--├─────────┤--│", x, y++);
            WriteAt(@"└──┤ 0 / \ 0 ├──┘", x, y++);
            WriteAt(@"   │--- │ ---│   ", x, y++);
            //WriteAt(@"   │    │    │   ", x, y++);
            //WriteAt(@"   │___┌┴┐___│   ", x, y++);
            //WriteAt(@"   │ - │ │ - │   ", x, y++);
            //WriteAt(@"   └───┘ └───┘   ", x, y++);
        }
        public static void HeadOfMainCharacter(int x, int y)
        {
            WriteAt(" ,,,,,,,,,,,,,,, ", x, y++);
            WriteAt("│               │", x, y++);
            WriteAt("│    │     │    │", x, y++);
            WriteAt("│ ─┬┬┘     └┬┬─ │", x, y++);
            WriteAt("│  └┘  │ │  └┘  │", x, y++);
            WriteAt("│      └─┘      │", x, y++);
            WriteAt("│               │", x, y++);
            WriteAt("│               │", x, y++);
            WriteAt("└┐             ┌┘", x, y++);
            WriteAt(" └────┬───┬────┘ ", x, y++);

        }
        public static void MainCharacter(int x, int y)
        {
            WriteAt( " ,,,,,,,,,,,,,,, ", x, y++);
            WriteAt( "│               │", x, y++);
            WriteAt( "│    │     │    │", x, y++);
            WriteAt( "│ ─┬┬┘     └┬┬─ │", x, y++);
            WriteAt( "│  └┘  │ │  └┘  │", x, y++);
            WriteAt( "│      └─┘      │", x, y++);
            WriteAt( "│               │", x, y++);
            WriteAt( "│               │", x, y++);
            WriteAt( "└┐             ┌┘", x, y++);
            WriteAt( " └────┬───┬────┘ ", x, y++);
            WriteAt( "      │   │      ", x, y++);
            WriteAt( " ┌────┴───┴────┐ ", x, y++);
            WriteAt(@"┌┘    \ \ /    └┐", x, y++);
            WriteAt(@"│  │   |\|___│  │", x, y++);
            WriteAt(@"│  │   |\|| |│  │", x, y++);
            WriteAt(@"│  │   |\|   │  │", x, y++);
            WriteAt(@"│  │   \_/   │  │", x, y++);
            WriteAt(@"├──┤         ├──┤", x, y++);
            WriteAt(@"│  ├───┬─┬───┤  │", x, y++);
            WriteAt(@"└──┼───┘0└───┼──┘", x, y++);
            WriteAt(@"   │    │    │   ", x, y++);
            //WriteAt(@"   │    │    │   ", x, y++);
            //WriteAt(@"   │___┌┴┐___│   ", x, y++);
            //WriteAt(@"   │ - │ │ - │   ", x, y++);
            //WriteAt(@"   └───┘ └───┘   ", x, y++);
        }
        public static void TalkingMouth(int x, int y, int delay)
        {
            Animation.WriteAt("┌───────┐", x, y);
            Animation.WriteAt("│-------│", x, y+1);
            Animation.WriteAt("└───────┘", x, y+2);
            Thread.Sleep(delay);

            Animation.WriteAt("┌───────┐", x, y);
            Animation.WriteAt("│*$~#*@%│", x, y + 1);
            Animation.WriteAt("└───────┘", x, y + 2);
            Thread.Sleep(delay);

            Animation.WriteAt("┌───────┐", x, y);
            Animation.WriteAt("│┼┼┼┼┼┼┼│", x, y + 1);
            Animation.WriteAt("└───────┘", x, y + 2);
            Thread.Sleep(delay);

            Animation.WriteAt("┌───────┐", x, y);
            Animation.WriteAt("│%@^#($*│", x, y + 1);
            Animation.WriteAt("└───────┘", x, y + 2);
            Thread.Sleep(delay);

            Animation.WriteAt("┌───────┐", x, y);
            Animation.WriteAt("│=======│", x, y + 1);
            Animation.WriteAt("└───────┘", x, y + 2);
            Thread.Sleep(delay);

            Animation.WriteAt("┌───────┐", x, y);
            Animation.WriteAt("│*&!*($^│", x, y + 1);
            Animation.WriteAt("└───────┘", x, y + 2);
            Thread.Sleep(delay);

            Animation.WriteAt( "┌───────┐", x, y);
            Animation.WriteAt(@"│\//\\//│", x, y + 1);
            Animation.WriteAt( "└───────┘", x, y + 2);
            Thread.Sleep(delay); 

            Animation.WriteAt("┌───────┐", x, y);
            Animation.WriteAt("│*@#$*~%│", x, y + 1);
            Animation.WriteAt("└───────┘", x, y + 2);
            Thread.Sleep(delay);
        }
        public static void RunRight(int pose, int hor, int ver, ref int PlayerPosition)
        {
            PlayerPosition = 1;

            switch (pose)
            {
                case 0:
                    WriteAt("         ", hor, ver - 1);
                    WriteAt("   ,--,  ", hor, ver);
                    WriteAt("   │ '│  ", hor, ver + 1);
                    WriteAt("   '──'  ", hor, ver + 2);
                    WriteAt("   │||│  ", hor, ver + 3);
                    WriteAt("   │__│  ", hor, ver + 4);
                    WriteAt("         ", hor, ver + 5);
                    break;
                case 1:
                    WriteAt("         ", hor, ver - 1);
                    WriteAt("   ,--,  ", hor, ver);
                    WriteAt("   │ '│  ", hor, ver + 1);
                    WriteAt("   '──'  ", hor, ver + 2);
                    WriteAt("   │||│  ", hor, ver + 3);
                    WriteAt("   │_─┘  ", hor, ver + 4);
                    WriteAt("         ", hor, ver + 5);
                    break;
                case 2:
                    WriteAt("         ", hor, ver - 1);
                    WriteAt("   ,--,  ", hor, ver);
                    WriteAt("   │ '│  ", hor, ver + 1);
                    WriteAt("   '──'  ", hor, ver + 2);
                    WriteAt("   │||│  ", hor, ver + 3);
                    WriteAt("   └─_│  ", hor, ver + 4);
                    WriteAt("         ", hor, ver + 5);
                    break;
                case 3:
                    WriteAt("         ", hor, ver - 1);
                    WriteAt("   ,--,  ", hor, ver);
                    WriteAt("   │ '│  ", hor, ver + 1);
                    WriteAt("   '──'  ", hor, ver + 2);
                    WriteAt("   │||│  ", hor, ver + 3);
                    WriteAt("   │_─┘  ", hor, ver + 4);
                    WriteAt("         ", hor, ver + 5);
                    break;

            }
        }

        public static void RunLeft(int pose, int hor, int ver, ref int PlayerPosition)
        {
            PlayerPosition = 2;

            switch (pose)
            {
                case 0:
                    WriteAt("         ", hor, ver - 1);
                    WriteAt("  ,--,   ", hor, ver);
                    WriteAt("  │' │   ", hor, ver + 1);
                    WriteAt("  '──'   ", hor, ver + 2);
                    WriteAt("  │||│   ", hor, ver + 3);
                    WriteAt("  │__│   ", hor, ver + 4);
                    WriteAt("         ", hor, ver + 5);
                    break;
                case 1:
                    WriteAt("         ", hor, ver - 1);
                    WriteAt("  ,--,   ", hor, ver);
                    WriteAt("  │' │   ", hor, ver + 1);
                    WriteAt("  '──'   ", hor, ver + 2);
                    WriteAt("  │||│   ", hor, ver + 3);
                    WriteAt("  │_─┘   ", hor, ver + 4);
                    WriteAt("         ", hor, ver + 5);
                    break;
                case 2:
                    WriteAt("         ", hor, ver - 1);
                    WriteAt("  ,--,   ", hor, ver);
                    WriteAt("  │' │   ", hor, ver + 1);
                    WriteAt("  '──'   ", hor, ver + 2);
                    WriteAt("  │||│   ", hor, ver + 3);
                    WriteAt("  └─_│   ", hor, ver + 4);
                    WriteAt("         ", hor, ver + 5);
                    break;
                case 3:
                    WriteAt("         ", hor, ver - 1);
                    WriteAt("  ,--,   ", hor, ver);
                    WriteAt("  │' │   ", hor, ver + 1);
                    WriteAt("  '-─'   ", hor, ver + 2);
                    WriteAt("  │||│   ", hor, ver + 3);
                    WriteAt("  │_─┘   ", hor, ver + 4);
                    WriteAt("         ", hor, ver + 5);
                    break;

            }
        }
        public static void RunUp(int pose, int hor, int ver, ref int PlayerPosition)
        {
            PlayerPosition = 3;

            switch (pose)
            {
                case 0:
                    WriteAt("  ,---,  ", hor, ver);
                    WriteAt("  │,,,│  ", hor, ver + 1);
                    WriteAt(" ('───') ", hor, ver + 2);
                    WriteAt(" │├───┤│ ", hor, ver + 3);
                    WriteAt("  │_|_│  ", hor, ver + 4);
                    WriteAt("         ", hor, ver + 5);
                    WriteAt("         ", hor, ver + 6);
                    break;
                case 1:
                    WriteAt("  ,---,  ", hor, ver);
                    WriteAt("  │,,,│  ", hor, ver + 1);
                    WriteAt(" ('───') ", hor, ver + 2);
                    WriteAt(" │├───┤│ ", hor, ver + 3);
                    WriteAt("  └─┤_│  ", hor, ver + 4);
                    WriteAt("         ", hor, ver + 5);
                    WriteAt("         ", hor, ver + 6);
                    break;
                case 2:
                    WriteAt("  ,---,  ", hor, ver);
                    WriteAt("  │,,,│  ", hor, ver + 1);
                    WriteAt(" ('───') ", hor, ver + 2);
                    WriteAt(" │├───┤│ ", hor, ver + 3);
                    WriteAt("  │_├─┘  ", hor, ver + 4);
                    WriteAt("         ", hor, ver + 5);
                    WriteAt("         ", hor, ver + 6);
                    break;
                case 3:
                    WriteAt("  ,---,  ", hor, ver);
                    WriteAt("  │,,,│  ", hor, ver + 1);
                    WriteAt(" ('───') ", hor, ver + 2);
                    WriteAt(" │├───┤│ ", hor, ver + 3);
                    WriteAt("  └─┤_│  ", hor, ver + 4);
                    WriteAt("         ", hor, ver + 5);
                    WriteAt("         ", hor, ver + 6);
                    break;

            }
        }
        public static void RunDown(int pose, int hor, int ver, ref int PlayerPosition)
        {
            Console.CursorVisible = false;
            PlayerPosition = 4;
            switch (pose)
            {
                case 0:
                    WriteAt("         ", hor, ver - 2);
                    WriteAt("         ", hor, ver - 1);
                    WriteAt("  ,,,,,  ", hor, ver);
                    WriteAt("  │'_'│  ", hor, ver + 1);
                    WriteAt(" ('───') ", hor, ver + 2);
                    WriteAt(" │├───┤│ ", hor, ver + 3);
                    WriteAt("  │_|_│  ", hor, ver + 4);
                    //                   WriteAt("         ", hor, ver + 6);
                    break;
                case 1:
                    WriteAt("         ", hor, ver - 2);
                    WriteAt("         ", hor, ver - 1);
                    WriteAt("  ,,,,,  ", hor, ver);
                    WriteAt("  │'-'│  ", hor, ver + 1);
                    WriteAt(" ('───') ", hor, ver + 2);
                    WriteAt(" │├───┤│ ", hor, ver + 3);
                    WriteAt("  └─┤_│  ", hor, ver + 4);
                    break;
                case 2:
                    WriteAt("         ", hor, ver - 2);
                    WriteAt("         ", hor, ver - 1);
                    WriteAt("  ,,,,,  ", hor, ver);
                    WriteAt("  │'_'│  ", hor, ver + 1);
                    WriteAt(" ('───') ", hor, ver + 2);
                    WriteAt(" │├───┤│ ", hor, ver + 3);
                    WriteAt("  │_├─┘  ", hor, ver + 4);
                    break;
                case 3:
                    WriteAt("         ", hor, ver - 2);
                    WriteAt("         ", hor, ver - 1);
                    WriteAt("  ,,,,,  ", hor, ver);
                    WriteAt("  │'-'│  ", hor, ver + 1);
                    WriteAt(" ('───') ", hor, ver + 2);
                    WriteAt(" │├───┤│ ", hor, ver + 3);
                    WriteAt("  └─┤_│  ", hor, ver + 4);
                    break;

            }
        }

        public static void MainCharacterFaceOnScreen(int hor,int ver)
        {
            //int hor = 43; int ver = 28;
            Animation.WriteAt("  ,,,,,  ", hor, ver++);
            Animation.WriteAt("  │'_'│  ", hor, ver++);
            Animation.WriteAt(" ('───') ", hor, ver++);
            Animation.WriteAt(" │├───┤│ ", hor, ver++);
            Animation.WriteAt("  │_|_│  ", hor, ver++);
        }
    }
}
