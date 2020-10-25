using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAnimal
{
    public interface IAnimal
    {
        string Name { get; }

        void Move(int x, int y);
    }
}
