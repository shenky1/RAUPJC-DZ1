using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    class CollisionDetector
    {
        static bool valueInRange(float value, float min, float max)
        { return (value >= min) && (value <= max); }

        public static bool Overlaps(IPhysicalObject2D a, IPhysicalObject2D b)
        {
            bool xOverlap = valueInRange(a.X, b.X, b.X + b.Width) ||
                           valueInRange(b.X, a.X, a.X + a.Width);

            bool yOverlap = valueInRange(a.Y, b.Y, b.Y + b.Height) ||
                            valueInRange(b.Y, a.Y, a.Y + a.Height);

            return xOverlap && yOverlap;
        }
    }
}
