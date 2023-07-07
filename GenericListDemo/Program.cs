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

            // Lägg till en item på slutet av listan
            listOfStrings.Add("Hello World!");

            // Lägg till en item på den index av listan
            listOfStrings.Insert(0, "text3");

            // Hämta en item från index med 'ElementAt' metod.
            string firstItem = listOfStrings.ElementAt(0);

            // Man kan även använda square brackets([och])
            // precis som med en array[].
            string secondItem = listOfStrings[1];   // Get a value.
            listOfStrings[0] = "New Value!";        // Set a value.

            // 'RemoveAt' metod kan radera från listan (från en specificerad index)
            // (denna rad skapar en error!!! Varför då?)
            listOfStrings.RemoveAt(2);

            // Radera ALLT med 'Clear' metod:
            listOfStrings.Clear();

            // Arrays[] har 'Length'
            // List<T> class har 'Count' property istället.
            // (skit irriterande att de diffar!)
            int itemsInList = listOfStrings.Count;

            // Kopiera en List<T> till en array med 'ToArray' metod
            List<int> someNumbersInAList = new List<int>();
            someNumbersInAList.Add(14);
            someNumbersInAList.Add(24);
            someNumbersInAList.Add(37);

            int[] numbersInArray = someNumbersInAList.ToArray();

            // Vi kan loopa igenom en lista precis som vi gjorde med arrays
            List<int> someMoreNumbersInAList = new List<int>();
            someMoreNumbersInAList.Add(14);
            someMoreNumbersInAList.Add(24);
            someMoreNumbersInAList.Add(37);

            foreach (int number in someMoreNumbersInAList)
            {
                // ... do fun stuff here!
            }

            // Collection Initializer Syntax med Array[]
            int[] numbers = new int[]
            {
                1, 2, 3, 4, 5
            };

            // Vi kan göra samma ska med List<T> class.
            List<int> evenMoreNumbersInAList = new List<int>()
            {
                14, 24, 37
            };
        }
    }
}