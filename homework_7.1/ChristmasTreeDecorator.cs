using System;

namespace DecoratorExample
{
    abstract class ChristmasTree
    {
        public abstract void Display();
    }

    class BasicTree : ChristmasTree
    {
        public override void Display()
        {
            Console.WriteLine("Урааа! В нас є ялинка.");
        }
    }

    abstract class TreeDecorator : ChristmasTree
    {
        protected ChristmasTree tree;

        public TreeDecorator(ChristmasTree tree)
        {
            this.tree = tree;
        }

        public override void Display()
        {
            tree.Display();
        }
    }

    class OrnamentDecorator : TreeDecorator
    {
        private string pattern;

        public OrnamentDecorator(ChristmasTree tree, string ornament) : base(tree)
        {
            this.pattern = ornament;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Класний {pattern}!!!");
        }
    }

    class GarlandDecorator : TreeDecorator
    {
        private string color;

        public GarlandDecorator(ChristmasTree tree, string color) : base(tree)
        {
            this.color = color;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Гірлянда світиться {color} кольором.");
        }
    }

    class StarDecorator : TreeDecorator
    {
        public StarDecorator(ChristmasTree tree) : base(tree) { }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("На верхівці сяє яскрава зірка.");
        }
    }
}
