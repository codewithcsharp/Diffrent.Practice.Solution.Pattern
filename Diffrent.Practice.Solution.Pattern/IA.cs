﻿namespace CSharp
{
    public interface IA
    {
        string Name { get; }
        int X { get; }
        static abstract public int IPrint();


        int IAPrint(int i);

        void ShowItem();

        int IPrint(int i)
        {
            i = 10;
            return i;
        }
        int Print(int a, int b);

        // this is not possible - will throw compile time error
        //float Print(int a, int b);
    }
}
