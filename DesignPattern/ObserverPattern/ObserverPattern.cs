using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            foreach (var observer in this.observers)
            {
                observer.Update();
            }
        }
    }

    public class ConcreteSubject : Subject
    {
        private string subjectState;

        public string SubjectState
        {
            get { return this.subjectState; }
            set { this.subjectState = value; }
        }
    }

    public abstract class Observer
    {
        public abstract void Update();
    }

    public class ConcreteObserver : Observer
    {
        private string name;
        private string observerState;
        private ConcreteSubject subject;

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this.name = name;
            this.subject = subject;
        }


        public override void Update()
        {
            this.observerState = this.subject.SubjectState;
            Console.WriteLine($"Observer {this.name}'s new state is {this.observerState}");
        }

        public ConcreteSubject Subject
        {
            get { return this.subject; }
            set { this.subject = value; }
        }

    }
}
