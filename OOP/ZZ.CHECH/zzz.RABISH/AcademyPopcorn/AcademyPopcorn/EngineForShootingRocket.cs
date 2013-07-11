//Inherit the Engine class. Create a method ShootPlayerRacket. Leave it empty for now.

using System;

namespace AcademyPopcorn
{
    public class EngineForShootingRocket : Engine
    {
        public EngineForShootingRocket(IRenderer renderer, IUserInterface userInterface)
            : base(renderer, userInterface)
        {
        }

        public void ShootPlayerRacket()
        {
        }
    }
}
