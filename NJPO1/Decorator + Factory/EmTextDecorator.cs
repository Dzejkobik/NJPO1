using System;
using System.Collections.Generic;
using System.Text;

namespace NJPO1.Decorator
{
    public class EmPlainTextDecorator : AbstractPlainTextDecorator
    {
        public EmPlainTextDecorator(AbstractPlainText abstractPlainText) : base(abstractPlainText)
        {
        }

        public override void Write()
        {
            Console.Write("<em>");
            base.Write();
            Console.Write("</em>");
        }
    }
}
