using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exo_3
    {
        public Exo_3()
        {
            var myTestEvents = new TestEvents();

            myTestEvents.OnArgumentRaised += OnArgumentRaised3;
        }

        private static void OnArgumentRaised1() { }
        private static void OnArgumentRaised2(string e, int v) { }
        private static void OnArgumentRaised3(string e) { }
        private static void OnArgumentRaised4(long e) { }
        private static void OnArgumentRaised5(double e) { }
    }

    public delegate void OnArgumentRaisedDelegate(string eventDescription);

    public class TestEvents
    {
        public event OnArgumentRaisedDelegate OnArgumentRaised;
    }
}
