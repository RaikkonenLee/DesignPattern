using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Subject : ISubject
    {
        public Observer Observer { get; private set; }

        public Subject()
        {

        }

        public void AddRegister()
        {
            throw new NotImplementedException();
        }

        public void RemoveRegister()
        {
            throw new NotImplementedException();
        }

        public string GetStatus()
        {
            throw new NotImplementedException();
        }

        public string SetStatus()
        {
            throw new NotImplementedException();
        }
    }

    public class Observer : IObserver
    {
        public void Update()
        {
            throw new NotImplementedException();
        }
    }

    interface ISubject
    {
        void AddRegister();
        void RemoveRegister();
        string GetStatus();
        string SetStatus();
    }

    interface IObserver
    {
        void Update();
    }
}
