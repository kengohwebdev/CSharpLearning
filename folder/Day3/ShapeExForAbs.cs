using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    //Abstract Methods: is a method that can only be used in an abstract clas
    //and doesn't have a body, body is provided by derived class

    //Abstract vs Virtual:
    /*
     * abstract method doesnt provide an implementation and forces the derived class to override the method
     * virtual: can have the implementation and also provides the OPTION of overriding it
     */
    /*
     abstract vs classes:
    abstract class cannot be instantiated but concrete classees can
    as long as one abstract method in class, the class must be abstract
    abstract classes can contain concrete methods as well as abstract methods*/
    public abstract class Shape
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public abstract string GetName();
        public int GetId()
        {
            return Id;
        }
    }

    public class Square : Shape
    { 

        public override string GetName()
        {
            return Name;
        }
    }
}
