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
        public static void TableLamp(int xCoordinate, int yCoordinate)
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
        public static void Bed(int xCoordinate, int yCoordinate)
        {
            Animation.WriteAt("  ()___", xCoordinate, yCoordinate++);
            Animation.WriteAt("()//__/)_________________()", xCoordinate, yCoordinate++);
            Animation.WriteAt("||(___)//#/_/#/_/#/_/#()/||", xCoordinate, yCoordinate++);
            Animation.WriteAt("||----|#| |#|_|#|_|#|_|| ||", xCoordinate, yCoordinate++);
            Animation.WriteAt("||____|_|#|_|#|_|#|_|#||/|||", xCoordinate, yCoordinate++);
            Animation.WriteAt("||                    ||", xCoordinate, yCoordinate++);
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

