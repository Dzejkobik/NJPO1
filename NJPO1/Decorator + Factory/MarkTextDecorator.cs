using System;
using System.Collections.Generic;
using System.Text;

namespace NJPO1.Decorator
{
    public class MarkTextDecorator : AbstractPlainTextDecorator
    {
        public MarkTextDecorator(AbstractPlainText abstractPlainText) : base(abstractPlainText)
        {
        }

        public override void Write()
        {
            Console.Write("<mark>");
            base.Write();
            Console.Write("</mark>");
        }
    }
}
