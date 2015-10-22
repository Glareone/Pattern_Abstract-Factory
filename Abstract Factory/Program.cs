using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Factory
{

    abstract class Product 
    { public abstract string Productname(); 
    }

    class ConcreteProductA : Product
    {
        public string ConcreteProduct = "ConcreteProductA";
        public string Factoryname;
        public ConcreteProductA(string Factoryname)
        {
         this.Factoryname = Factoryname;
        }
        public override string Productname()
        {
            return String.Format("{0} - {1}", ConcreteProduct, Factoryname);
        }
    }
    
    class ConcreteProductB : Product
    {
        public string ConcreteProduct = "ConcreteProductB";
        public string Factoryname;
        public ConcreteProductB(string Factoryname)
        {
         this.Factoryname=Factoryname;
        }
        public override string Productname()
        {
            return String.Format("{0} - {1}", ConcreteProduct, Factoryname);
        }
    }



    abstract class Factory
    {
        public abstract Product Create_ConcreteProductA();
        public abstract Product Create_ConcreteProductB();
    }

    class ConcreteFactoryA : Factory
    {
        public ConcreteFactoryA(string Factoryname)
        {
            this.Factoryname = Factoryname;
        }

        string Factoryname;
        public override Product Create_ConcreteProductA()
        {
            return new ConcreteProductA(Factoryname);
        }
        public override Product Create_ConcreteProductB()
        {
            return new ConcreteProductB(Factoryname);
        }
    }

    class ConcreteFactoryB : Factory
    {
        public ConcreteFactoryB(string Factoryname)
        {
            this.Factoryname = Factoryname;
        }

        string Factoryname;
        public override Product Create_ConcreteProductA()
        {
            return new ConcreteProductA(Factoryname);
        }
        public override Product Create_ConcreteProductB()
        {
            return new ConcreteProductB(Factoryname);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Factory factoryA = new ConcreteFactoryA("ConcreteFactoryA");
            Factory factoryB = new ConcreteFactoryB("ConcreteFactoryB");

            Product product1 = factoryA.Create_ConcreteProductA();
            Product product2 = factoryA.Create_ConcreteProductB();
            Product product3 = factoryB.Create_ConcreteProductA();
            Product product4 = factoryB.Create_ConcreteProductB();
            
            Console.WriteLine(product1.Productname(),"\n");
            Console.WriteLine(product2.Productname(),"\n");
            Console.WriteLine(product3.Productname(),"\n");
            Console.WriteLine(product4.Productname(),"\n");

            Console.ReadLine();
        }
    }
}
