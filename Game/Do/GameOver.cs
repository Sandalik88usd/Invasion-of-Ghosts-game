using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Game.Do
{
    internal class GameOver
    {
        public static void Deth()
        {
            PlayGame.dethTriger = 1;
            Clear();
            CursorVisible = false;
            WindowWidth = 70;
            WindowHeight = 25;
            BufferWidth = 70;
            BufferHeight = 25;
            Write("   _____                         ____                 \r\n  / ____|                       / __ \\                \r\n | |  __  __ _ _ __ ___   ___  | |  | |_   _____ _ __ \r\n | | |_ |/ _` | '_ ` _ \\ / _ \\ | |  | \\ \\ / / _ \\ '__|\r\n | |__| | (_| | | | | | |  __/ | |__| |\\ V /  __/ |   \r\n  \\_____|\\__,_|_| |_| |_|\\___|  \\____/  \\_/ \\___|_|   \r\n                                                      \r\n                                                      ");
            ReadKey();


        }
    }
}
