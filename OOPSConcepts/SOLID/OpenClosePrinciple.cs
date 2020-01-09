using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts.SOLID
{
    /*
	 * The OCP states that class should be open for extension and closed for modification,in that you should be able to add the new features and
	 * extend a class without changing its internal behaviour.Its helps to avoid breaking the existing class and other class that depend on it. 
	 */

    // 1. Old code 

    public class Rectangle
    {
        public double Height { get; set; }
        public double Width { get; set; }
    }
    public class Circle
    {
        public double Radius { get; set; }
    }
    public class AreaCalculator
    {
        public double TotalArea(object[] arrObjects)
        {
            double area = 0;
            foreach (var obj in arrObjects)
            {
                if (obj is Rectangle)
                {
                    area += ((Rectangle)obj).Height * ((Rectangle)obj).Width;
                }
                else
                {
                    area += ((Circle)obj).Radius * ((Circle)obj).Radius * Math.PI;
                }
            }
            return area;
        }
    }

    // 2. Code follow the OCP. 
    /*
     * We can add a Triangle and calculate it's area by adding one more "if" block in the TotalArea method of AreaCalculator.
     * But every time we introduce a new shape we need to alter the TotalArea method. 
     * So the AreaCalculator class is not closed for modification.
     */

    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Rectangle1 : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public override double Area()
        {
            return Height * Width;
        }
    }

    public class Circle1 : Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }

    public class AreaCalculator1
    {
        public double TotalArea(Shape[] arrShapes)
        {
            double area = 0;
            foreach (var objShape in arrShapes)
            {
                area += objShape.Area();
            }
            return area;
        }
    }


}
