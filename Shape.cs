/******************************************************************************\
* Name: Jason D. F. D'Oyley
* Date: November 03, 2022
* Assignment CIS214 Week 5 GP - First Inheritance
*
* Shape Class.
* This is the base class that provides the generic information that can be
* shared by all classes that inherit from it. In this case, the generic
* information is the shape's color - generic because in our example, all shapes
* will have a color.
\******************************************************************************/
public class Shape
{
    // Class property
    public string Color { get; set; }

    // Constructor; sets the class's color property
    public Shape(string color)
    {
        Color = color;
    }

    // Function to print the Shape's information; note the use of the keyword
    // "virtual" - this allows derived classed to override the base class
    // functionality
    public virtual void PrintShape()
    {
        Console.WriteLine("The Shape's color is {0}.\n", Color);
    }
}