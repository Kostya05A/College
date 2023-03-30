using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClassLibrary
{
    public class Geometry
    {
        public double Compute(double r, double h, double volt)
        {
            throw new NotImplementedException();
        }

        struct Cylinder
        {
            public double H { get; set; }
            public double R { get; set; }
            public Cylinder(double h, double r)
            {
                H = h;
                R = r;
            }
            public double Volt() => 2 * Math.PI * R * H;
            public double Sas() => 2 * Math.PI * R * (R + H);
            public override string ToString() => $"H = {H}; R = {R}; S = {Sas().ToString("0.###")}; V={Volt().ToString("0.###")}";
        }   
    }
}
