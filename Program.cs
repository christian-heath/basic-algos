using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {0,1,2,3,4,5,6,7,8,9};
            string[] names = {"Tim", "Martin", "Nikki", "Sara"};
            bool[] values = {true, false, true, false, true, false, true, false, true, false};

            List<string> flavors = new List<string>();
            flavors.Add("Chocolate");
            flavors.Add("Strawberry");
            flavors.Add("Vanilla");
            flavors.Add("Neapolitan");
            flavors.Add("Sherbert");
            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine(flavors.Count);

            Dictionary<string,string> NamesDict = new Dictionary<string, string>();
            NamesDict.Add(names[0], null);
            NamesDict.Add(names[1], null);
            NamesDict.Add(names[2], null);
            NamesDict.Add(names[3], null);
            Random rand = new Random();
            NamesDict["Tim"]=flavors[rand.Next(0,4)];
            NamesDict["Martin"]=flavors[rand.Next(0,4)];
            NamesDict["Nikki"]=flavors[rand.Next(0,4)];
            NamesDict["Sara"]=flavors[rand.Next(0,4)];
            foreach (KeyValuePair<string,string> entry in NamesDict)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}