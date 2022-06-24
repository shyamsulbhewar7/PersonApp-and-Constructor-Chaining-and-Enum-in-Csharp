using System;
using System.Collections.Generic;
using System.Text;

namespace PersonApp.Model
{
    public class Person
    {
        private readonly int _id;
        private readonly string _name;
        private int _age;
        private float _height;
        private float _weight;
        public Person(int id,string name,int age)
        {
            _id = id;
            _age = age;
            _name = name;
            _height = 5;
            _weight = 50;
        }
        public Person(int id,string name,int age,float height,float weight)
        {
            _id = id;
            _age = age;
            _name = name;
            _height = height;
            _weight = weight;
        }
        public int ID{ get { return _id; } }
        public int Age { get { return _age; } }
        public string Name { get { return _name; } }
        public double Height { get { return _height; } }
        public double Weight { get { return _weight; } }
        public double BMI()
        {
            double height_in_meter = _height * 0.3048;
            double score = _weight / (height_in_meter * height_in_meter);
            return score;
        }
        public string BodyTypeOnBMI()
        {
            double score = this.BMI();
            if(score < 18.5)
            {
                return "Underweight";
            }
            else if(score > 25)
            {
                return "Overweight";
            }
            else
            {
                return "Normal";
            }
        }
    }
}
