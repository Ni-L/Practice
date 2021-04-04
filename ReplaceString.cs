using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice;

namespace BasicProgram
    {
        /// <summary>
        /// REading input from the user replacing user name with templates
        /// </summary>
        public class ReplaceString
        {

            public static void ReadInput()
            {
                string template = "Hello <<UserName>>, How are you?";
                Console.WriteLine("Please Enter your name");
                string userInput = Console.ReadLine();
                ReplaceWord(template, userInput);

            }

            private static void ReplaceWord(string template, string userInput)
            {
                Console.WriteLine("Before Replacement: \t " + template);
                string result = template.Replace("<<UserName>>", userInput);
                Console.WriteLine("After Replacement: \t " + result);
            }
        }
    }

