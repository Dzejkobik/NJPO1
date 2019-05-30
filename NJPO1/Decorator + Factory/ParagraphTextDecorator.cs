using System;
using System.Collections.Generic;
using System.Text;

namespace NJPO1.Decorator
{
    public class ParagraphTextDecorator : AbstractPlainTextDecorator
    {
        public ParagraphTextDecorator(AbstractPlainText abstractPlainText) : base(abstractPlainText)
        {
        }

        public override void Write()
        {
            Console.Write("<p>");
            base.Write();
            Console.Write("</p>");
        }
    }
}
