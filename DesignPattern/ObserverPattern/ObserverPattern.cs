using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    public class ObserverPattern
    {
    }

    public abstract class Subject
    {
        private readonly List<Observer> observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            this.observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            this.observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer observer in this.observers) observer.Update();
        }
    }

    public class ConcreteSubject : Subject
    {
        public string SubjectState { get; set; }
    }

    public abstract class Observer
    {
        public abstract void Update();
    }

    public class ConcreteObserver : Observer
    {
        private readonly string name;
        private string observerState;

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this.name = name;
            this.Subject = subject;
        }

        public ConcreteSubject Subject { get; set; }


        public override void Update()
        {
            this.observerState = this.Subject.SubjectState;
            Console.WriteLine($"Observer {this.name}'s new state is {this.observerState}");
        }
    }
}