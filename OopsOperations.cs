using System;
using ExtensionMethod;
using useInterface;
using BaseHousens;
using ChildHouse;
using System.Collections.Generic;
using Implement;
using BaseHouse2;
using BaseHouse3;

//BaseClass and Properties.
namespace BaseHousens
{
    
    public class IndependentHouse
    {
        
        public string Name = "Gold House";
        public string Type = "Independent House";
        public int SizeSqFt = 2500;
        public int Price = 2500 * 229;
    }
}
// This is the Second base house and property
namespace BaseHouse2
{
    public class Villas 
    {
        public string Name = "Qure park";
        public string Type = "Villas";
        public int SizeSqFt = 2000;
        public int Price = 2000 * 229;
    }
}
// This is the third base house and property
namespace BaseHouse3
{
    public class Apartment 
    {
        public string Name = "Vrindavan";
        public string Type = "Apartment";
        public int SizeSqFt = 1500;
        public int Price = 1500 * 229;
    }
}
//ChildClass and Properties, Which is Inherit from Apartment class
namespace ChildHouse
{
    public class House : Apartment
    {
        public House()
        {

        }
        public House(string t, string n)
        {
            Type = t;
            Name = n;
        }
        public House(int s, int p)
        {
            SizeSqFt = s;
            Price = p;
        }
        public House(string t, string n, int s, int p)
        {
            Name = n;
            Type = t;
            SizeSqFt = s;
            Price = p;
        }
    }

}
namespace ExtensionMethod
{
    public static class Extension
    {
        public static bool IsCheap(this House a, House b)
        {
            var result= a.Price < b.Price;
            Console.WriteLine(result);
            return result;
        }


    }
}
// This is the Interface contain method to perform.
namespace useInterface
{
    public interface ICommand
    {
        //Method without body
        public void PrintAllClasses(List<House> villa);
        public void Print();
       
        
    }
}

namespace Implement
{
    public class ImplementInterface : ICommand
    {
        public void Print()
        {
            throw new NotImplementedException();
        }

        //Method Implemention will print Name and price of the house
        public void PrintAllClasses(List<House> Houses) 
        {
            foreach(var House in Houses)
            {
                Console.WriteLine("House Name = " + House.Name + ", House Price = " + House.Price);
            }
           
        }
    }
}



//Main Class 
namespace OopsConcept
{
    public class OopsOperations
    {
        static void Main(string[] args)
        {
            ImplementInterface Imp = new ImplementInterface();
            House house1 = new House("apartment", "bhavan", 1000,50000);
            House house2 = new House("apartment", "Golden",1500, 100000);
            House house3 = new House("apartment", "Silver",2000, 200000);
            House house4 = new House(1200, 80000);
            IndependentHouse house5 = new IndependentHouse();
            Villas house6 = new Villas();
            //List of House
            List<House> my_list = new List<House>();
            
            my_list.Add(house1);
            my_list.Add(house2);
            my_list.Add(house4);
            my_list.Add(house3);
            Imp.PrintAllClasses(my_list);


            //try and catch block
            try
            {
                Imp.Print();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Catched the Exception");
            }
            house3.IsCheap(house2);


            
        }
    }
}
