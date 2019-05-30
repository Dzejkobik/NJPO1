using System;
using System.Collections.Generic;
using System.Text;

namespace NJPO1.Decorator
{
    public abstract class AbstractPlainTextDecorator : AbstractPlainText
    {
        protected AbstractPlainText abstractPlainText;

        protected AbstractPlainTextDecorator(AbstractPlainText abstractPlainText)
        {
            this.abstractPlainText = abstractPlainText;
        }

        public override void Write()
        {
            abstractPlainText.Write();
        }
    }
}
