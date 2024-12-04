using System;

namespace ChristmasTreeDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ChristmasTree tree1 = new FirTree();
            tree1 = new Garland(tree1); 
            Console.WriteLine("Опис: {0}", tree1.Description);
            tree1.LightUp();

            
            ChristmasTree tree2 = new PineTree();
            tree2 = new Ornaments(tree2); 
            Console.WriteLine("Опис: {0}", tree2.Description);
            tree2.LightUp();

            
            ChristmasTree tree3 = new FirTree();
            tree3 = new Garland(tree3);
            tree3 = new Ornaments(tree3); 
            Console.WriteLine("Опис: {0}", tree3.Description);
            tree3.LightUp();

            Console.ReadLine();
        }
    }

    
    abstract class ChristmasTree
    {
        public ChristmasTree(string description)
        {
            this.Description = description;
        }
        public string Description { get; protected set; }
        public abstract void LightUp();
    }

   
    class FirTree : ChristmasTree
    {
        public FirTree() : base("Ялинка")
        { }

        public override void LightUp()
        {
            Console.WriteLine("Ялинка світиться");
        }
    }

    class PineTree : ChristmasTree
    {
        public PineTree() : base("Ялинка")
        { }

        public override void LightUp()
        {
            Console.WriteLine("Ялинка прикрашена прикрасами");
        }
    }

  
    abstract class TreeDecorator : ChristmasTree
    {
        protected ChristmasTree tree;

        public TreeDecorator(string description, ChristmasTree tree): base(description)
        {
            this.tree = tree;
        }

        public override void LightUp()
        {
            tree.LightUp();
        }
    }

    
    class Garland : TreeDecorator
    {
        public Garland(ChristmasTree tree)
            : base(tree.Description + " з гірляндою", tree)
        { }

        public override void LightUp()
        {
            base.LightUp();
            Console.WriteLine("Гірлянда блимає");
        }
    }

   
    class Ornaments : TreeDecorator
    {
        public Ornaments(ChristmasTree tree)
            : base(tree.Description + " з прикрасами", tree)
        { }

       
    }
}
