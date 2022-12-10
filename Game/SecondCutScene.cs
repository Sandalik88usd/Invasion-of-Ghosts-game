using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Game
{
    internal class SecondCutScene
    {
        public static void PlaySecondCutScene()
        {
            Clear();
            DefaultScene();
            Animation.MainCharacterFaceOnScreen(57,17);
            Animation.HeadOfMainCharacter(5, 36);
            //Animation.TalkingMouth(9, 42, 50);
            int number = 0;
            for (int j = 0; j < 5; j++)
            {
                Phrases(number++);
                for (int i = 0; i < 8; i++)
                    Animation.TalkingMouth(9, 42, 100);
                Thread.Sleep(700);
            }
            Thread.Sleep(1000);

        }
        static void DefaultScene()
        {
            Write(@"|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|                                                                                                                                                                                                               |
|                                                                                                                                                                                                               |
|                                                                                               ┌─────────────────┐                                                                                             |
|                                                                                               │|---------------|│                                                                    x@x                      |
|                                                                                               │|      │ │      |│                                                                   /\ /\                     |
|                                                       __________                              │|______│ │______|│                          __________                               | | X                     |
|                                                      |  __  __  |                             │|------│ │------|│                         |  __  __  |                              X | |                     |
|                                                      | |  ||  | |                             │|      │ │      |│                         | |  ||  | |                              x X x@                    |
|                                                      | |  ||  | |                             │|      │ │      |│                         | |  ||  | |                              | X x                     |
|              //==============//│                     | |__||__| |                             │|---------------|│                         | |__||__| |                              x x X                     |
|             //   *          // │                     |  __  __()|                             └─────────────────┘                         |  __  __()|                              X @ |                     |
|            // @        ,   // /│                     | |  ||  | |                                                                         | |  ||  | |                              X | |                     |
|           //         *    // //│                     | |  ||  | |                                                                         | |  ||  | |                             _|___|_                    |
|          // '    .       // // │                     | |__||__| |                                                                         | |__||__| |                            \       /                   |
|=========//              // // /│=====================|__________|=========================================================================|__________|============================ |: : :|====================|
|        //    .         // // /|│                                                                                                                                                   `_____'                    |
|       //          *   // // /│|│                                                                                                                                                                              |
|      //       @      // // /|│|│                                                                                                                                                                              |
|     //              // // /│|│|│                                                                                                                                                                              |
|    //  .        '  // // /G│|│/│                                                                                                                                         _____________                        |
|    |===============│ // /|h│|/ │                                                                                                                                        │\            \                       |
|    |***************│// /||o│/  │                                                                                                                                        │ \           │\                      |
|    |===============│/ /│||s/   │                                                                                                                                        │__\__________│ \                     |
|    |***************│ /|│||/    │                                                                                                                                        │\  \         │\ \                    |
|    |***************│/a|│|/|____│                                          _____      ___.--------'``````:``````'--------.___                                            │ \  \        │ \ \                   |
|    |===============├┐b|│/ /┌┐ /│                                         /     \    (   |               :               |   )                                           │  \  \--..   │  \ \                  |
|    |               ││c|/ / └┘//│                                        / /   \ \    \  |               :               |  /                                            │ . \.'\-.,'  │ O \ \                 |
|    |               ││d/ / \ // │                                       / /     \ \    \,;,,,            :               | /                                             │o  /\@\ `.-: │    \ \                |
|    |               ├┘/ / \ //  │                                      /____ _ ____\   |\%%%%\___________:__________/~~~~~/|                                             │ . > \<┌─────┼───────┐               |
|    |***************│/ /*  /|   │                                           | |       / ,\%%%%\          |         / @*@ /, \                                            │____`.\│',`__│    o \│               |
|    |               │ // ,/||O /│                                           | |      /_ / `````          |         ~~~~~~ \ _\                                           \ *    `│'----\---O--o│               |
|    |***************│/┌┐///|| //                                            | |     (@l)                 |                 (@l)                                          │\ \|/  │  ^ _\_   o  │               |
|    |  *   *   *   *│ └┘// ||//                                             | |      ||__________________|__________________||                                           │ \ o_  │ \\/  o\.o   │               |
|    |*   *   *   *  │  // O| /                                              | |      ||_____________________________________||                                           │  \<_><│ //\___=\    │               |
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
        static void Phrases(int number)
        {
            int y = 37;
            int x = 35;
            switch (number)
            {
                case 0:
                    Animation.WriteAt("What happened, did I see a ghost on the way home. Who was it? Halloween is already over.", x, y);
                    break;
                case 1:
                    Animation.WriteAt("Also, at work, casts on the computer and scanner, this does not seem to be a coincidence.", x, y + 2);
                    break;
                case 2:
                    Animation.WriteAt("It looks like I'm in my favorite Ghostbusters movie, but I can't believe it.", x, y + 4);
                    break;
                case 3:
                    Animation.WriteAt("  .-.   ", 150, 18);
                    Animation.WriteAt(" (* *)  ", 150, 19);
                    Animation.WriteAt(" / ° \\ ", 150, 20);
                    Animation.WriteAt("^(   \\^", 150, 21);
                    Animation.WriteAt("  \\ (_,", 150, 22);
                    Animation.WriteAt("   '-'", 150, 23);
                    Animation.WriteAt("Wait, what are these ghosts in my house? It can't be real, but what if I didn't imagine it.", x, y + 6);
                    break;
                case 4:
                    Animation.WriteAt("I have to take the ghostbusters movie gun in the bedroom that I ordered from amazon and show these ghosts what I'm made of with them if they're real!", x, y + 8);
                    break;
            }
        }
    }
}
