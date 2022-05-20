using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.InterfaceApp
{
    public interface ISeconds<T>
    {
        public void Addition(params T[] seconds);
        public void Multiply(T a, T b);
    }
}
