namespace DesignPatterns.FactoryMethodExample
{
    abstract class Book
    {
        public abstract void Display();
        public abstract decimal GetPrice();
    }

    class PrintedBook : Book
    {
        public override void Display()
        {
            Console.WriteLine("Друкована книга видавництва 'А-БА-БА-ГА-ЛА-МА-ГА'.");
        }

        public override decimal GetPrice()
        {
            return 350.00m;
        }
    }

    class EBook : Book
    {
        public override void Display()
        {
            Console.WriteLine("Електронна книга видавництва 'Фоліо'.");
        }

        public override decimal GetPrice()
        {
            return 120.00m;
        }
    }

    abstract class PublishingHouse
    {
        public abstract Book PublishBook();
    }

    class PrintedBookPublisher : PublishingHouse
    {
        public override Book PublishBook()
        {
            return new PrintedBook();
        }
    }

    class EBookPublisher : PublishingHouse
    {
        public override Book PublishBook()
        {
            return new EBook();
        }
    }
}
