using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCarExample
{
    class Car
    {
        public string brand;
        private string color;
        public double price;

        public Car()
        {
            brand = "BMW";
            color = "red";
            price = 30000;
        }

        public Car(string brand, string color, double price)
        {
            this.brand = brand;
            this.color = color;
            this.price = price;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public void Input(string brand, string color, double price)
        {
            this.brand = brand;
            this.color = color;
            this.price = price;
        }


            public void Print()
        {
            Console.Write("Brand: " + brand + ", ");
            Console.Write("Color: " + color + ", ");
            Console.Write("Price: " + price);
            Console.WriteLine();
        }

        public void ChangePrice(char a, double x)
        {
          
                double res;
                if (a == '-')
                {
                    res = price * (x / 100);
                    price -= res;
                }
                else if (a == '+')
                {
                    res = price * (x / 100);
                    price += res;
                }
                else { Console.WriteLine("Wrong parametr"); }

            
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Car focus = new Car("Ford", "blue", 12000);
            Car hz = new Car();
            Car megan = new Car("Reno", "white", 21500);

            focus.Print();
            hz.Print();
            megan.Print();

            focus.ChangePrice('+', 15);
            Console.WriteLine();
            focus.Print();

            megan.Input("Wols", "black", 9000);
            Console.WriteLine();
            megan.Print();

            megan.Color = "green";
            megan.Print();
        }
    }
}
