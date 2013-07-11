using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Firm
{
    public interface IImportantMassegable
    {
        event EventHandler Advance;

        event EventHandler SaturdayWork;

        event EventHandler Normal;

        void ProcessInput();
    }
}
