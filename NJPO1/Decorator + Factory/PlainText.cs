using System;
using System.Collections.Generic;
using System.Text;

namespace NJPO1.Decorator
{
    public class PlainText : AbstractPlainText
    {
        public override void Write()
        {
            Console.Write(base.Text);
        }

        public PlainText(string text) : base(text)
        {
        }
    }
}
