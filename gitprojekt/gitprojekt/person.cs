using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitprojekt
{
    internal class person
    {
        public int age;
        public string name;
        public double height;
        public double weight;
        public bool isStudent=false;
        public char initital;
        
        public person () { }
        public person (int aAge, string aName, double aHeight, double aWeight, bool aIsStudent) 
        { 
            age = aAge;
            name = aName;
            height = aHeight;
            weight = aWeight;
            isStudent = aIsStudent;
            initital = name[0];
            
        }
    }
}
