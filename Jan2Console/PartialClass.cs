using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan2Console
{
    public class PartialClass
    {//not accessable inother acces modifier
        //static void Main(string[] args)
        //{
        //    Dev dev = new Dev();
        //    dev.Display();
        //    dev.Display2();
        //    Console.ReadLine();
        //}
    }
    partial class Dev
    {
        public void Display() {
            Console.WriteLine("Developer 1 Display Method");
        }
    }
    partial class Dev
    {
        public void Display2() { Console.WriteLine("Developer 2 Display Method"); } //method shoul not be repeated
    }
    partial class Dev
    {
        static void Main(string[] args)
        {
            Dev dev = new Dev();
            dev.Display();
            dev.Display2();
            Console.ReadLine();
        }
    }
}
