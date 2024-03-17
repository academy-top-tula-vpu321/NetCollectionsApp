using NetCollectionsApp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCollectionsApp
{
    static class Examples
    {
        public static void ArrayListExample()
        {
            ArrayList arrayList = new ArrayList();
            Random random = new Random();

            int size = 10;

            for (int i = 0; i < size; i++)
                arrayList.Add(random.Next(99));

            //arrayList[3] = 656.8787;
            //arrayList[5] = "Hello world";
            //arrayList[7] = false;

            foreach (var item in arrayList)
                Console.Write($"{item} ");
            Console.WriteLine();
        }

        public static void ListExample()
        {
            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> numbers = new(list1) { 6, 7, 8 };
            var list3 = new List<int>(10);

            foreach (var item in numbers)
                Console.Write($"{item} ");
            Console.WriteLine();

            //List<string> employees = ["Tom", "Bob", "Sam"];
            //List<string> students = [];

            List<string> cities = new() { "Moscow", "Tula", "Minsk", "Novgorod", "Irkutsk" };

            List<Employee> employees = new()
            {
                new(){ Name = "Bobby", Age = 34 },
                new(){ Name = "Sammy", Age = 19 },
                new(){ Name = "Jimmy", Age = 27 },
                new(){ Name = "Tommy", Age = 21 },
            };

            foreach (var e in employees)
                Console.WriteLine(e);
            Console.WriteLine();

            employees.Add(new() { Name = "Penny", Age = 29 });
            employees.AddRange(new[]
            {
                new Employee(){ Name = "Polly", Age = 18 },
                new Employee(){ Name = "Mike", Age = 42 },
            });

            employees.Insert(2, new() { Name = "Barby", Age = 20 });

            foreach (var e in employees)
                Console.WriteLine(e);
            Console.WriteLine();

            employees[3] = new Employee() { Name = "Wiliam", Age = 25 };
            Console.WriteLine(employees[3]);
            Console.WriteLine();

            Console.WriteLine(employees.Count);
            Console.WriteLine();

            employees.RemoveAt(3);
            foreach (var e in employees)
                Console.WriteLine(e);
            Console.WriteLine();

            Console.WriteLine(numbers.Contains(5));
            Console.WriteLine(cities.Contains("Tula"));
            Console.WriteLine(employees.Contains(new() { Name = "Bobby", Age = 34 }));
            Console.WriteLine(employees.Exists(e => e.Name == "Bobby"));

            var bobby = employees.Find(e => e.Name == "Bobby");
            var indexBobby = employees.FindIndex(e => e.Name == "Bobby");
            Console.Write($"{indexBobby}: {bobby} ");
            Console.WriteLine(employees.Contains(bobby));

            Predicate<int> predicat = (n) => n > 100;
            var number = numbers.Find(predicat);
            var indexNumber = numbers.FindIndex(predicat);
            Console.WriteLine($"{indexNumber}: {number}");
            Console.WriteLine();

            var city = cities.Find(c => c == "Voroneg");

            // FindLast
            // FindLastIndex

            var oldEmployees = employees.FindAll(e => e.Age >= 30);
            foreach (var e in oldEmployees)
                Console.WriteLine(e);
            Console.WriteLine();

            foreach (var e in employees)
                Console.WriteLine(e);
            Console.WriteLine();

            var sliceEmployees = employees.Slice(2, 4);

            foreach (var e in sliceEmployees)
                Console.WriteLine(e);
            Console.WriteLine();

            //var searchEmpl = employees.BinarySearch(bobby);
            //Console.WriteLine(searchEmpl);

            //numbers.Sort();
            ////employees.Sort(new EmployeeCompareName().CompareName);
            employees.Sort(
                (Employee e1, Employee e2) => e1.Age.CompareTo(e2.Age)
                );
            foreach (var e in employees)
                Console.WriteLine(e);
            Console.WriteLine();

            //class EmployeeCompareName
            //{
            //    public int CompareName(Employee e1,  Employee e2)
            //    {
            //        return e1.Name.CompareTo(e2.Name);
            //    }
            //}
        }

        public static void LinkedData()
        {
            List<string> cities = new List<string>() { "Moscow", "Tula", "Minsk", "Novgorod", "Irkutsk" };
            LinkedList<string> citiesList = new LinkedList<string>(cities);

            LinkedList<Employee> employeeList = new LinkedList<Employee>();

            employeeList.AddFirst(new Employee() { Name = "Bob", Age = 24 });
            foreach (Employee e in employeeList)
                Console.WriteLine(e);

            Stack<int> stack = new();
            Stack<Employee> employeesStack = new();

            //stack.TryPeek(out int? result);
            //if (result is not null)
            //    Console.WriteLine(result);
            //else
            //    Console.WriteLine("Stack integer is empty");

            stack.TryPeek(out int result);
            Console.WriteLine(result);

            stack.Push(0);
            stack.TryPeek(out result);
            Console.WriteLine(result);

            //employeesStack.TryPeek(out Employee result);
            //if(result is not null)
            //    Console.WriteLine(result);
            //else
            //    Console.WriteLine("Stack employees is empty");


        }

        public static void SetDictionaryExample()
        {
            SortedSet<int> setA = new();

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int next = random.Next() % 100;
                Console.Write($"{next} ");
                setA.Add(next);
            }
            Console.WriteLine();

            foreach (var i in setA)
                Console.Write($"{i} ");
            Console.WriteLine();


            SortedSet<Employee> employees = new(new EmployeeComparer());
            employees.Add(new Employee() { Name = "Bob", Age = 23 });
            employees.Add(new Employee() { Name = "Tom" });
            employees.Add(new Employee() { Name = "Bob", Age = 41 });

            foreach (var e in employees)
                Console.WriteLine(e);
            Console.WriteLine();

            
        }
    }

}

class EmployeeComparer : IComparer<Employee>
{
    public int Compare(Employee? x, Employee? y)
    {
        var res = x.Name.CompareTo(y.Name);
        if (res != 0)
            return res;
        else
            return x.Age.CompareTo(y.Age);
    }
}
