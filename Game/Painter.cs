using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Painter
    {
        public static void BigTable(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt(@" \-------------\", xCoordinate, yCoordinate++);
            Animation.WriteAt( "  |────────────|", xCoordinate, yCoordinate++);
            Animation.WriteAt( "  |======|_____|", xCoordinate, yCoordinate++);
            Animation.WriteAt( "  |      |     |", xCoordinate, yCoordinate++);
        }

        public static void Scanner(int xCoordinate, int yCoordinate, int scannerState)
        {
            switch(scannerState)
            {
                case 1:
                    //Animation.WriteAt("   .----.", 175, 9);
                    //Animation.WriteAt("   |C>_ |", 175, 10);
                    Animation.WriteAt( "         ", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "         ", xCoordinate, yCoordinate++);
                    Animation.WriteAt( " __________", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "|  ______--|", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"`-/.::::.\-'", xCoordinate, yCoordinate++);
                    Animation.WriteAt( " `________'", xCoordinate, yCoordinate++);
                    break;
                case 2:
                    //Animation.WriteAt("   .----.", 175, 9);
                    //Animation.WriteAt("   |C>_ |", 175, 10);
                    Animation.WriteAt( "   .----.", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "   |C>_ |", xCoordinate, yCoordinate++);
                    Animation.WriteAt( " __|____|__", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "|  ______--|", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"`-/.::::.\-'", xCoordinate, yCoordinate++);
                    Animation.WriteAt( " `________'", xCoordinate, yCoordinate++);
                    break;
                case 3:
                    Animation.WriteAt( "         ", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "   .----.", xCoordinate, yCoordinate++);
                    Animation.WriteAt( " __|C>_ |__", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "|  ______--|", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"`-/.====.\-'", xCoordinate, yCoordinate++);
                    Animation.WriteAt( " `________'", xCoordinate, yCoordinate++);
                    break ;
                case 4:
                    Animation.WriteAt( "         ", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "         ", xCoordinate, yCoordinate++);
                    Animation.WriteAt( " __.----.__", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "|  ______--|", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"`-/.|  |.\-'", xCoordinate, yCoordinate++);
                    Animation.WriteAt( " `___----___'", xCoordinate, yCoordinate++);
                    break;
                case 5:
                    Animation.WriteAt( "         ", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "         ", xCoordinate, yCoordinate++);
                    Animation.WriteAt( " __________", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "|  ______--|", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"`-/|:),|\-'", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "`__|___|__'", xCoordinate, yCoordinate++);
                    break;
                case 6:
                    //Animation.WriteAt("   .----.", 175, 9);
                    //Animation.WriteAt("   |C>_ |", 175, 10);
                    Animation.WriteAt( "         ", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "         ", xCoordinate, yCoordinate++);
                    Animation.WriteAt( " __________", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "|  ______--|", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"`-/.::::.\-'", xCoordinate, yCoordinate++);
                    Animation.WriteAt( " `________'", xCoordinate, yCoordinate++);
                    break;
                case 7:
                    //Animation.WriteAt("   .----.", 175, 9);
                    //Animation.WriteAt("   |C>_ |", 175, 10);
                    Animation.WriteAt( "   .----.", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "   |C>_ |", xCoordinate, yCoordinate++);
                    Animation.WriteAt( " __|____|__", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "|  ______--|", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"`-/.::::.\-'", xCoordinate, yCoordinate++);
                    Animation.WriteAt( " `________'", xCoordinate, yCoordinate++);
                    break;
                case 8:
                    Animation.WriteAt( "         ", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "   .----.", xCoordinate, yCoordinate++);
                    Animation.WriteAt( " __|C>_ |__", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "|  ______--|", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"`-/.====.\-'", xCoordinate, yCoordinate++);
                    Animation.WriteAt( " `________'", xCoordinate, yCoordinate++);
                    break;
                case 9:
                    Animation.WriteAt( "         ", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "         ", xCoordinate, yCoordinate++);
                    Animation.WriteAt( " __________", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "|  ______--|", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"`-/|:),|\-'", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "`__|___|__'", xCoordinate, yCoordinate++);
                    break;

            }
        }

        public static void Cactus(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt("   x@x", xCoordinate, yCoordinate++);
            Animation.WriteAt("  /\\ /\\", xCoordinate, yCoordinate++);
            Animation.WriteAt("  | | X", xCoordinate, yCoordinate++);
            Animation.WriteAt("  X | |", xCoordinate, yCoordinate++);
            Animation.WriteAt("  x X x@", xCoordinate, yCoordinate++);
            Animation.WriteAt("  | X x", xCoordinate, yCoordinate++);
            Animation.WriteAt("  x x X", xCoordinate, yCoordinate++);
            Animation.WriteAt("  X @ |", xCoordinate, yCoordinate++);
            Animation.WriteAt("  X | |", xCoordinate, yCoordinate++);
            Animation.WriteAt(" _|___|_", xCoordinate, yCoordinate++);
            Animation.WriteAt("\\       /", xCoordinate, yCoordinate++);
            Animation.WriteAt(" |: : :|", xCoordinate, yCoordinate++);
            Animation.WriteAt(" `_____'", xCoordinate, yCoordinate++);
        }
        public static void PictureFrame(int xCoordinate, int yCoordinateStart, int yCoorinateEnd)
        {
            Animation.WriteAt("╔═════════════╗", xCoordinate, yCoordinateStart);
            for (int i = yCoordinateStart+1; i != yCoorinateEnd; i++)
                Animation.WriteAt("║             ║", xCoordinate, i);
            Animation.WriteAt("╚═════════════╝", xCoordinate, yCoorinateEnd);
        }
        public static void LongTable(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt(@"\-------------------------\", xCoordinate, yCoordinate++);
            Animation.WriteAt(@"|\                         \", xCoordinate, yCoordinate++);
            Animation.WriteAt( "| |------------------------|", xCoordinate, yCoordinate++);
            Animation.WriteAt( "| |===========|________|---|", xCoordinate, yCoordinate++);
            Animation.WriteAt( "  |           |        |___|", xCoordinate, yCoordinate++);
        }
        public static void Telephone(int xCoordinate, int yCoordinate)
        {
            yCoordinate -= 5;
            Animation.WriteAt(@"   _________", xCoordinate, yCoordinate++);
            Animation.WriteAt(@"  / ,,____, \:.", xCoordinate, yCoordinate++);
            Animation.WriteAt( "  |_||[][]|_|:  :", xCoordinate, yCoordinate++);
            Animation.WriteAt(@"    / [][] \   :  :", xCoordinate, yCoordinate++);
            Animation.WriteAt(@"   |________|   ..", xCoordinate, yCoordinate++);
        }
        public static void PictureInFrame(int xCoordinate, int yCoordinate)
        {
            xCoordinate++;
            yCoordinate++;
            Animation.WriteAt("   ,,,,,,,  ", xCoordinate, yCoordinate++);
            Animation.WriteAt("   │ 0 0 │   ", xCoordinate, yCoordinate++);
            Animation.WriteAt("   │  ─  │   ", xCoordinate, yCoordinate++);
            Animation.WriteAt("  (`─────`)  ", xCoordinate, yCoordinate++);
            Animation.WriteAt("   |─────|   ", xCoordinate, yCoordinate++);
            Animation.WriteAt("<Best Worker>", xCoordinate, yCoordinate++);
        }
        public static void Door(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt(" __________ ", xCoordinate, yCoordinate++);
            Animation.WriteAt("|  __  __  |", xCoordinate, yCoordinate++);
            Animation.WriteAt("| |  ||  | |", xCoordinate, yCoordinate++);
            Animation.WriteAt("| |  ||  | |", xCoordinate, yCoordinate++);
            Animation.WriteAt("| |__||__| |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|  __  __()|", xCoordinate, yCoordinate++);
            Animation.WriteAt("| |  ||  | |", xCoordinate, yCoordinate++);
            Animation.WriteAt("| |  ||  | |", xCoordinate, yCoordinate++);
            Animation.WriteAt("| |__||__| |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|__________|", xCoordinate, yCoordinate++);
        }
        public static void DoorWC(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt(" __________ ", xCoordinate, yCoordinate++);
            Animation.WriteAt("|. . . . . |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|.       . |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|.   WC  . |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|.       . |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|.       .O|", xCoordinate, yCoordinate++);
            Animation.WriteAt("|.       . |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|.       . |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|. . . . . |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|__________|", xCoordinate, yCoordinate++);
        }
        public static void OpenedDoor(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt( " __________ ___________ ", xCoordinate, yCoordinate++);
            Animation.WriteAt(@"|  __  __  |\,         |", xCoordinate, yCoordinate++);
            Animation.WriteAt( "| |  ||  | ||#',_______|", xCoordinate, yCoordinate++);
            Animation.WriteAt( "| |  ||  | ||##|       |", xCoordinate, yCoordinate++);
            Animation.WriteAt( "| |__||__| ||##|       |", xCoordinate, yCoordinate++);
            Animation.WriteAt( "|()  __  __||##|       |", xCoordinate, yCoordinate++);
            Animation.WriteAt( "| |  ||  | ||##, - - - |", xCoordinate, yCoordinate++);
            Animation.WriteAt( "| |  ||  | ||#,        |", xCoordinate, yCoordinate++);
            Animation.WriteAt( "| |__||__| ||.         |", xCoordinate, yCoordinate++);
            Animation.WriteAt( "|__________||__________|", xCoordinate, yCoordinate++);
        }

        public static void Clock(int xCoordinate, int yCoordinate, int arrowState)
        {
            switch(arrowState)
            {
                case 1:
                    Animation.WriteAt( " _______ ", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"/   |   \", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "| ' | ' |", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "|-  .  -|", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "| '   ' |", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"\___|___/", xCoordinate, yCoordinate++);
                    break;
                case 2:
                    Animation.WriteAt( " _______ ", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"/      /\", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "| ' | / |", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "|-  .  -|", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "| '   ' |", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"\___|___/", xCoordinate, yCoordinate++);
                    break;
                case 3:
                    Animation.WriteAt( " _______ ", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"/       \", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "| ' | ' |", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "|-  .---|", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "| '   ' |", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"\___|___/", xCoordinate, yCoordinate++);
                    break;
                case 4:
                    Animation.WriteAt( " _______ ", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"/       \", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "| ' | ' |", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "|-  .  -|", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"| '  \  |", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"\___|_\_/", xCoordinate, yCoordinate++);
                    break;
                case 5:
                    Animation.WriteAt( " _______ ", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"/       \", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "| ' | ' |", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "|-  .  -|", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "| ' | ' |", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"\___|___/", xCoordinate, yCoordinate++);
                    break;
                case 6:
                    Animation.WriteAt( " _______ ", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"/       \", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "| ' | ' |", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "|-  .  -|", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "|  /  ' |", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"\_/_|___/", xCoordinate, yCoordinate++);
                    break;
                case 7:
                    Animation.WriteAt( " _______ ", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"/       \", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "| ' | ' |", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "|---.  -|", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "| '   ' |", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"\___|___/", xCoordinate, yCoordinate++);
                    break;
                case 8:
                    Animation.WriteAt( " _______ ", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"/\      \", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"| \ | ' |", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "|-  .  -|", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "| '   ' |", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"\___|___/", xCoordinate, yCoordinate++);
                    break;
                case 9:
                    Animation.WriteAt( " _______ ", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"/   |   \", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "| ' | ' |", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "|-  .  -|", xCoordinate, yCoordinate++);
                    Animation.WriteAt( "| '   ' |", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"\___|___/", xCoordinate, yCoordinate++);
                    break;
            }
        }

        public static void Tree(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt("  ,@@@@@@@,", xCoordinate, yCoordinate++);
            Animation.WriteAt(" ,@@@@@@/@@,", xCoordinate, yCoordinate++);
            Animation.WriteAt(",@@@@@/@@@@@@,", xCoordinate, yCoordinate++);
            Animation.WriteAt("%,@@@\\@@@/@@@8", xCoordinate, yCoordinate++);
            Animation.WriteAt("&%@@\\@@/ /@@@8", xCoordinate, yCoordinate++);
            Animation.WriteAt(" &@@\\ V /@@' `", xCoordinate, yCoordinate++);
            Animation.WriteAt("      |.|", xCoordinate, yCoordinate++);
            Animation.WriteAt("      | |", xCoordinate, yCoordinate++);
            Animation.WriteAt("      | |", xCoordinate, yCoordinate++);
            Animation.WriteAt("     /  ,\\", xCoordinate, yCoordinate++);
        }

        public static void SmallTree(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt("       _-_ ", xCoordinate, yCoordinate++);
            Animation.WriteAt("    /~~   ~~\\", xCoordinate, yCoordinate++);
            Animation.WriteAt(" /~~         ~~\\", xCoordinate, yCoordinate++);
            Animation.WriteAt("{               }", xCoordinate, yCoordinate++);
            Animation.WriteAt(" \\  _-     -_  /", xCoordinate, yCoordinate++);
            Animation.WriteAt("   ~  \\ //  ~ ", xCoordinate, yCoordinate++);
            Animation.WriteAt("       | |", xCoordinate, yCoordinate++);
            Animation.WriteAt("       | |", xCoordinate, yCoordinate++);
            Animation.WriteAt("      // \\ ", xCoordinate, yCoordinate++);
        }
        public static void Bush(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt("    ###", xCoordinate, yCoordinate++);
            Animation.WriteAt("   #o###", xCoordinate, yCoordinate++);
            Animation.WriteAt(" #####o###", xCoordinate, yCoordinate++);
            Animation.WriteAt("#o#\\#|#/###", xCoordinate, yCoordinate++);
            Animation.WriteAt(" ###\\|/#o#", xCoordinate, yCoordinate++);
            Animation.WriteAt(" #  }|{  #", xCoordinate, yCoordinate++);
            Animation.WriteAt("    }|{", xCoordinate, yCoordinate++);
        }
        public static void Clouds(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt("            _", xCoordinate, yCoordinate++);
            Animation.WriteAt("          (`  ).                   _", xCoordinate, yCoordinate++);
            Animation.WriteAt("         (     ).              .:(`  )`.", xCoordinate, yCoordinate++);
            Animation.WriteAt("        _(       '`.          :(   .    )", xCoordinate, yCoordinate++);
            Animation.WriteAt("    .=(`(      .   )     .--  `.  (    ) )", xCoordinate, yCoordinate++);
            Animation.WriteAt("   ((    (..__.:'-'   .+(   )   ` _`  ) )", xCoordinate, yCoordinate++);
            Animation.WriteAt("   `(       ) )       (   .  )     (   )  ._", xCoordinate, yCoordinate++);
            Animation.WriteAt("     ` __.:'   )     (   (   ))     `-'.-(`  )", xCoordinate, yCoordinate++);
            Animation.WriteAt("  ( )       --'       `- __.'         :(      ))", xCoordinate, yCoordinate++);
            Animation.WriteAt(" (_.'          .')                    `(    )  ))", xCoordinate, yCoordinate++);
            Animation.WriteAt("              (_  )                     ` __.:'", xCoordinate, yCoordinate++);
        }
        public static void Grass(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt(@"\|/", xCoordinate, yCoordinate++);
        }
        public static void Flower(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt(@"\|/", xCoordinate, yCoordinate++);
            Animation.WriteAt(@"/|\", xCoordinate, yCoordinate++);
            Animation.WriteAt(@" |", xCoordinate, yCoordinate++);
            Animation.WriteAt(@"\-/", xCoordinate, yCoordinate++);
        }
        public static void Car(int xCoordinate, int yCoordinate, int wileState)
        {
            switch (wileState)
            {
                case 1:
                    Animation.WriteAt(@"                       ____________________", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"                     //|           |   ,--, \", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"                   //  |           |   │ '│   \", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"      ___________//____|___________|___'──'___()\__________________", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"    /__________________|_=_________|_=___________|_________________{}", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"    [           ______ |           | .           | ==  ______      { }", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"  __[__        /##  ##\|           |             |    /##  ##\    _{# }", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@" {_____)______|@@    @@|___________|_____________|___|@@    @@|__(______}", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"             /  ##__##                              /  ##__##        \", xCoordinate, yCoordinate++);
                    break;
                case 2:
                    Animation.WriteAt(@"                       ____________________", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"                     //|           |   ,--, \", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"                   //  |           |   │ '│   \", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"      ___________//____|___________|___'──'___()\__________________", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"    /__________________|_=_________|_=___________|_________________{}", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"    [           ______ |           | .           | ==  ______      { }", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"  __[__        /@@  ##\|           |             |    /@@  ##\    _{# }", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@" {_____)______|##    ##|___________|_____________|___|##    ##|__(______}", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"             /  ##__@@                              /  ##__@@        \", xCoordinate, yCoordinate++);
                    break;
                case 3:
                    Animation.WriteAt(@"                       ____________________", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"                     //|           |   ,--, \", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"                   //  |           |   │ '│   \", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"      ___________//____|___________|___'──'___()\__________________", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"    /__________________|_=_________|_=___________|_________________{}", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"    [           ______ |           | .           | ==  ______      { }", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"  __[__        /##  @@\|           |             |    /##  @@\    _{# }", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@" {_____)______|##    ##|___________|_____________|___|##    ##|__(______}", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"             /  @@__##                              /  @@__##        \", xCoordinate, yCoordinate++);
                    break;
            }
        }
        public static void Ghost(int xCoordinate, int yCoordinate, int wileState)
        {
            switch (wileState)
            {
                case 1:
                    Animation.WriteAt(@"    .-. ", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"  .'   `. ", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"  :g g  | ", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"  : o   . ", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@" :       `. ", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@":  :     . `. ", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@":   :     `. ``; ", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@" `.. :      `:' ", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"    `:        `.    . ", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"      `---..,___`;.-' ", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"                     ", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"                        ", xCoordinate, yCoordinate++);
                    break;
                //case 2:
                //    Animation.WriteAt(@"                       ____________________", xCoordinate, yCoordinate++);
                //    Animation.WriteAt(@"                     //|           |   ,--, \", xCoordinate, yCoordinate++);
                //    Animation.WriteAt(@"                   //  |           |   │ '│   \", xCoordinate, yCoordinate++);
                //    Animation.WriteAt(@"      ___________//____|___________|___'──'___()\__________________", xCoordinate, yCoordinate++);
                //    Animation.WriteAt(@"    /__________________|_=_________|_=___________|_________________{}", xCoordinate, yCoordinate++);
                //    Animation.WriteAt(@"    [           ______ |           | .           | ==  ______      { }", xCoordinate, yCoordinate++);
                //    Animation.WriteAt(@"  __[__        /@@  ##\|           |             |    /@@  ##\    _{# }", xCoordinate, yCoordinate++);
                //    Animation.WriteAt(@" {_____)______|##    ##|___________|_____________|___|##    ##|__(______}", xCoordinate, yCoordinate++);
                //    Animation.WriteAt(@"             /  ##__@@                              /  ##__@@        \", xCoordinate, yCoordinate++);
                //    break;
                case 2:
                    Animation.WriteAt(@"    .-. ", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"  .'   `. ", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"  :g g  | ", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"  : o   . ", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@" :       `. ", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@":  :     . `. ", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@":   :     `. ``; ", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@" `.. :      `:' ", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"    `:        `.      ", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"      `---..,___`;    ", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"              -___`_   ", xCoordinate, yCoordinate++);
                    Animation.WriteAt(@"                    '. ", xCoordinate, yCoordinate++);
                    break;
            }
        }
        public static void Window(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt(" ┌─────────────────┐", xCoordinate, yCoordinate++);
            Animation.WriteAt(" │|---------------|│", xCoordinate, yCoordinate++);
            Animation.WriteAt(" │|      │ │      |│", xCoordinate, yCoordinate++);
            Animation.WriteAt(" │|______│ │______|│", xCoordinate, yCoordinate++);
            Animation.WriteAt(" │|------│ │------|│", xCoordinate, yCoordinate++);
            Animation.WriteAt(" │|      │ │      |│", xCoordinate, yCoordinate++);
            Animation.WriteAt(" │|      │ │      |│", xCoordinate, yCoordinate++);
            Animation.WriteAt(" │|---------------|│", xCoordinate, yCoordinate++);
            Animation.WriteAt(" └─────────────────┘", xCoordinate, yCoordinate++);
        }
        public static void Towel(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt("    ________", xCoordinate, yCoordinate++);
            Animation.WriteAt("[==|       |===]", xCoordinate, yCoordinate++);
            Animation.WriteAt("   |=======||", xCoordinate, yCoordinate++);
            Animation.WriteAt("   |=======||", xCoordinate, yCoordinate++);
            Animation.WriteAt("   '\"'\"\"\"\"''|", xCoordinate, yCoordinate++);
            Animation.WriteAt("    |       |", xCoordinate, yCoordinate++);
            Animation.WriteAt("    '\"\"'\"\"\"''", xCoordinate, yCoordinate++);
        }
        public static void ToiletPaper(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt("  ,--.", xCoordinate, yCoordinate++);
            Animation.WriteAt("[=|__|=]", xCoordinate, yCoordinate++);
            Animation.WriteAt("  (-(", xCoordinate, yCoordinate++);
            Animation.WriteAt("   )-)", xCoordinate, yCoordinate++);
            Animation.WriteAt("  (-(", xCoordinate, yCoordinate++);
            Animation.WriteAt("   '-`", xCoordinate, yCoordinate++);
        }
        public static void Toilet(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt(".----------.", xCoordinate, yCoordinate++);
            Animation.WriteAt(";----------;", xCoordinate, yCoordinate++);
            Animation.WriteAt("|~~.----.  |", xCoordinate, yCoordinate++);
            Animation.WriteAt("| /      \\ |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|/        \\|", xCoordinate, yCoordinate++);
            Animation.WriteAt("||        ||", xCoordinate, yCoordinate++);
            Animation.WriteAt("| \\ ,  , / |", xCoordinate, yCoordinate++);
            Animation.WriteAt("'-,######,-'", xCoordinate, yCoordinate++);
            Animation.WriteAt(" |##,  ,##|", xCoordinate, yCoordinate++);
            Animation.WriteAt("  \\'####'/", xCoordinate, yCoordinate++);
            Animation.WriteAt("   \\`\"\"`/", xCoordinate, yCoordinate++);
            Animation.WriteAt("   .|  |.", xCoordinate, yCoordinate++);
            Animation.WriteAt("  '------'", xCoordinate, yCoordinate++);
        }
        public static void BigToilet(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt(".----------------.", xCoordinate, yCoordinate++);
            Animation.WriteAt(";----------------;", xCoordinate, yCoordinate++);
            Animation.WriteAt("| ~~ .------.    |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|   /        \\   |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|  /          \\  |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|  |          |  |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|   \\ ,    , /   |", xCoordinate, yCoordinate++);
            Animation.WriteAt("'---,########,---'", xCoordinate, yCoordinate++);
            Animation.WriteAt("   /##'    '##\\", xCoordinate, yCoordinate++);
            Animation.WriteAt("   |##,    ,##|", xCoordinate, yCoordinate++);
            Animation.WriteAt("    \'######'/", xCoordinate, yCoordinate++);
            Animation.WriteAt("     \\`\"\"\"\"`/", xCoordinate, yCoordinate++);
            Animation.WriteAt("      |`\"\"`|", xCoordinate, yCoordinate++);
            Animation.WriteAt("    .-|    |-.", xCoordinate, yCoordinate++);
            Animation.WriteAt("   /  '    '  \\", xCoordinate, yCoordinate++);
            Animation.WriteAt("   '----------'", xCoordinate, yCoordinate++);
        }
        public static void Rakovina(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt("   ______________/;_____________", xCoordinate, yCoordinate++);
            Animation.WriteAt(" /`        .--T--|--T--.        `\\", xCoordinate, yCoordinate++);
            Animation.WriteAt("/_________'------'------'_________\\", xCoordinate, yCoordinate++);
            Animation.WriteAt("'|  _____   ____   ____   _____  |'", xCoordinate, yCoordinate++);
            Animation.WriteAt(" | |__~__| |    | |    | |__~__| |", xCoordinate, yCoordinate++);
            Animation.WriteAt(" |  _____  |    | |    |  _____  |", xCoordinate, yCoordinate++);
            Animation.WriteAt(" | |     | |   {| |}   | |     | |", xCoordinate, yCoordinate++);
            Animation.WriteAt(" | | ~~~ | |    | |    | | ~~~ | |", xCoordinate, yCoordinate++);
            Animation.WriteAt(" |_|_____|_|____|_|____|_|_____|_|", xCoordinate, yCoordinate++);
        }
        public static void ButhMiror(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt(" _____________________________", xCoordinate, yCoordinate++);
            Animation.WriteAt("|  _________________________  |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|O|                         |O|", xCoordinate, yCoordinate++);
            Animation.WriteAt("| | //                      | |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|O|             //          |O|", xCoordinate, yCoordinate++);
            Animation.WriteAt("| |                     //  | |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|O|       //                |O|", xCoordinate, yCoordinate++);
            Animation.WriteAt("| |                         | |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|O|               //        |O|", xCoordinate, yCoordinate++);
            Animation.WriteAt("| | //                      | |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|O|_________________________|O|", xCoordinate, yCoordinate++);
            Animation.WriteAt("|_____________________________|", xCoordinate, yCoordinate++);
        }
        public static void Bed(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt("  ()___", xCoordinate, yCoordinate++);
            Animation.WriteAt("()//__/)_____________________()", xCoordinate, yCoordinate++);
            Animation.WriteAt("||(___)//#/_/#/_/#/_/#/_/#()/||", xCoordinate, yCoordinate++);
            Animation.WriteAt("||----|#|_|#|_|#|_|#|_|#|_|| ||", xCoordinate, yCoordinate++);
            Animation.WriteAt("||    |_|#|_|#|_|#|_|#|_|#|| ||", xCoordinate, yCoordinate++);
            Animation.WriteAt("||====|#|_|#|_|#|_|#|_|#|_||/||", xCoordinate, yCoordinate++);
            Animation.WriteAt("||____|_|#|_|#|_|#|_|_|_|#||/||", xCoordinate, yCoordinate++);
            Animation.WriteAt("||    |_|_|_|_|_|_|_|_|_|_|| ()", xCoordinate, yCoordinate++);
            Animation.WriteAt("()                        ()", xCoordinate, yCoordinate++);
        }
        public static void TableLamp(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt(".--.", xCoordinate, yCoordinate++);
            Animation.WriteAt("|__|", xCoordinate, yCoordinate++);
            Animation.WriteAt(" ()", xCoordinate, yCoordinate++);
            Animation.WriteAt("(__)", xCoordinate, yCoordinate++);
        }
        public static void BedTable(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt("  ____________", xCoordinate, yCoordinate++);
            Animation.WriteAt(" /           /|", xCoordinate, yCoordinate++);
            Animation.WriteAt("/___________/ |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|.____|____.| |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|.____|____.| |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|.____|____.| /", xCoordinate, yCoordinate++);
            Animation.WriteAt("|___________|/|", xCoordinate, yCoordinate++);
            Animation.WriteAt(" ||       ||", xCoordinate, yCoordinate++);
        }
        public static void Shover(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt("   ______| |___________", xCoordinate, yCoordinate++);
            Animation.WriteAt("  /()()()| |()()()()()/|", xCoordinate, yCoordinate++);
            Animation.WriteAt(" / | | |/___\\ | | | |/ |", xCoordinate, yCoordinate++);
            Animation.WriteAt("/  |_|_|/.|'\\_|_|_|_/  |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|___________________|  |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|            8      |  |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|        O       o  |  |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|   o               | 8|", xCoordinate, yCoordinate++);
            Animation.WriteAt("|                O  |  |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|        o          |  |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|   @        8      |@ |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|                   |  |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|             O     |  |", xCoordinate, yCoordinate++);
            Animation.WriteAt("| O                 |  |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|          8        |  |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|      @         O  | o|", xCoordinate, yCoordinate++);
            Animation.WriteAt("|                   |  /", xCoordinate, yCoordinate++);
            Animation.WriteAt("|        O       @  | /", xCoordinate, yCoordinate++);
            Animation.WriteAt("|___________________|/", xCoordinate, yCoordinate++);
        }
        public static void ClothesShelfBack(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt("      ________________  _______________", xCoordinate, yCoordinate++);
            Animation.WriteAt("    .'               .'               .|", xCoordinate, yCoordinate++);
            Animation.WriteAt("  .'               .'               .' |", xCoordinate, yCoordinate++);
            Animation.WriteAt(".'_______________.'______________ .'   |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|._____________.||._____________.|     |", xCoordinate, yCoordinate++);
            Animation.WriteAt("||             ||||             ||     |", xCoordinate, yCoordinate++);
            Animation.WriteAt("||             ||||             ||     |", xCoordinate, yCoordinate++);
            Animation.WriteAt("||             ||||             ||    .|", xCoordinate, yCoordinate++);
            Animation.WriteAt("||_____________||||_____________||  .' |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|               ||               |.'   |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|._____________.||._____________.|     |", xCoordinate, yCoordinate++);
            Animation.WriteAt("||_____________||||_____________||     |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|._____________.||._____________.|     |", xCoordinate, yCoordinate++);
            Animation.WriteAt("||_____________||||_____________||     |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|._____________.||._____________.|     |", xCoordinate, yCoordinate++);
            Animation.WriteAt("||_____________||||_____________||     |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|._____________.||._____________.|     |", xCoordinate, yCoordinate++);
            Animation.WriteAt("||_____________||||_____________||     |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|._____________.||._____________.|    .'", xCoordinate, yCoordinate++);
            Animation.WriteAt("||             ||||             ||  .'", xCoordinate, yCoordinate++);
            Animation.WriteAt("||_____________||||_____________||.'", xCoordinate, yCoordinate++);
            Animation.WriteAt("''------------------------------''", xCoordinate, yCoordinate++);
        }
        public static void SofaChair(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt("     _.--\"\"\"\"\"--._", xCoordinate, yCoordinate++);
            Animation.WriteAt("   .'             '.", xCoordinate, yCoordinate++);
            Animation.WriteAt("  /        o        \\", xCoordinate, yCoordinate++);
            Animation.WriteAt("  |.-. o   o   o .-.|", xCoordinate, yCoordinate++);
            Animation.WriteAt("  /   |  o   o  |   \\", xCoordinate, yCoordinate++);
            Animation.WriteAt(" /--. |_________| .--\\", xCoordinate, yCoordinate++);
            Animation.WriteAt("/ @l \\/o       o\\/ @l \\", xCoordinate, yCoordinate++);
            Animation.WriteAt("|    /___________\\    |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|____:___________:____|", xCoordinate, yCoordinate++);
            Animation.WriteAt("|_____________________|", xCoordinate, yCoordinate++);
            Animation.WriteAt(" (__)             (__)", xCoordinate, yCoordinate++);
        }
        public static void PlazmaTV(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt(" .-------------------.", xCoordinate, yCoordinate++);
            Animation.WriteAt(" |.-----------------.|", xCoordinate, yCoordinate++);
            Animation.WriteAt(" ||                 ||", xCoordinate, yCoordinate++);
            Animation.WriteAt(" || 0_o_o_O         ||", xCoordinate, yCoordinate++);
            Animation.WriteAt(" ||           '--'  ||", xCoordinate, yCoordinate++);
            Animation.WriteAt(" |`-----------------'|", xCoordinate, yCoordinate++);
            Animation.WriteAt(" `-------------------'", xCoordinate, yCoordinate++);
            Animation.WriteAt("  ________|_|_________", xCoordinate, yCoordinate++);
            Animation.WriteAt(" /      /_____\\      /|", xCoordinate, yCoordinate++);
            Animation.WriteAt("/───────────────────/ |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|___________________| |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|___             ___| /", xCoordinate, yCoordinate++);
            Animation.WriteAt("|___|___________|___|/|", xCoordinate, yCoordinate++);
            Animation.WriteAt(" ||               ||", xCoordinate, yCoordinate++);
        }
        public static void GhostbustersPoster(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt("╔═════════════════════════════════════════════════════════════════════════╗", xCoordinate, yCoordinate++);
            Animation.WriteAt("║              _ .-'  / .._               _____ _               _         ║", xCoordinate, yCoordinate++);
            Animation.WriteAt("║           .-:'/ - - \\:::::-.           / ____| |             | |        ║", xCoordinate, yCoordinate++);
            Animation.WriteAt("║         .::: '  e e  ' '-::::.        | |  __| |__   ___  ___| |_       ║", xCoordinate, yCoordinate++);
            Animation.WriteAt("║        ::::'(    ^    )_.::::::       | | |_ | '_ \\ / _ \\/ __| __|      ║", xCoordinate, yCoordinate++);
            Animation.WriteAt("║       ::::.' '.  o   '.::::'.'/_      | |__| | | | | (_) \\__ \\ |_       ║", xCoordinate, yCoordinate++);
            Animation.WriteAt("║   .  :::.'       -  .::::'_   _.:     _\\_____|_| |_|\\___/|___/\\__|      ║", xCoordinate, yCoordinate++);
            Animation.WriteAt("║ .-''---' .'|      .::::'   '''::::   | |             | |                ║", xCoordinate, yCoordinate++);
            Animation.WriteAt("║'. ..-:::'  |    .::::'        ::::   | |__  _   _ ___| |_ ___ _ __ ___  ║", xCoordinate, yCoordinate++);
            Animation.WriteAt("║ '.' ::::    \\ .::::'          ::::   | '_ \\| | | / __| __/ _ \\ '__/ __| ║", xCoordinate, yCoordinate++);
            Animation.WriteAt("║      ::::   .::::'           ::::    | |_) | |_| \\__ \\ ||  __/ |  \\__ \\ ║", xCoordinate, yCoordinate++);
            Animation.WriteAt("║       ::::.::::'._          ::::     |_.__/ \\__,_|___/\\__\\___|_|  |___/ ║", xCoordinate, yCoordinate++);
            Animation.WriteAt("║        ::::::' /  '-      .::::                                         ║", xCoordinate, yCoordinate++);
            //Animation.WriteAt("║         '::::-/__    __.-::::'                                          ║", xCoordinate, yCoordinate++);
            Animation.WriteAt("╚═════════════════════════════════════════════════════════════════════════╝", xCoordinate, yCoordinate++);
        }
        public static void ButhWithGhosts(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt("                          .-.", xCoordinate, yCoordinate++);
            Animation.WriteAt("          .-.            (*.*)", xCoordinate, yCoordinate++);
            Animation.WriteAt("     o8o (* *)          ^/o°8\\", xCoordinate, yCoordinate++);
            Animation.WriteAt("    o8o8^/ ° \\          Oo8OOo^Oo", xCoordinate, yCoordinate++);
            Animation.WriteAt("   Oo(\"\"o8\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"8oo\"\"\"\"\"\"\")", xCoordinate, yCoordinate++);
            Animation.WriteAt("  _   `\\`'                  `'   /'", xCoordinate, yCoordinate++);
            Animation.WriteAt(" (_)    \\                       /", xCoordinate, yCoordinate++);
            Animation.WriteAt("      O  \\                     /", xCoordinate, yCoordinate++);
            Animation.WriteAt("o   .     `-. .-----------. .-'", xCoordinate, yCoordinate++);
            Animation.WriteAt("           (_/             \\_)", xCoordinate, yCoordinate++);
        }
        public static void KitchenTableWithChairs(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt("         _______________________________________", xCoordinate, yCoordinate++);
            Animation.WriteAt("        /                                       /", xCoordinate, yCoordinate++);
            Animation.WriteAt("       /   ( ;     ',  _o_            oo./     /|", xCoordinate, yCoordinate++);
            Animation.WriteAt(" _____/   :--:      '=(   )?      ._o8o8Oo_.  /||", xCoordinate, yCoordinate++);
            Animation.WriteAt("|_/_\\/   C|==|         '-'         \\======/  / _____", xCoordinate, yCoordinate++);
            Animation.WriteAt(" || /     `--'                      `----'  / |_/_\\_|", xCoordinate, yCoordinate++);
            Animation.WriteAt(" ||========================================'   || ||", xCoordinate, yCoordinate++);
            Animation.WriteAt(" || |||   _____                _____    ||     ||=||", xCoordinate, yCoordinate++);
            Animation.WriteAt("     ||  |_/_\\_|              |_/_\\_|   ||     || ||", xCoordinate, yCoordinate++);
            Animation.WriteAt("     ||   || ||                || ||    ||", xCoordinate, yCoordinate++);
            Animation.WriteAt("     ||   ||=||                ||=||    ||", xCoordinate, yCoordinate++);
            Animation.WriteAt("          || ||                || ||", xCoordinate, yCoordinate++);
        }
        public static void BurChair (int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt(" _____", xCoordinate, yCoordinate++);
            Animation.WriteAt("|_/_\\_|", xCoordinate, yCoordinate++);
            Animation.WriteAt(" || ||", xCoordinate, yCoordinate++);
            //Animation.WriteAt(" || ||", xCoordinate, yCoordinate++);
            Animation.WriteAt(" ||=||", xCoordinate, yCoordinate++);
            Animation.WriteAt(" || ||", xCoordinate, yCoordinate++);
        }
        public static void ToolBoxes(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt("      ________________  _______________", xCoordinate, yCoordinate++);
            Animation.WriteAt("    .'               .'               .|", xCoordinate, yCoordinate++);
            Animation.WriteAt("  .'               .'               .' |", xCoordinate, yCoordinate++);
            Animation.WriteAt(".'_______________.'______________ .'   |", xCoordinate, yCoordinate++);
            Animation.WriteAt("| ___ _____ ___ || ___ _____ ___ |     |", xCoordinate, yCoordinate++);
            Animation.WriteAt("||_=_|__=__|_=_||||_=_|__=__|_=_||     |", xCoordinate, yCoordinate++);
            Animation.WriteAt("||_____===_____||||_____===_____||     |", xCoordinate, yCoordinate++);
            Animation.WriteAt("||_____===_____||||_____===_____||    .|", xCoordinate, yCoordinate++);
            Animation.WriteAt("||_____===_____||||_____===_____||  .' |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|_______________||_______________|.'   |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|.-----___-----.||.-----___-----.|     |", xCoordinate, yCoordinate++);
            Animation.WriteAt("||_____________||||_____________||     |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|.-----___-----.||.-----___-----.|     |", xCoordinate, yCoordinate++);
            Animation.WriteAt("||_____________||||_____________||     |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|.-----___-----.||.-----___-----.|     |", xCoordinate, yCoordinate++);
            Animation.WriteAt("||_____________||||_____________||     |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|.-----___-----.||.-----___-----.|     |", xCoordinate, yCoordinate++);
            Animation.WriteAt("||             ||||_____________||     |", xCoordinate, yCoordinate++);
            Animation.WriteAt("||             |||.-----___-----.|    .'", xCoordinate, yCoordinate++);
            Animation.WriteAt("||             ||||             ||  .'", xCoordinate, yCoordinate++);
            Animation.WriteAt("||_____________||||_____________||.'", xCoordinate, yCoordinate++);
            Animation.WriteAt("''------------------------------''", xCoordinate, yCoordinate++);
        }
        public static void Sofa(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt("  ___.--------'``````:``````'--------.___", xCoordinate, yCoordinate++);
            Animation.WriteAt(" (   |               :               |   )", xCoordinate, yCoordinate++);
            Animation.WriteAt("  \\  |               :               |  /", xCoordinate, yCoordinate++);
            Animation.WriteAt("   \\,;,,,            :               | /", xCoordinate, yCoordinate++);
            Animation.WriteAt("   |\\%%%%\\___________:__________/~~~~~/|", xCoordinate, yCoordinate++);
            Animation.WriteAt("  / ,\\%%%%\\          |         / @*@ /, \\", xCoordinate, yCoordinate++);
            Animation.WriteAt(" /_ / `````          |         ~~~~~~ \\ _\\", xCoordinate, yCoordinate++);
            Animation.WriteAt("(@l)                 |                 (@l)", xCoordinate, yCoordinate++);
            Animation.WriteAt(" ||__________________|__________________||", xCoordinate, yCoordinate++);
            Animation.WriteAt(" ||_____________________________________||", xCoordinate, yCoordinate++);
            Animation.WriteAt("/_|_____________________________________|_\\", xCoordinate, yCoordinate++);
        }
        public static void SofaWithGhosts(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt("  ___.--------'``````:``````'--------.___", xCoordinate, yCoordinate++);
            Animation.WriteAt(" (   |               :               |   )", xCoordinate, yCoordinate++);
            Animation.WriteAt("  \\  |         .-.  :    .-.         |  /", xCoordinate, yCoordinate++);
            Animation.WriteAt("   \\,;,,,     (* *) :   (* *)        | /", xCoordinate, yCoordinate++);
            Animation.WriteAt("   |\\%%%%\\____/ ° \\_:___/ ° \\___/~~~~~/|", xCoordinate, yCoordinate++);
            Animation.WriteAt("  / ,\\%%%%\\  ^\\   )^|  ^(   \\^ / @*@ /, \\", xCoordinate, yCoordinate++);
            Animation.WriteAt(" /_ / `````  ,_) /  |    \\ (   ~~~~~~ \\ _\\", xCoordinate, yCoordinate++);
            Animation.WriteAt("(@l)          '-'   |     '-'          (@l)", xCoordinate, yCoordinate++);
            Animation.WriteAt(" ||__________________|__________________||", xCoordinate, yCoordinate++);
            Animation.WriteAt(" ||_____________________________________||", xCoordinate, yCoordinate++);
            Animation.WriteAt("/_|_____________________________________|_\\", xCoordinate, yCoordinate++);
        }
        public static void LeftShelf(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt(" _________________ ______________", xCoordinate, yCoordinate++);
            Animation.WriteAt("|.                '.             '.", xCoordinate, yCoordinate++);
            Animation.WriteAt("| '.                '.             '.", xCoordinate, yCoordinate++);
            Animation.WriteAt("|   '._________      '.______________'.", xCoordinate, yCoordinate++);
            Animation.WriteAt("|    | ___ _____ ___ || ___ _____ ___ |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|    ||_=_|__=__|_=_||||_=_|__=__|_=_||", xCoordinate, yCoordinate++);
            Animation.WriteAt("|    ||_____   _____||||_____   _____||", xCoordinate, yCoordinate++);
            Animation.WriteAt(".    ||_____   _____||||_____   _____||", xCoordinate, yCoordinate++);
            Animation.WriteAt(" '.  ||_____===_____||||_____===_____||", xCoordinate, yCoordinate++);
            Animation.WriteAt("   '.|_______________||_______________|", xCoordinate, yCoordinate++);
        }
        public static void BackBigKitchenShelf(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt("         __", xCoordinate, yCoordinate++);
            Animation.WriteAt("        /--\\", xCoordinate, yCoordinate++);
            Animation.WriteAt("       _||||______________________________________________________", xCoordinate, yCoordinate++);
            Animation.WriteAt("    .'  '__'    ____      ___/  \\       ____       .'           .'|", xCoordinate, yCoordinate++);
            Animation.WriteAt("  .'    /__\\  (│__│      ^---\\__/      │__│)     .'           .'  |", xCoordinate, yCoordinate++);
            Animation.WriteAt(".'___________ _________________________________.'___________.'    |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|.          .|.              .|.              .|.          .|     |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|            |                |                |            |     |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|            |                |                |            |     |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|            |                |                |            |     |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|            |                |                |            |    .'", xCoordinate, yCoordinate++);
            Animation.WriteAt("|            |                |                |            |  .'", xCoordinate, yCoordinate++);
            Animation.WriteAt("|.          .|.              .|.              .|.          .|.'", xCoordinate, yCoordinate++);
            Animation.WriteAt("''----------'''------------------------------''''----------''", xCoordinate, yCoordinate++);
        }
        public static void RightShelf(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt("      ____________ ____________", xCoordinate, yCoordinate++);
            Animation.WriteAt("    .'           .'           .|", xCoordinate, yCoordinate++);
            Animation.WriteAt("  .'           .'           .' |", xCoordinate, yCoordinate++);
            Animation.WriteAt(".'___________.'___________.'   |", xCoordinate, yCoordinate++);
            Animation.WriteAt("| _____ ___ || ___ _____ |     |", xCoordinate, yCoordinate++);
            Animation.WriteAt("||__=__|_=_||||_=_|__=__||     |", xCoordinate, yCoordinate++);
            Animation.WriteAt("||___===___||||___===___||    .|", xCoordinate, yCoordinate++);
            Animation.WriteAt("||___===___||||___===___||  .'", xCoordinate, yCoordinate++);
            Animation.WriteAt("|___________||___________|.'", xCoordinate, yCoordinate++);
        }
        public static void KitchenSurface(int xCoordinate, int yCoordinate)
        {

            Animation.WriteAt("                              _", xCoordinate, yCoordinate++);
            Animation.WriteAt("                             //", xCoordinate, yCoordinate++);
            Animation.WriteAt("                            //|", xCoordinate, yCoordinate++);
            Animation.WriteAt("                           (_)|", xCoordinate, yCoordinate++);
            Animation.WriteAt("       _____________________O||O____________________  __________", xCoordinate, yCoordinate++);
            Animation.WriteAt("    .'   ___________    / /  @  / /   /(_)--(_)/   .'  │--│)   .'|", xCoordinate, yCoordinate++);
            Animation.WriteAt("  .'    (___/_     o|  / /_____/ /   /_  --_  /  .'    │__│  .'  |", xCoordinate, yCoordinate++);
            Animation.WriteAt(".'____________\\_____|__/_______/____/(_)__(_)/ .'__________.'    |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|.----------.|.-----___-----.||.-----___-----.||    |_____.----------.", xCoordinate, yCoordinate++);
            Animation.WriteAt("|]          |||_____________||||_____________|||  .' │--│)[          |", xCoordinate, yCoordinate++);
            Animation.WriteAt("||          ||.-----___-----.||.-----___-----.||.'   │__│ |          |", xCoordinate, yCoordinate++);
            Animation.WriteAt("||          |||_____________||||_____________|||==========|          |", xCoordinate, yCoordinate++);
            //Animation.WriteAt("||          ||.-----___-----.||.-----___-----.||    |_____|          |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|]         o|||_____________||||_____________|||  .'_____ [        'o|", xCoordinate, yCoordinate++);
            Animation.WriteAt("||          ||.-----___-----.||.-----___-----.||.'  \\___/ |          |", xCoordinate, yCoordinate++);
            Animation.WriteAt("||__________|||_____________||||_____________|||.'________|__________|", xCoordinate, yCoordinate++);
            Animation.WriteAt("''----------'''------------------------------'''----------'", xCoordinate, yCoordinate++);
 
        }
        public static void Armchair(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt("     _.--\"\"\"\"\"--._", xCoordinate, yCoordinate++);
            Animation.WriteAt("   .'             '.", xCoordinate, yCoordinate++);
            Animation.WriteAt("  /        o        \\", xCoordinate, yCoordinate++);
            Animation.WriteAt("  |.-. o   o   o .-.|", xCoordinate, yCoordinate++);
            Animation.WriteAt("  /   |  o   o  |   \\", xCoordinate, yCoordinate++);
            Animation.WriteAt(" /--. |_________| .--\\", xCoordinate, yCoordinate++);
            Animation.WriteAt("/ @l \\/o       o\\/ @l\r\n\\", xCoordinate, yCoordinate++);
            Animation.WriteAt("|    /___________\\    |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|____:___________:____|", xCoordinate, yCoordinate++);
            Animation.WriteAt("|_____________________|", xCoordinate, yCoordinate++);
            Animation.WriteAt(" (__)             (__)", xCoordinate, yCoordinate++);
        }
        public static void NightStand(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt(" _______", xCoordinate, yCoordinate++);
            Animation.WriteAt("|_o_|_o_|", xCoordinate, yCoordinate++);
            Animation.WriteAt("|___o___|", xCoordinate, yCoordinate++);
            Animation.WriteAt("|___o___|", xCoordinate, yCoordinate++);
            Animation.WriteAt("|___o___|", xCoordinate, yCoordinate++);
            Animation.WriteAt(" ||   ||", xCoordinate, yCoordinate++);
        }
        public static void ShoesStand(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt(" ____________________", xCoordinate, yCoordinate++);
            Animation.WriteAt("|  o  | ,----------, |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|_____| |_===___O__| |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|  o  | | ... ### .| |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|_____|_|_O__ooo___|_|", xCoordinate, yCoordinate++);
            Animation.WriteAt(" (_)              (_)", xCoordinate, yCoordinate++);
        }
        public static void Torchere(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt("    _____", xCoordinate, yCoordinate++);
            Animation.WriteAt("   /     \\", xCoordinate, yCoordinate++);
            Animation.WriteAt("  / /   \\ \\", xCoordinate, yCoordinate++);
            Animation.WriteAt(" / /     \\ \\", xCoordinate, yCoordinate++);
            Animation.WriteAt("/____ _ ____\\", xCoordinate, yCoordinate++);
            Animation.WriteAt("     | |", xCoordinate, yCoordinate++);
            Animation.WriteAt("     | |", xCoordinate, yCoordinate++);
            Animation.WriteAt("     | |", xCoordinate, yCoordinate++);
            Animation.WriteAt("     | |", xCoordinate, yCoordinate++);
            Animation.WriteAt("     | |", xCoordinate, yCoordinate++);
            Animation.WriteAt("     | |", xCoordinate, yCoordinate++);
            Animation.WriteAt("    {___}", xCoordinate, yCoordinate++);
        }
        public static void BigTableLamp(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt(".----.", xCoordinate, yCoordinate++);
            Animation.WriteAt("|    |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|____|", xCoordinate, yCoordinate++);
            Animation.WriteAt("  ()", xCoordinate, yCoordinate++);
            Animation.WriteAt("  )(", xCoordinate, yCoordinate++);
            Animation.WriteAt("  ()", xCoordinate, yCoordinate++);
            Animation.WriteAt("  )(", xCoordinate, yCoordinate++);
            Animation.WriteAt(" (__)", xCoordinate, yCoordinate++);
        }
        public static void BarChair(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt(" _____", xCoordinate, yCoordinate++);
            Animation.WriteAt("|_/_\\_|", xCoordinate, yCoordinate++);
            Animation.WriteAt(" || ||", xCoordinate, yCoordinate++);
            Animation.WriteAt(" || ||", xCoordinate, yCoordinate++);
            Animation.WriteAt(" ||=||", xCoordinate, yCoordinate++);
            Animation.WriteAt(" || ||", xCoordinate, yCoordinate++);
        }
        public static void BackTVOnStand(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt(" .-------------------.", xCoordinate, yCoordinate++);
            Animation.WriteAt(" |.-----------------.|", xCoordinate, yCoordinate++);
            Animation.WriteAt(" ||                 ||", xCoordinate, yCoordinate++);
            Animation.WriteAt(" || 0_o_o_O         ||", xCoordinate, yCoordinate++);
            Animation.WriteAt(" ||           '--'  ||", xCoordinate, yCoordinate++);
            Animation.WriteAt(" |`-----------------'|", xCoordinate, yCoordinate++);
            Animation.WriteAt(" `-------------------'", xCoordinate, yCoordinate++);
            Animation.WriteAt("  ________|_|________", xCoordinate, yCoordinate++);
            Animation.WriteAt(" /      /_____\\     /|", xCoordinate, yCoordinate++);
            Animation.WriteAt("/───────────────────/ |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|___________________| |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|___             ___| /", xCoordinate, yCoordinate++);
            Animation.WriteAt("|___|___________|___|/|", xCoordinate, yCoordinate++);
            Animation.WriteAt(" ||               ||", xCoordinate, yCoordinate++);
        }
        public static void SmallTV(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt("         o", xCoordinate, yCoordinate++);
            Animation.WriteAt("     o   |", xCoordinate, yCoordinate++);
            Animation.WriteAt(".=====\\==|=====.", xCoordinate, yCoordinate++);
            Animation.WriteAt("|          --- |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|o o ┌────┐.--.|", xCoordinate, yCoordinate++);
            Animation.WriteAt("|    │::::│'--'|", xCoordinate, yCoordinate++);
            Animation.WriteAt("|    └────┘    |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|==============|", xCoordinate, yCoordinate++);
            Animation.WriteAt("| |---------.| |", xCoordinate, yCoordinate++);
            Animation.WriteAt("|/            \\|", xCoordinate, yCoordinate++);
            Animation.WriteAt("\"              \"", xCoordinate, yCoordinate++);
        }
        public static void Aquarium(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt(" _____________", xCoordinate, yCoordinate++);
            Animation.WriteAt("│\\            \\", xCoordinate, yCoordinate++);
            Animation.WriteAt("│ \\           │\\", xCoordinate, yCoordinate++);
            Animation.WriteAt("│__\\__________│ \\", xCoordinate, yCoordinate++);
            Animation.WriteAt("│\\  \\         │\\ \\", xCoordinate, yCoordinate++);
            Animation.WriteAt("│ \\  \\        │ \\ \\", xCoordinate, yCoordinate++);
            Animation.WriteAt("│  \\  \\--..   │  \\ \\", xCoordinate, yCoordinate++);
            Animation.WriteAt("│ . \\.'\\-.,'  │ O \\ \\", xCoordinate, yCoordinate++);
            Animation.WriteAt("│o  /\\@\\ `.-: │    \\ \\", xCoordinate, yCoordinate++);
            Animation.WriteAt("│ . > \\<┌─────┼───────┐", xCoordinate, yCoordinate++);
            Animation.WriteAt("│____`.\\│',`__│    o \\│", xCoordinate, yCoordinate++);
            Animation.WriteAt("\\ *    `│'----\\---O--o│", xCoordinate, yCoordinate++);
            Animation.WriteAt("│\\ \\|/  │  ^ _\\_   o  │", xCoordinate, yCoordinate++);
            Animation.WriteAt("│ \\ o_  │ \\\\/  o\\.o   │", xCoordinate, yCoordinate++);
            Animation.WriteAt("│  \\<_><│ //\\___=\\    │", xCoordinate, yCoordinate++);
            Animation.WriteAt("│\\  \\   │ *  ''   \\   │", xCoordinate, yCoordinate++);
            Animation.WriteAt("│ \\  \\ ^│  \\|/  _. \\  │", xCoordinate, yCoordinate++);
            Animation.WriteAt("│  \\  \\ │ o | ><_>. \\ │", xCoordinate, yCoordinate++);
            Animation.WriteAt("│   |  \\│   /\\   o   \\│", xCoordinate, yCoordinate++);
            Animation.WriteAt(" \\ o||\\ ├─────────────┤", xCoordinate, yCoordinate++);
            Animation.WriteAt("  \\ || \\│.           .│", xCoordinate, yCoordinate++);
            Animation.WriteAt("   \\||o │             │", xCoordinate, yCoordinate++);
            Animation.WriteAt("    \\|  │             │", xCoordinate, yCoordinate++);
            Animation.WriteAt("     \\  │             │", xCoordinate, yCoordinate++);
            Animation.WriteAt("      \\ │             │ ", xCoordinate, yCoordinate++);
            Animation.WriteAt("       \\│.           .│", xCoordinate, yCoordinate++);
            Animation.WriteAt("        └─────────────┘", xCoordinate, yCoordinate++);
        }
        public static void Bookshelf(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt("          //==============//│", xCoordinate, yCoordinate++);
            Animation.WriteAt("         //   *          // │", xCoordinate, yCoordinate++);
            Animation.WriteAt("        // @        ,   // /│", xCoordinate, yCoordinate++);
            Animation.WriteAt("       //         *    // //│", xCoordinate, yCoordinate++);
            Animation.WriteAt("      // '    .       // // │", xCoordinate, yCoordinate++);
            Animation.WriteAt("     //              // // /│", xCoordinate, yCoordinate++);
            Animation.WriteAt("    //    .         // // /|│", xCoordinate, yCoordinate++);
            Animation.WriteAt("   //          *   // // /│|│", xCoordinate, yCoordinate++);
            Animation.WriteAt("  //       @      // // /|│|│", xCoordinate, yCoordinate++);
            Animation.WriteAt(" //              // // /│|│|│", xCoordinate, yCoordinate++);
            Animation.WriteAt("//  .        '  // // /G│|│/│", xCoordinate, yCoordinate++);
            Animation.WriteAt("|===============│ // /|h│|/ │", xCoordinate, yCoordinate++);
            Animation.WriteAt("|***************│// /||o│/  │", xCoordinate, yCoordinate++);
            Animation.WriteAt("|===============│/ /│||s/   │", xCoordinate, yCoordinate++);
            Animation.WriteAt("|***************│ /|│||/    │", xCoordinate, yCoordinate++);
            Animation.WriteAt("|***************│/a|│|/|____│", xCoordinate, yCoordinate++);
            Animation.WriteAt("|===============├┐b|│/ /┌┐ /│", xCoordinate, yCoordinate++);
            Animation.WriteAt("|               ││c|/ / └┘//│ ", xCoordinate, yCoordinate++);
            Animation.WriteAt("|               ││d/ / \\ // │", xCoordinate, yCoordinate++);
            Animation.WriteAt("|               ├┘/ / \\ //  │", xCoordinate, yCoordinate++);
            Animation.WriteAt("|***************│/ /*  /|   │", xCoordinate, yCoordinate++);
            Animation.WriteAt("|               │ // ,/||O /│", xCoordinate, yCoordinate++);
            Animation.WriteAt("|***************│/┌┐///|| //", xCoordinate, yCoordinate++);
            Animation.WriteAt("|  *   *   *   *│ └┘// ||//", xCoordinate, yCoordinate++);
            Animation.WriteAt("|*   *   *   *  │  // O| /", xCoordinate, yCoordinate++);
            Animation.WriteAt("|***************│ /||  //", xCoordinate, yCoordinate++);
            Animation.WriteAt("|*   *   *   *  │//|| //", xCoordinate, yCoordinate++);
            Animation.WriteAt("|  *   *   *   *│/,/|//", xCoordinate, yCoordinate++);
            Animation.WriteAt("|---------------│,/||/", xCoordinate, yCoordinate++);
            Animation.WriteAt("|***************│/,//", xCoordinate, yCoordinate++);
            Animation.WriteAt("|---------------│,//", xCoordinate, yCoordinate++);
            Animation.WriteAt("|***************│//", xCoordinate, yCoordinate++);
            Animation.WriteAt("|_______________│/", xCoordinate, yCoordinate++);
        }
    }
}

