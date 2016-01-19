using System;

namespace HelloWorld
{
    public class Class1
    {
        private string str1 = null;

        public void Do()
        {
            Console.WriteLine(str1?.Length ?? 10);
            Console.WriteLine("!!!+");			
        }
    }
}
