using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstution
{
    //Bu sınıfı da Nuget'de bir paket olarak düşünün.
    public class Geometry
    {
        public IArea CreateRectangle(int unit1, int unit2=1)
        {

            //bir biçimde....
            if (unit2 ==1 )
            {
                return new Square { Side = unit1 };
            }
            return new Rectangle { Width = unit1, Height = unit2 };
        }
    }

    public interface IArea
    {
        int Area();

    }

    public class Rectangle : IArea
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int Area()
        {
            return Width * Height;
        }
    }

    public class Square :IArea //: Rectangle
    {
        public int Side { get; set; }

        public int Area()
        {
          return Side * Side;
        }
    }
}
