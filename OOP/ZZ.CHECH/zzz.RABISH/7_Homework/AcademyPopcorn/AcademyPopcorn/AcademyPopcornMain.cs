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

            //Add left/right/ side walls
            for (int i = startRow - 1; i < WorldRows + 1; i++)
            {
                IndestructibleBlock leftUndestrBlock = new IndestructibleBlock(new MatrixCoords(i, startCol - 2));
                engine.AddObject(leftUndestrBlock);

                IndestructibleBlock rightUndestrBlock = new IndestructibleBlock(new MatrixCoords(i, endCol + 1));
                engine.AddObject(rightUndestrBlock);
            }

            //Add ceiling
            for (int i = startCol - 1; i < WorldCols; i++)
            {
                IndestructibleBlock topUndestrBlock = new IndestructibleBlock(new MatrixCoords(startRow - 1, i));
                engine.AddObject(topUndestrBlock);

            }
            
            //Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0),
            //    new MatrixCoords(-1, 1));
            //engine.AddObject(theBall);

            //Meteorite ball
            MeteoriteBall theMeteoriteBall = new MeteoriteBall(new MatrixCoords(WorldRows / 2, 0),
                new MatrixCoords(-1, 1));
            engine.AddObject(theMeteoriteBall);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

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
