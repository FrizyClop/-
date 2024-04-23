using FormalLanguagesLibrary;
using System;

namespace ConsoleAppFormalLanguages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            test1();
            //test2();
        }

        public static void test1()
        {
            Grammar grammar = new Grammar();
            grammar.AddNonTerminal('A');
            grammar.AddNonTerminal('B');
            grammar.AddNonTerminal('C');
            grammar.AddNonTerminal('F');
            grammar.AddNonTerminal('L');
            grammar.AddNonTerminal('4');
            grammar.AddNonTerminal('Э');
            grammar.AddNonTerminal('Г');
            grammar.AddNonTerminal('6');
            grammar.AddTerminal('1');
            grammar.AddTerminal('a');
            grammar.AddTerminal('c');
            grammar.InstallStartSymbol('A');
            grammar.AddRule('A', "1B");
            //grammar.AddRule('B', "cC");
            grammar.AddRule('C', "a");
            grammar.AddRule('B', "1A");
            grammar.AddRule('A', "`");
            grammar.AddRule('C', "`");

            Console.WriteLine(grammar.ToString());

            StateMachine nda = new StateMachine(grammar);
            Console.WriteLine(nda.ToString());
        }

        public static void test2()
        {

        }
    }
}
