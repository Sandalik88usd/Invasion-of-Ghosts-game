using Game.Do;
using Game.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Game
{
    internal class MoveMentKitchen
    {
        public static void MoveMentInKitchen(int hor, int ver, ref int[] horGhostHitbox, ref int[] horPlayerHitbox, ref int[] verGhostHitbox, ref int gunTriger)
        {
            Kitchen.KitchenRoom();
            if (PlayGame.gunTriger == 0)
                Animation.MainCharacterFaceOnScreen(hor, ver);
            else
            {
                PlayGame.playerPosition = 4;
                Player.WritePlayerWithGun(hor, ver);
            }

            int[] xKitchenSurface = new int[81]; int[] yKitchenSurface = new int[15];
            int ixKitchenSurface = 38; int iyKitchenSurface = 7;
            int[] xKitchenTableWithChairs = new int[64]; int[] yKitchenTableWithChairs = new int[16];
            int ixKitchenTableWithChairs = 119; int iyKitchenTableWithChairs = 24;
            int[] xBackBigKitchenShelf = new int[78]; int[] yBackBigKitchenShelf = new int[14];
            int ixBackBigKitchenShelf = 9; int iyBackBigKitchenShelf = 29;

            for (int j = 0; j < xKitchenSurface.Length; j++)
                xKitchenSurface[j] = ixKitchenSurface++;
            for (int j = 0; j < yKitchenSurface.Length; j++)
                yKitchenSurface[j] = iyKitchenSurface++;

            for (int j = 0; j < xKitchenTableWithChairs.Length; j++)
                xKitchenTableWithChairs[j] = ixKitchenTableWithChairs++;
            for (int j = 0; j < yKitchenTableWithChairs.Length; j++)
                yKitchenTableWithChairs[j] = iyKitchenTableWithChairs++;

            for (int j = 0; j < xBackBigKitchenShelf.Length; j++)
                xBackBigKitchenShelf[j] = ixBackBigKitchenShelf++;
            for (int j = 0; j < yBackBigKitchenShelf.Length; j++)
                yBackBigKitchenShelf[j] = iyBackBigKitchenShelf++;

            int pose = 0;
            SetCursorPosition(hor, ver);
            ConsoleKey key = ReadKey(true).Key;
            int horLong; int verLong;
            while (key != ConsoleKey.Escape && PlayGame.dethTriger == 0 && PlayGame.roomTrigers == 1)
            {
                key = ReadKey(true).Key;
                if (pose == 3)
                    pose = 0;
                horLong = hor;
                verLong = ver + 6;

                for (int i = 0; i < horPlayerHitbox.Length; i++)
                {
                    horPlayerHitbox[i] = horLong;
                    horLong++;
                    for (int j = 0; j < horGhostHitbox.Length; j++)
                    {
                        if (horGhostHitbox[j] == horPlayerHitbox[i] && verGhostHitbox[i] == verLong && GhostsMove.secondGhostLive == 1 && PlayGame.roomTrigers == 1)
                            GameOver.Deth();
                        if (horGhostHitbox[j] == Gun.horGun && verGhostHitbox[i] == Gun.verGun)
                        {
                            GhostsMove.secondGhostLive = 0;
                        }
                    }
                }

                for (int j = 0; j < yKitchenSurface.Length; j++)
                {
                    for (int i = 0; i < xKitchenSurface.Length; i++)
                    {
                        if (xKitchenSurface[i] + 1 == hor && ver == yKitchenSurface[j] + 1)
                            hor++;
                        if (xKitchenSurface[i] - 1 == hor && ver == yKitchenSurface[j] + 1)
                            hor--;
                        if (xKitchenSurface[i] == hor && ver == yKitchenSurface[j] + 2)
                            ver++;
                        //if (xKitchenSurface[i] == hor && ver == yKitchenSurface[j])
                        //    ver--;
                    }
                }
                for (int j = 0; j < yKitchenTableWithChairs.Length; j++)
                {
                    for (int i = 0; i < xKitchenTableWithChairs.Length; i++)
                    {
                        if (xKitchenTableWithChairs[i] + 1 == hor && ver == yKitchenTableWithChairs[j] + 1)
                            hor++;
                        if (xKitchenTableWithChairs[i] - 1 == hor && ver == yKitchenTableWithChairs[j] + 1)
                            hor--;
                        if (xKitchenTableWithChairs[i] == hor && ver == yKitchenTableWithChairs[j] + 2)
                            ver++;
                        if (xKitchenTableWithChairs[i] == hor && ver == yKitchenTableWithChairs[j])
                            ver--;
                    }
                }
                for (int j = 0; j < yBackBigKitchenShelf.Length; j++)
                {
                    for (int i = 0; i < xBackBigKitchenShelf.Length; i++)
                    {
                        if (xBackBigKitchenShelf[i] + 1 == hor && ver == yBackBigKitchenShelf[j] + 1)
                            hor++;
                        if (xBackBigKitchenShelf[i] - 1 == hor && ver == yBackBigKitchenShelf[j] + 1)
                            hor--;
                        //if (xBackBigKitchenShelf[i] == hor && ver == yBackBigKitchenShelf[j] + 2)
                        //    ver++;
                        if (xBackBigKitchenShelf[i] == hor && ver == yBackBigKitchenShelf[j])
                            ver--;
                    }
                }

                for (int j = 13; j < 26; j++)
                {
                    if (j == hor && ver == 16 && key == ConsoleKey.Enter)
                    {
                        PlayGame.roomTrigers = 3;
                        BedRoom.PaintBedRoom();
                        MoveMentBedRoom.MoveMentInBedRoom(hor, ver, ref horGhostHitbox, ref horPlayerHitbox, ref verGhostHitbox, ref gunTriger);
                    }
                }
                for (int j = 170; j < 183; j++)
                {
                    if (j == hor && ver == 16 && key == ConsoleKey.Enter)
                    {
                        PlayGame.roomTrigers = 2;
                        ButhRoom.PaintButhRoom();
                        MoveMentButhRoom.MoveMentInButhRoom(hor, ver, ref horGhostHitbox, ref horPlayerHitbox, ref verGhostHitbox, ref gunTriger);
                       
                    }
                }
                if (key == ConsoleKey.Spacebar && gunTriger == 1)
                {
                    Gun.Shoot(hor, ver);
                    Kitchen.KitchenRoom();
                    Player.WritePlayerWithGun(hor, ver);
                }
                for (int j = 140; j < 153; j++)
                {
                    if (j == hor && ver == 16 && key == ConsoleKey.Enter)
                    {
                        PlayGame.roomTrigers = 0;
                        if(GhostsMove.firstGhostLive == 2)
                            GhostsMove.firstGhostLive = 1;
                        //Hallway.HallwayRoom();
                        //GhostsMove.VerGhostMove(150, 18, ref PlayGame.horGhostHitbox, ref PlayGame.verGhostHitbox);
                        //MoveMentHallway.MoveMentInHallway(hor,ver,ref horGhostHitbox,ref horPlayerHitbox ,ref verGhostHitbox, ref gunTriger);
                        MoveMent.PlayerInHallwayAndVerGhost(hor, ver, 150, 18);
                    }
                }
                if (ver == 16)
                    ver++;
                if (ver == 43)
                    ver--;
                if (hor == 1)
                    hor++;
                if (hor == 196)
                    hor--;
                //MoveMent.LogicMoveMent(hor, ver, pose,key);

                switch (key)
                {
                    case ConsoleKey.RightArrow:
                        hor++;
                        if (gunTriger == 0)
                            Animation.RunRight(pose, hor, ver, ref PlayGame.playerPosition);
                        else
                            Animation.RunRightWithGun(pose, hor, ver, ref PlayGame.playerPosition);
                        pose++;
                        break;

                    case ConsoleKey.LeftArrow:
                        hor--;
                        if (gunTriger == 0)
                            Animation.RunLeft(pose, hor, ver, ref PlayGame.playerPosition);
                        else
                            Animation.RunLeftWithGun(pose, hor, ver, ref PlayGame.playerPosition);
                        pose++;
                        break;

                    case ConsoleKey.UpArrow:
                        ver--;
                        if (gunTriger == 0)
                            Animation.RunUp(pose, hor, ver, ref PlayGame.playerPosition);
                        else
                            Animation.RunUpWithGun(pose, hor, ver, ref PlayGame.playerPosition);
                        pose++;
                        break;

                    case ConsoleKey.DownArrow:
                        ver++;
                        if (gunTriger == 0)
                            Animation.RunDown(pose, hor, ver, ref PlayGame.playerPosition);
                        else
                            Animation.RunDownWithGun(pose, hor, ver, ref PlayGame.playerPosition);
                        pose++;
                        break;
                }
            }
        }
    }
}
