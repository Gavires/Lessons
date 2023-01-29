using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.Topic1.Lessons
{
    public class Lesson1
    {
        public string Text { get; private set; } = "visual studio 2022";

        public void WriteLine ()
        {
            Console.WriteLine(Text);
            Console.ReadKey();
        }
    }
}