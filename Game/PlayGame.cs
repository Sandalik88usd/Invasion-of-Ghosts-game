using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;
using System.Runtime.ConstrainedExecution;
using Game.Rooms;

namespace Game
{
    internal class PlayGame
    {
        public static Thread threadPlayer;
        public static Thread threadGhostInHallway;
        public static int playerPosition = 0;
        public static int roomTrigers = 0;
        public static int gunTriger = 1;
        public static int dethTriger = 0;
        public static int ghostDethTriger = 0;
        public static void StartWorkRoom()
        {
            Clear();
            CursorVisible = false;
            BufferWidth = 210;
            WindowWidth = 210;
            BufferHeight = 50;
            WindowHeight = 50;
            int hor = 57; int ver = 17;
            //int hor = 120; int ver = 18;
            int horGhost = 150; int verGhost = 18;
            int pose = 0;
            int trigersInWorkRoom = 0;
            int[] horGhostHitbox = new int[8];
            int[] verGhostHitbox = new int[8];
            int[] horPlayerHitbox = new int[8];
            int[] verPlayerHitbox = new int[8];
            threadGhostInHallway = new Thread(() => GhostsMove.GhostInHallway(ref horGhost, ref verGhost, ref horGhostHitbox, ref verGhostHitbox));
            threadPlayer = new Thread(() => MoveMentHallway.MoveMentInHallway(hor, ver, ref horGhostHitbox, ref horPlayerHitbox, ref verGhostHitbox, ref gunTriger));
            //FirstCutScene.PlayFirstCutScene();
            //WorkRoom.FrameOfWorkRoom();
            // WorkRoom.PaintWorkRoom();
            //MoveMentWorkRoom.MoveMentInWorkRoom(hor, ver, ref trigersInWorkRoom);
            //SecondCutScene.PlaySecondCutScene();
            Hallway.HallwayRoom();

            threadGhostInHallway.Start();
            Thread.Sleep(200);
            threadPlayer.Start();

            //threadPlayer.Start();
            //Thread.Sleep(200);
            //threadGhostInHallway.Start();

            //Kitchen.KitchenRoom();
            //MoveMentKithen.MoveMentInKitchen(hor,ver,ref gunTriger);

            //ButhRoom.PaintButhRoom();
            //MoveMentButhRoom.MoveMentInButhRoom(hor, ver, ref gunTriger);

            //BedRoom.PaintBedRoom();
            //MoveMentBedRoom.MoveMentInBedRoom(hor, ver, ref gunTriger);

            //End.EndOfGame();

        }


    }
}
