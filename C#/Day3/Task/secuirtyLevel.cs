using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3SD43_Task
{
    [Flags]
    enum secuirtyLevel : byte
    {
        guest = 0b_0000_1000, Developer = 0b_0000_0100, secretary = 0b_0000_0010, DBA = 0b_0000_0001
    }
}
