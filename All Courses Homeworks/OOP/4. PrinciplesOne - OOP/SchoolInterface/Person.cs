using System;

namespace SchoolInterface
{
    public class Person
    {
        public string Name { get; set; }
        private string text;

        public string Text { get{ return this.text; } set { this.text = value; }}
    }
}
