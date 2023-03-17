using System;

namespace PruebaEjemplo
{

    class ArrayList <T>: List<T>
    {
        public void addAtTail(T data)
        {

        }

        public void addAtFront(T data)
        {

        }

        void remove(int index);
        void removeAll();
        void setAt(int index, T data);
        T getAt(int index);
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
