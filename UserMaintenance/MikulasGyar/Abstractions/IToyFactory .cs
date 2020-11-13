using MikulasGyar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikulasGyar.Abstractions
{
    public interface IToyFactory
    {
        Toy CreateNew();
    }
}
