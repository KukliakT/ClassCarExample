﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCarExample
{
    class Company
    {
        Car[] ArrayCar;

        public Company()
        {
            ArrayCar = new Car[5];
        }

        public Car this[int index]
        {
            get
            {
                return ArrayCar[index];
            }
            set
            {
                ArrayCar[index] = value;
            }
        }
    }


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

        public static Car operator +(Car obj, double val)
        {
            obj.price += obj.price * (val / 100);
            return new Car {
                            price = obj.price,
                            brand = obj.brand,
                            color = obj.color
                            };
        }

        public static Car operator -(Car obj1, double val)
        {
            obj1.price -= (obj1.price * (val / 100));
            return new Car
            {
                price = obj1.price,
                brand = obj1.brand,
                color = obj1.color
            };
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            //Indexers
            Company Iner = new Company();
            Iner[0] = new Car("Reno", "white", 21500);
            Iner[1] = new Car("Deo", "black", 9000);
            Iner[2] = new Car();

            Car deo = Iner[1];
            deo.Print();
            //End Indexers

            //Check Overload operators
            Car focus = new Car("Ford", "blue", 12000);
            focus.Print();
           
            Car newcar = focus + 15.0;
            Console.WriteLine();
            newcar.Print();

            newcar = focus - 25.0;
            Console.WriteLine();
            newcar.Print();

        }
    }
}
