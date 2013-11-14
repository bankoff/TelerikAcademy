using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;


            //01.   The AcademyPopcorn class contains an IndestructibleBlock class. 
            //      Use it to create side and ceiling walls to the game. You can 
            //      ONLY edit the AcademyPopcornMain.cs file.
            for (int i = 0; i < WorldRows; i++)
            {
                Block LeftBorder = new IndestructibleBlock(new MatrixCoords(i, 0));
                Block RigthBorder = new IndestructibleBlock(new MatrixCoords(i, WorldCols-1));
               
                engine.AddObject(LeftBorder);
                engine.AddObject(RigthBorder);
            }

            for (int i = 0; i < WorldCols-1; i++)
            {
                Block UpBorder = new IndestructibleBlock(new MatrixCoords(0,i));

                engine.AddObject(UpBorder);
            }


            ////Task 02 - test sleeptime
            //engine.SleepTime = 100;


            ////Task 05 - test the TrailObject by adding an instance of it in the engine through the AcademyPopcornMain.cs file.
            //TrailObject trail = new TrailObject(new MatrixCoords(WorldRows / 2, WorldCols / 2), new char[,] { { '%' } }, 20);
            //engine.AddObject(trail);


            ////07.     Test the MeteoriteBall by replacing the normal ball in the AcademyPopcornMain.cs file.
            //Ball theMeteoriteBall = new MeteoriteBall(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1));
            //engine.AddObject(theMeteoriteBall);

            Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1));
            engine.AddObject(theBall);


            ////09.   Test the UnpassableBlock and the UnstoppableBall by adding them to the engine in AcademyPopcornMain.cs file
            //for (int i = 10; i < WorldCols - 10; i++)
            //{
            //    //create an unpassable block         
            //    UnpassableBlock unpassableBlock = new UnpassableBlock(new MatrixCoords(10, i));
            //    engine.AddObject(unpassableBlock);
            //}

            //UnstoppableBall ultimateBall = new UnstoppableBall(new MatrixCoords(WorldRows / 2, 10), new MatrixCoords(-1, 1));
            //engine.AddObject(ultimateBall);


            ////10.   Test ExplodingBlock
            //for (int i = startCol; i < endCol; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        ExplodingBlock currBlock = new ExplodingBlock(new MatrixCoords(startRow + 1, i));
            //        engine.AddObject(currBlock);
            //    }
            //    else
            //    {
            //        Block currBlock = new Block(new MatrixCoords(startRow + 1, i));
            //        engine.AddObject(currBlock);
            //    }
            //}


            ////12.   Test the Gift and GiftBlock classes by adding them through the AcademyPopcornMain.cs file.
            //for (int i = startCol + 5; i < endCol - 5; i++)
            //{
            //    GiftBlock currBlock = new GiftBlock(new MatrixCoords(startRow + 10, i));
            //    engine.AddObject(currBlock);
            //}


            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));

                engine.AddObject(currBlock);
            }
    
            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);
            engine.AddObject(theRacket);


            //TODO - Task 13: Implementing Shooting Ability
            Racket newRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);
            engine.AddObject(theRacket);     
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            Engine gameEngine = new Engine(renderer, keyboard);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
