﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class Base : IA
    {
        public string Name => throw new NotImplementedException();

        public int X => throw new NotImplementedException();

        public void ShowItem() => throw new NotImplementedException();

        public int Print(int a, int b)
        {
            throw new NotImplementedException();
        }

        public static int IPrint() => throw new NotImplementedException();   

        int IA.IAPrint(int i)
        {
            i = 10;
            return i;
        }

        int IA.IPrint(int i)
        {
            i = (i + 20) % 10;
            return i;
        }


        public void ShowInB()
        {
            Console.WriteLine("Hello Show in B");
        }
    }
}
