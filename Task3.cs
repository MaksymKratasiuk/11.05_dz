using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._05_dz
{
    public class CafeWorker
    {
        public string Name { get; set; }
        public string Position { get; set; }
    }

    public class Cafe : IEnumerable<CafeWorker>
    {
        private List<CafeWorker> workers;

        public Cafe()
        {
            workers = new List<CafeWorker>();
        }

        public void AddWorker(CafeWorker worker)
        {
            workers.Add(worker);
        }

        public IEnumerator<CafeWorker> GetEnumerator()
        {
            return workers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    internal class Task3
    {
        public static void task3()
        {
            Cafe cafe = new Cafe();
            cafe.AddWorker(new CafeWorker { Name = "John", Position = "Barista" });
            cafe.AddWorker(new CafeWorker { Name = "Mike", Position = "Chef" });
            cafe.AddWorker(new CafeWorker { Name = "Sarah", Position = "Waitress" });

            foreach (CafeWorker worker in cafe)
            {
                Console.WriteLine("Name: " + worker.Name + ", Position: " + worker.Position);
            }
        }
    }
}
