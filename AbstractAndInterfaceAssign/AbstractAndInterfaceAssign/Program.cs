using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterfaceAssign
{
    public interface IVolume
    {
        double Volume { get; }
    }
    public interface IArea
    {
        double SurfaceArea();
    }
    public interface ISolid : IVolume, IArea
    {
       
    }
    abstract class Solid : ISolid
    {
        double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }


        }
        const double pi = 3.142;
        public double Pi
        {
            get { return pi; }
            //set {; }
        }

        public abstract double Volume { get;  }

        public Solid()
        {

        }
        public Solid(double _radius)
        {
            radius = _radius;
        }

        public abstract double SurfaceArea();
        
    }

    class Cylinder : Solid
    {
        double height;
        public Cylinder()
        {

        }
        public Cylinder(double _height, double _radius): base(_radius)
        {
            height = _height;
        }
        public override double Volume
        {
            get
            {
                double volume = Pi * Radius * height;
                return volume;
            }
            


        }
        public override double SurfaceArea()
        {
            double surfaceArea = 2 * Pi * Radius * (Radius + height);
            return surfaceArea;
        }
        
    }
    class Sphere : Solid
    {
        public Sphere()
        {

        }
        public Sphere(double _radius): base(_radius)
        {

        }

        public override double SurfaceArea()
        {
            double surfaceArea = 4 / 3 * Pi * Radius * Radius * Radius;
            return surfaceArea;
        }
        public override double Volume
        {
            get
            {
                double volume = 4 * Pi * Radius * Radius;

                return volume;
            }

        }
    }
        class Program
        {
             
            
            static void Main(string[] args)
            {
            Cylinder cy = new Cylinder(2.4, 3.0);
            //cd.SurfaceArea();
            Console.WriteLine("Volume of Cylinder : {0}", cy.Volume);
            Console.WriteLine("Surface area  of Cylinder:{0}", cy.SurfaceArea());
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");

            Sphere Sph = new Sphere(2.0);
            Console.WriteLine(" Volume of Sphere :{0}", Sph.Volume);
            Console.WriteLine("Surface area of Sphere : {0}", Sph.SurfaceArea());
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");

        }
    }
    }

