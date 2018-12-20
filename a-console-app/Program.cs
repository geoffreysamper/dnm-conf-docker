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
            Console.WriteLine("commitid  " + GetCommitId());


            
            foreach(var i in args){
                Console.WriteLine(i);
            }
        }

        private static string GetRuntimeInfo(){
            var att = (TargetFrameworkAttribute) System.Reflection.Assembly.GetEntryAssembly()?.GetCustomAttributes(typeof(TargetFrameworkAttribute), true)[0];


            return att.FrameworkName;
        }
        private static string GetCommitId(){
        if (System.IO.File.Exists("./__v.txt")){
                return System.IO.File.ReadAllText("./__v.txt");
        }
        return "dev-version";
        }
    }
}
