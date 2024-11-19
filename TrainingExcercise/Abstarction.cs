using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
        public abstract class Shape
        {
            // Concrete method: Common functionality for all shapes
            public void Draw()
            {
                Console.WriteLine("Drawing a shape...");
            }

            // Abstract method: Must be implemented by derived classes
            public abstract double Area();  // No implementation here
        }

        public class Circle : Shape
        {
            public double Radius { get; set; }

            // Implementing the abstract method
            public override double Area()
            {
                return Math.PI * Radius * Radius;
            }
        }

        public class Rectangle : Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }

            // Implementing the abstract method
            public override double Area()
            {
                return Width * Height;
            }
        }

        public class Abstarction
        {
            public void Run()
            {
                // Cannot instantiate an abstract class directly
                // Shape shape = new Shape(); // Error!

                Circle circle = new Circle { Radius = 5 };
                Console.WriteLine("Circle Area: " + circle.Area()); // Output: 78.54...

                Rectangle rectangle = new Rectangle { Width = 4, Height = 6 };
                Console.WriteLine("Rectangle Area: " + rectangle.Area()); // Output: 24
            }
        }

    }
