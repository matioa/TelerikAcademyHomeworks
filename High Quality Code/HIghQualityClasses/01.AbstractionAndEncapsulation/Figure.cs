using System;
using System.Text;


namespace Abstraction
{
    public abstract class Figure
    {
        public abstract double CalculateSurface();

        public abstract double CalculatePerimeter();

        public override string ToString() 
         { 
             StringBuilder result = new StringBuilder(); 
 
             result.AppendFormat("{0}", this.GetType().Name).AppendLine();
             result.AppendFormat(": {0:f2}; Perimeter: {1:f2}", this.CalculateSurface(), this.CalculatePerimeter()); 
 
             return result.ToString(); 
         } 

    }
}
