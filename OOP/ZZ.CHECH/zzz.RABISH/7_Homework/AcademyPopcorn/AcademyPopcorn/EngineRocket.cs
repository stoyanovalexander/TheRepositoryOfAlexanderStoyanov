using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class EngineRocket : Engine
    {
        public EngineRocket(IRenderer renderer, IUserInterface userInterface)
            : base(renderer, userInterface)        
        {}

        public void ShootPlayerRacket()
        { }
    }
}
