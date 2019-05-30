using System;
using System.Collections.Generic;
using System.Text;

namespace NJPO1.Decorator
{
    public class DecoratorRun
    {
        private int _enteredNumber;

        protected List<int> enteredNumbers = new List<int>();

        private string _enteredText;

        private bool _failedInput;

        private AbstractPlainText _abstractPlainText;

        public void Run()
        {
            GetInputText();
            PrintMenu();
            do
            {
                _failedInput = false;
                var input = Console.ReadLine();
                var isSuccessful = int.TryParse(input, out _enteredNumber);
                if (!isSuccessful || _enteredNumber < 0 || _enteredNumber > 4)
                {
                    Console.WriteLine("Incorrect input, enter number again");
                    _failedInput = true;
                }
                else if (_enteredNumber == 0)
                {
                    Console.WriteLine("Generating output ...");
                }
                else
                {
                    enteredNumbers.Add(_enteredNumber);
                }

            } while (_enteredNumber != 0 || _failedInput);

            CreateTaggedText();

            _abstractPlainText.Write();
        }

        private void PrintMenu()
        {
            Console.WriteLine("Select tag,press enter then select another tag or exit menu");
            Console.WriteLine("1. Em");
            Console.WriteLine("2. Mark");
            Console.WriteLine("3. Paragraph");
            Console.WriteLine("4. Strong");
            Console.WriteLine("0. Exit");
        }

        private void GetInputText()
        {
            Console.WriteLine("Enter text");
            _enteredText = Console.ReadLine();
            _abstractPlainText = new PlainText(_enteredText);
        }

        private void CreateTaggedText()
        {
            var decoratorFactory = new DecoratorFactory();
            foreach (var enteredNumber in enteredNumbers)
            {
                var typeOfEnum = (TypeOfDecorator)enteredNumber;
                var decoratedText = decoratorFactory.CreateDecorator(typeOfEnum, _abstractPlainText);
                _abstractPlainText = decoratedText;
            }
        }
    }
}
