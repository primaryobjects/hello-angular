using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Types
{
    public class Hello
    {
        public static string DefaultText { get; } = "Hello World";
        public string Text { get; set; }

        public Hello() : this(DefaultText)
        {
        }

        public Hello(string text)
        {
            Text = text;
        }
    }
}