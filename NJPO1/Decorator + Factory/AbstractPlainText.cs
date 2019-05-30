using System;
using System.Collections.Generic;
using System.Text;

namespace NJPO1.Decorator
{
    public abstract class AbstractPlainText
    {
        protected AbstractPlainText()
        {            
        }

        protected AbstractPlainText(string text)
        {
            Text = text;
        }

        protected string Text { get; set; }

        public abstract void Write();
    }
}
