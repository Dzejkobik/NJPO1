using System;
using System.Collections.Generic;
using System.Text;

namespace NJPO1.Decorator
{
    public class DecoratorFactory
    {
        public AbstractPlainTextDecorator CreateDecorator(TypeOfDecorator typeOfDecorator,AbstractPlainText abstractPlainText)
        {
            AbstractPlainTextDecorator decorator = null;

            if (typeOfDecorator == TypeOfDecorator.EM)
            {
                decorator = new EmPlainTextDecorator(abstractPlainText);
            }

            if (typeOfDecorator == TypeOfDecorator.MARK)
            {
                decorator = new MarkTextDecorator(abstractPlainText);
            }

            if (typeOfDecorator == TypeOfDecorator.PARAGRAPH)
            {
                decorator = new ParagraphTextDecorator(abstractPlainText);
            }

            if (typeOfDecorator == TypeOfDecorator.STRONG)
            {
                decorator = new StrongTextDecorator(abstractPlainText);
            }

            return decorator;
        }
    }
}
