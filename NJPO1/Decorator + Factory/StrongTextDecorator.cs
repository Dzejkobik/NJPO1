using System;
using System.Collections.Generic;
using System.Text;

namespace NJPO1.Decorator
{
    public class StrongTextDecorator : AbstractPlainTextDecorator
    {
        public StrongTextDecorator(AbstractPlainText abstractPlainText) : base(abstractPlainText)
        {
        }

        public override void Write()
        {
            Console.Write("<strong>");
            base.Write();
            Console.Write("</strong>");
        }
    }
}
