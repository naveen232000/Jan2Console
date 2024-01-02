using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan2Console
{
    sealed class ProgramClass
    {
        public ProgramClass() { }
        private ProgramClass(int a) { }
        static ProgramClass()
        {
            Console.WriteLine("static class constructor");
        }
        protected ProgramClass(string name) { }
        public void display()
        {
            Console.WriteLine("sealed public method");
        }
        protected void display2()
        {
            Console.WriteLine("sealed protected method");
        }
        private void display3()
        {
            Console.WriteLine("sealed private method");
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            ProgramClass programClass = new ProgramClass();
            programClass.display();
            // programClass.display2);//protected methods are not accesable
         Console.ReadLine();    
        }

        //public class program2:ProgramClass { } //cant derived from sealed class inheritance not posible
    }
}
