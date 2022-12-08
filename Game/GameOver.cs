using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Game
{
    internal class GameOver
    {
        public static void Deth()
        {
            Clear();
            CursorVisible = false;
            WindowWidth = 210;
            BufferWidth = 210;
            WindowHeight = 50;
            BufferHeight = 50;
            Animation.WriteAt("GameOver", 15, 5);

        }
    }
}
