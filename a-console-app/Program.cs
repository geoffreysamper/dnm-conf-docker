using System;
using System.Runtime.Versioning;

namespace a_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            var vers = GetRuntimeInfo();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("running on " + vers);
            Console.WriteLine("Hello World!");
            Console.WriteLine("command line arguments:");



            
            foreach(var i in args){
                Console.WriteLine(i);
            }
        }

        private static string GetRuntimeInfo(){
            var att = (TargetFrameworkAttribute) System.Reflection.Assembly.GetEntryAssembly()?.GetCustomAttributes(typeof(TargetFrameworkAttribute), true)[0];


            return att.FrameworkName;
        }

    }
}
