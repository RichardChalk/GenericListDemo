using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace GenericListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Här skapas en tom lista!
            List<string> listOfStrings = new List<string>();

            // Add an item to the end of the list
            listOfStrings.Add("Hello World!");

            // Add an item to the specified index of the list
            listOfStrings.Insert(0, "text3");

            // You can also get an item out of the list using the 'ElementAt' method.
            string firstItem = listOfStrings.ElementAt(0);

            // You can also use the square brackets([and])
            // with the List class to get and set values at specific indexes,
            // just like an array.
            string secondItem = listOfStrings[1];   // Get a value.
            listOfStrings[0] = "New Value!";        // Set a value.

            // Also, the 'RemoveAt' method allows you to remove items from the list:
            listOfStrings.RemoveAt(2);

            // While we’re talking about deleting stuff,
            // you can remove everything from the list with the 'Clear' method:
            listOfStrings.Clear();

            // While arrays have the 'Length' property to determine how
            // many items are in the array,
            // the List class has a 'Count' property instead.
            // (There’s no Length property; very annoying!)
            int itemsInList = listOfStrings.Count;

            // If we’re using a List, but we want to get a copy of
            // the contents as an array, there’s an easy way to do this.
            // There’s a 'ToArray' method that will make this conversion for us,
            // copying our generic List instance into an
            // array of the appropriate type:
            List<int> someNumbersInAList = new List<int>();
            someNumbersInAList.Add(14);
            someNumbersInAList.Add(24);
            someNumbersInAList.Add(37);
            
            int[] numbersInArray = someNumbersInAList.ToArray();

            // We are also able to loop over all of the items in a List,
            // just like with arrays:
            List<int> someMoreNumbersInAList = new List<int>();
            someMoreNumbersInAList.Add(14);
            someMoreNumbersInAList.Add(24);
            someMoreNumbersInAList.Add(37);
            
            foreach (int number in someMoreNumbersInAList)
            {
                // ... do fun stuff here!
            }

            // Using Collection Initializer Syntax
            // When we first introduced arrays, we also discussed collection
            // initializer syntax(or simply a collection initializer)
            // that allowed us to set up an array using simplified syntax:
            int[] numbers = new int[] 
            { 
                1, 2, 3, 4, 5 
            };

            // We can do this same thing with the List<T> class as well.
            // The earlier code that added multiple items to a
            // list could be simplified using collection initializer syntax:
            List<int> evenMoreNumbersInAList = new List<int>() 
            { 
                14, 24, 37 
            };


}
    }
}