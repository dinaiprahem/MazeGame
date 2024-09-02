using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class Wall : IMazeObjects
    {
        public bool IsSolid
        {
            get => true;
        }

        public char Icon { get => '#'; }
    }
}
