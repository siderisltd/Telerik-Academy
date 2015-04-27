//Problem 22. Words count
//Write a program that reads a string from the console and lists all different 
//words in the string along with information how many times each word is found.


using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace WordsCount
{
    class WordsCount
    {
        
        static void Main()
        {
            string currentChar = string.Empty;
            string letter = "letters in the string along with information how many times each letter is found.";
            HashSet<Tuple<string, int>> test = NewMethod(ref currentChar, Text());

            foreach (var item in test)
            {
                Console.WriteLine("{0,-10}{1}{2,30} {3,2}","Letter : ", item.Item1,"Count :", item.Item2);
            }
        }

        private static HashSet<Tuple<string, int>> NewMethod(ref string currentChar, string letter)
        {
            HashSet<Tuple<string, int>> test = new HashSet<Tuple<string, int>>();
            string[] allWords = letter.Split(new char[] { ' ', '.', ',', '!', '(', ')', '[', ']', '?', '-', '{', '}' }, StringSplitOptions.RemoveEmptyEntries);

            int count = 0;

            for (int i = 0; i < allWords.Length; i++)
            {
                currentChar = allWords[i];
                for (int j = 0; j < allWords.Length; j++)
                {
                    if (allWords[j] == currentChar)
                    {
                        count++;
                    }
                }
                test.Add(Tuple.Create<string, int>(currentChar.ToString(), count));
                count = 0;
            }
            return test;
        }
        static string Text()
        {
            string text = @" Lorem ipsum dolor sit amet, consectetur adipiscing elit. In eu nisi massa. Nullam neque quam, mollis sit amet magna vitae, laoreet pharetra tortor. Curabitur eu leo lectus. Integer gravida dignissim lectus, at condimentum turpis euismod eu. Nulla in fringilla enim. Proin cursus pulvinar ipsum, non tempor tortor tempor in. Sed tempor felis ut mi pellentesque fringilla. Suspendisse pharetra bibendum augue ultrices vehicula. Aenean convallis lorem nec sapien hendrerit, nec rhoncus diam porttitor. Etiam sed condimentum metus. Pellentesque imperdiet ipsum ut risus blandit blandit. Pellentesque sed rhoncus ligula, in molestie ex. Pellentesque non leo ut quam accumsan maximus. Aliquam posuere vulputate lectus eu mattis. Phasellus tempor libero at turpis aliquet euismod. In at enim vel eros bibendum vestibulum ut ut orci.

Curabitur ligula lorem, commodo et orci quis, faucibus viverra diam. Duis ex augue, rutrum sed lorem id, porta ullamcorper nibh. Sed luctus est eget dolor dignissim fermentum. Maecenas ullamcorper placerat justo vel faucibus. Nulla facilisi. Curabitur et congue dui, at vestibulum velit. Donec feugiat tempus aliquam. In purus urna, euismod vitae ullamcorper eu, sagittis quis orci. Praesent posuere, turpis et malesuada tempus, mauris dolor dapibus metus, ut aliquet est arcu eget massa. Cras non nunc quis ligula accumsan laoreet ut ut metus.

Aliquam sollicitudin tempus mattis. Ut vulputate libero et commodo tincidunt. Curabitur nec sapien ante. Vivamus sit amet massa nunc. Aenean blandit molestie arcu, sed rutrum magna faucibus id. Duis eget imperdiet odio. Cras diam purus, ultrices at tempus ac, egestas quis quam. Aenean hendrerit varius velit vel aliquam.

Suspendisse hendrerit turpis in pharetra efficitur. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Cras quis dictum lorem, finibus rutrum justo. Etiam et dictum dolor, non laoreet nisi. Fusce sit amet enim non sapien dignissim iaculis. Aliquam ex sapien, facilisis in urna viverra, aliquet interdum mauris. Mauris vestibulum purus risus, at facilisis ex tincidunt fermentum. Praesent nisi lorem, venenatis vel nulla et, blandit accumsan justo. Nam iaculis, erat in gravida lobortis, erat tortor fringilla ipsum, accumsan euismod quam magna sed elit. Duis nibh metus, pellentesque et tortor eget, accumsan faucibus urna. Quisque ornare dictum nisi vitae maximus. Nulla gravida risus placerat orci blandit, vel iaculis enim sagittis. Vestibulum fermentum vulputate risus sed mollis. Morbi vitae enim diam. Pellentesque porttitor, lacus eget dapibus eleifend, est est dictum urna, sodales volutpat risus quam quis lectus. Ut posuere, velit sit amet suscipit pellentesque, odio augue tempus augue, a elementum diam mi mollis quam. ";
            return text;
        }
        
    }
}
