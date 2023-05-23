using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._05_dz
{
    public class SeaCreature
    {
        public string Name { get; set; }
        public string Species { get; set; }

        public SeaCreature(string name, string species)
        {
            Name = name;
            Species = species;
        }
    }

    // Клас "Океанаріум" зі списком морських істот
    public class Oceanarium : IEnumerable<SeaCreature>
    {
        private List<SeaCreature> seaCreatures;

        public Oceanarium()
        {
            seaCreatures = new List<SeaCreature>();
        }

        // Додати морську істоту в океанаріум
        public void AddSeaCreature(SeaCreature creature)
        {
            seaCreatures.Add(creature);
        }

        // Реалізація методу GetEnumerator() для підтримки ітератора
        public IEnumerator<SeaCreature> GetEnumerator()
        {
            return seaCreatures.GetEnumerator();
        }

        // Реалізація необов'язкового інтерфейсу IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


    internal class Task1
    {
        public static void task1()
        {
            Oceanarium oceanarium = new Oceanarium();

            // Додавання морських істот в океанаріум
            oceanarium.AddSeaCreature(new SeaCreature("Dolphin", "Delphinidae"));
            oceanarium.AddSeaCreature(new SeaCreature("Shark", "Carcharhinidae"));
            oceanarium.AddSeaCreature(new SeaCreature("Seahorse", "Hippocampus"));

            // Використання foreach для перебору морських істот
            foreach (var creature in oceanarium)
            {
                Console.WriteLine($"Name: {creature.Name}, Species: {creature.Species}");
            }

            Console.ReadKey();
        }
    }
}
