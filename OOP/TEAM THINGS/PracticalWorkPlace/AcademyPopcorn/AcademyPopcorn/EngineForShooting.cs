using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Task4: EmptyMethodForShooting
namespace AcademyPopcorn
{
    public class EngineForShooting : Engine
    {
        public EngineForShooting(IRenderer renderer, IUserInterface userInterface)
            : base(renderer, userInterface)
        {
        }

        public void ShootRacket()
        {
        }
    }
}
//=============================================================