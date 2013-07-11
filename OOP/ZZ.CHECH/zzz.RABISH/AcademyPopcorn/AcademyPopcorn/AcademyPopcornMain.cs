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

            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));

                engine.AddObject(currBlock);
            }

            for (int i = startCol - 1; i < endCol + 1; i++)
            {
                IndestructibleBlock wallBlock = new IndestructibleBlock(new MatrixCoords(startRow - 1, i));
                engine.AddObject(wallBlock);
            }
            for (int i = startRow; i < WorldRows; i++)
            {
                IndestructibleBlock wallBlock = new IndestructibleBlock(new MatrixCoords(i, startCol - 1));
                IndestructibleBlock wallBlock2 = new IndestructibleBlock(new MatrixCoords(i, endCol));
                engine.AddObject(wallBlock);
                engine.AddObject(wallBlock2);
            }

            //create a row of GiftBlocks
            for (int i = startCol; i < endCol; i++)
            {
                GiftBlock currBlock = new GiftBlock(new MatrixCoords(startRow+4, i));

                engine.AddObject(currBlock);
            }

            //Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0),
            //    new MatrixCoords(-1, 1));

            //replace the normal ball with Meteorite ball
            //MeteoriteBall theMeteoriteBall = new MeteoriteBall(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1));
            //engine.AddObject(theMeteoriteBall);

            //replace the MeteroriteBall with Unstoppable Ball
            Ball theUnstopableBall = new UnstoppableBall(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1));
            engine.AddObject(theUnstopableBall);

            //put some unpassable blocks
            for (int i = 2; i < WorldCols; i += 5)
            {
                engine.AddObject(new UnpassableBlock(new MatrixCoords(4, i)));
            }

            //create a sample Gift for testing 
            Gift gift = new Gift(new MatrixCoords(1, WorldCols / 2));

            engine.AddObject(gift);
            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            TrailObject newTestTrailObject = new TrailObject(new MatrixCoords(startRow  + 10, startCol + 10), new char[,] { { 'V' } }, 20);
            engine.AddObject(newTestTrailObject);

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
