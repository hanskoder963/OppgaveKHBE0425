﻿namespace OppgaveKHBE0424;

class Program
{
    static void Main(string[] args)
    {
        // // initalize a new object, from a class
        // Person person = new Person();
        // person.Name = "Marius";
        // person.Age = 39;
        
        // Console.WriteLine(person.Name);
        // Console.WriteLine(person.Age);

        // string[] shoppingList = {"Milk", "Soda", "Dinner", "Candy", "Fish", "Salmon"}; // fixed size: new string[6]
        // List<string> programmeringLanguages = new List<string>() {
        //     "C#", "Java", "Python", "JavaScript", "C", "C++", "Rust", "Go"
        // };

        // List<int> ints = [1,2,3,4];

        // for(int i = 0; i < shoppingList.Length; i++) 
        // {
        //     Console.WriteLine(shoppingList[i]);
        // }

        // foreach(var programming in programmeringLanguages) 
        // {
        //     Console.WriteLine(programming);
        // }


        //
        //**********************************//
        //

       
        /*
            Oppgave 1:
                - Lag noen enkle variabler av forksjellige primitive datatyper
                - Forsøk å skrive ut verdiene som er tildelt variablene ved å bruke Console.WriteLine(); metoden.
        */
        string currency = "Euro";
        int money = 20;
        

        Console.WriteLine(currency);
        Console.WriteLine(money);


        /*
            Oppgave 2:
                - Forsøk å lage et array av forksjellige primitive datatyper.
                - Forsøk å skrive ut verdiene som befinner seg i arrayet, ved å bruke en for-loop, eller en foreach-loop.
        */


        string[] games = ["Marvel Rivals", "Ashes of Creation", "Schedule1", "Overwatch", "DnD"];
        foreach (string i in games)
        {
            Console.WriteLine(i);
        }

        /*
            Oppgave 3:
                - Forsøk å tildele variabler til en generiske Liste: eksempel: List<int> integers = new List<int>();
                - Forsøk å skrive ut verdiene i listen, ved å bruke en for-loop eller en foreach-loop.
        */
        
        List<int> antalMatVarer = new List<int> { 2, 5, 1, 8, 12 };

        for (int i = 0; i < antalMatVarer.Count; i++)
        {
        Console.WriteLine(antalMatVarer[i]);
        }       
        
    }

    	public static double Add(double a, double b) 
		{
		  return a + b;
		}
		
		public static void AddVoid(double a, double b) 
		{
		  Console.WriteLine(a + b);
		}
}
