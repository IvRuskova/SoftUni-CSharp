using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBoxData;

public class Box
{
    
    private const string PropertyValueExcepMess = "{0} cannot be zero or negative.";
    private double length;
    private double width; 
    private double heigth;
    public Box(double length, double width, double height) 
    {
        Length = length;
        Width = width; 
        Height = height;
    }
    public double Length 
    {
        get=> length;
        set 
        { 
            if (value <= 0)
            {
                throw new ArgumentException(string.Format(PropertyValueExcepMess, nameof(Length)));
            }
            length = value;
        }
    }

    public double Width 
    { 
        get=> width;
        set 
        {
            if (value <= 0)
            {
                throw new ArgumentException(string.Format(PropertyValueExcepMess, nameof(Width)));     
            }
            width = value;
        }
    }
    public double Height 
    { 
        get => heigth;
        set
        {
            if (value <= 0)
            {
                throw new AggregateException(string.Format(PropertyValueExcepMess, nameof(Height)));
            }
            heigth = value;
        } 
    }
    public double SurfaceArea() => 2 * Length * Width + LateralSurfaceArea();
    public double LateralSurfaceArea() => 2 * Length * Height + 2 * Width * Height;
    public double Volume() => Length * Width * Height;
}
