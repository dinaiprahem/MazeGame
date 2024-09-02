using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public interface IMazeObjects
    {
        bool IsSolid
        {
            get;
        }
        char Icon
        {
            get;
        }

    }
}
