using System;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // dictionary abstract data structure -> key -> value pair , also known as Map, or Assosiative Array 
            // collection , a list ,  of key - >  value pairs !
            // 3 Main  Operations - > add (element by key and value) , find by key - FindByKey()- value,  delete(key))
            // confilits it the indexes /

            Dictionary<string, int> studentsMarks = new Dictionary<string, int>();

            studentsMarks.Add("Ivan", 4);
            studentsMarks.Add("Peter", 6);
            studentsMarks.Add("Maria", 6);
            studentsMarks.Add("George", 5);

            int peterMark = studentsMarks["Peter"];
            Console.WriteLine("PetersMark : {0}", peterMark);
            Console.WriteLine("Is Peter in the HashTable: {0}", studentsMarks.ContainsKey("Peter"));

            Console.WriteLine("Students and grades");
            foreach (var pair in studentsMarks)
            {
                Console.WriteLine("{0}-->{1}", pair.Key, pair.Value);
                Console.WriteLine("This is a change into the branch, added some more code here ToDo!");
                Console.WriteLine("new branch Experiment");
            }

        }
    }
}
