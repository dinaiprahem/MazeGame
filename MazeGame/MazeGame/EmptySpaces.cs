using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class EmptySpaces : IMazeObjects
    {
        public bool IsSolid {
            get => false;
        }

        public char  Icon {get => ' '; }
    }
}
