using System;

namespace myDelegate
{
    public class Class1
    {
        delegate void delegateDemo(int i);
        void Start()
        {
            delegateDemo Delegate = chocolate;
            Delegate(45);
        }

        void chocolate(int i) //Method is compatible with the delegateDemo
        {
            Console.WriteLine(i);

        }
    }
}
