using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_7_1
{
    internal class Program
    {
        public static void List()
        {
            List<string> mascots = new List<string>();
            Console.WriteLine("Please select a total of 5 mascosts you would like to include in your list");
            for (int i = 0; i < 5; i++)
            {
                mascots.Add(Console.ReadLine());
            }
            string[] mascotsArr = new string[] { "Kingsley Stag", "Michigan Spartan", "Michigan Wolverine" };
            mascots.AddRange(mascotsArr);
            mascots.Sort();
            Console.WriteLine("Here is your sorted list of mascost with some added ones too:");
            foreach (string m in mascots)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine("Please select and instance in the list you would like to remove (press in range of 0-7)");
            int instance = int.Parse(Console.ReadLine());
            mascots.RemoveAt(instance);
            mascots.Reverse();
            Console.WriteLine("Here is the new list with the removed mascot and in reverse order");
            foreach (string m in mascots)
            {
                Console.WriteLine(m);
            }
            Console.ReadLine();
        }
        public static void Queue()
        {
            Queue<string> movies = new Queue<string>();
            bool x = true;
            while (x == true)
            {
                Console.WriteLine("Please select a total of 5 movies you would like to include in your queue");
                for (int i = 0; i < 5; i++)
                {
                    movies.Enqueue(Console.ReadLine());
                }
                if (movies.Contains("Inception") == true)
                {
                    Console.WriteLine("Do not remove Inception!");
                }
                if (movies.Peek() == "Inception")
                {
                    Console.WriteLine("Do not include Inception at the beginning of the queue!");
                    movies.Clear();
                }
                else
                {
                    movies.Dequeue();
                    Console.WriteLine($"There are a total of {movies.Count()} movies in the Queue");
                    Console.WriteLine();
                    Console.WriteLine("Here is the rest of the movies in the queue minus the very first movie put into the queue:");
                    foreach (string m in movies)
                    {
                        Console.WriteLine(m);
                    }
                    x = false;
                    Console.ReadLine();
                }
            }
        }
        public static void PriorityQueue()
        {
            PriorityQueue<string, int> shows = new PriorityQueue<string, int>();
            Console.WriteLine("Please select a total of 5 shows you would like to include in your PriorityQueue");
            for (int i = 0; i < 5; i++)
            {
                shows.Enqueue(Console.ReadLine(), i);
            }
            while (shows.TryDequeue(out string item, out int priority))
            {
                Console.WriteLine($"Dequeued item {item} because it had the highest priority");
            }
        }
        public static void Stack()
        {
            Stack<string> books = new Stack<string>();
            Console.WriteLine("Please select a total of 5 books you would like to include in your Stack");
            for (int i = 0; i < 5; i++)
            {
                books.Push(Console.ReadLine());
            }
            if (books.Contains("Dracula"))
            {
                Console.WriteLine("Your Stack has the entry Dracula in it. Thats my favorite book.");
            }
            books.Pop();
            Console.WriteLine($"Your book stack has a total of {books.Count()}");
            foreach (string b in books)
            {
                Console.WriteLine($"{b}");
            }
            Console.ReadLine();

        }
        public static void LinkedList()
        {
            string[] activity = { "Hiking", "Biking", "Gaming", "Dating", "Hunting" };
            LinkedList<string> activities = new LinkedList<string>(activity);
            Console.WriteLine($"The first node in the LinkedList is {activities.First()}");
            Console.WriteLine($"The last node in the LinkedList is {activities.Last()}");
            LinkedListNode<string> middle = activities.Find("Gaming");
            activities.AddAfter(middle, "Eating");
            activities.RemoveFirst();
            Console.WriteLine($"There is a total of {activities.Count()} activites in the LinkedList");
            foreach (string b in activities)
            {
                Console.WriteLine(b);
            }
            Console.ReadLine();
        }
        public static void HashSet()
        {
            string[] car = { "Audi", "Toyota", "Ford", "Tesla", "BMW" };
            string[] toycar = { "Hotwheel", "Kid Jeep", "Kia", "Barbie Car", "Monster Truck" };
            string[] lemon = { "Yugo", "Tesla", "Volvo XC90", "Volkswagen Tiguan", "Ford" };
            HashSet<string> cars = new HashSet<string>(car);
            HashSet<string> toycars = new HashSet<string>(toycar);
            HashSet<string> lemons = new HashSet<string>(lemon);
            HashSet<string> trucks = new HashSet<string>();
            cars.UnionWith(toycars);
            Console.WriteLine("Here is 2 combined HashSets");
            foreach (string c in cars)
            {
                Console.WriteLine($"{c}");
            }
            trucks = cars;
            trucks.IntersectWith(lemons);
            
            Console.WriteLine("Repeat items in first and third HashSet");
            foreach (string t in trucks)
            {
                Console.WriteLine(t);
            }
            Console.ReadLine();
        }
        public static void Dictionary()
        {
            Dictionary<string, string> consoles = new Dictionary<string, string>();
            consoles.Add("Switch", "Nintendo");
            consoles.Add("PS5", "Sony");
            consoles.Add("Xbox360", "Microsoft");
            consoles.Add("Genisis", "Sega");
            consoles.Add("Atari 2600", "Atari");
            Console.WriteLine("Here is all the keys:");
            Dictionary<string, string>.KeyCollection keys = consoles.Keys;
            foreach (string k in keys) 
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("Here is all the values:");
            Dictionary<string, string>.ValueCollection values = consoles.Values;
            foreach (string v in values)
            {
                Console.WriteLine(v);
            }
            Console.ReadLine();
        }
        public static void SortedList()
        {
            SortedList<string, string> drinks = new SortedList<string, string>()
            {
                {"Tea", "Healthy"},
                {"Soda", "Unhealthy"},
                {"Energy Drink", "Unhealthy"},
                {"Coffee", "Healthy"},
                {"Water", "Healthy"}
            };
            Console.WriteLine("Please enter in a drink for the SortedList");
            string inputKey = Console.ReadLine();
            Console.WriteLine("Please enter in a value (Healthy/Unhealthy) for the SortedList in reference to the drink");
            string inputValue = Console.ReadLine();
            drinks.Add(inputKey, inputValue);
            drinks.Remove("Tea");
            foreach (KeyValuePair<string, string> d in drinks)
            {
                Console.WriteLine($"{d.Key}, {d.Value}");
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in a number that corresponds with and of the following collections for C#:");
            Console.WriteLine("1. List");
            Console.WriteLine("2. Queue");
            Console.WriteLine("3. PriorityQueue");
            Console.WriteLine("4. Stack");
            Console.WriteLine("5. LinkedList");
            Console.WriteLine("6. HashSet");
            Console.WriteLine("7. Dictionary");
            Console.WriteLine("8. SortedList");
            var input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("You have selected a List");
                    List();
                    break;
                case 2:
                    Console.WriteLine("You have selected a Queue");
                    Queue();
                    break;
                case 3:
                    Console.WriteLine("You have selected a PriorityQueue");
                    PriorityQueue();
                    break;
                case 4:
                    Console.WriteLine("You have selected a Stack");
                    Stack();
                    break;
                case 5:
                    Console.WriteLine("You have selected a LinkedList");
                    LinkedList();
                    break;
                case 6:
                    Console.WriteLine("You have selected a HashSet");
                    HashSet();
                    break;
                case 7:
                    Console.WriteLine("You have selected a Dictionary");
                    Dictionary();
                    break;
                case 8:
                    Console.WriteLine("You have selected a SortedList");
                    SortedList();
                    break;
            }
        }
    }
}