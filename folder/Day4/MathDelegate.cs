﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    // Delegates are objects that take in a function pointer as a value
    //[Access Modifier] "delegate" [return-type] Name (parameters)

    //Delegates are type safe for functions because it must have the same signiture
    // with the delegate
    public delegate void MathDelegate(int a, int b);
}
