using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class Player:IMazeObjects
    {
        public int X { set; get; }
        public int Y { set; get; }
        public bool IsSolid
        {
            get => true;
        }

        public char Icon { get => '@'; }
    }
}
