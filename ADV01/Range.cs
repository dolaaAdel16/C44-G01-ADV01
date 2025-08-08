using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV01
{
    public class Range<T> where T : IComparable<T>
    {
        private T minimum;
        private T maximum;

       
        public Range(T minimum, T maximum)
        {
            
            if (minimum.CompareTo(maximum) > 0)
                throw new ArgumentException("Minimum value cannot be greater than maximum value");

            this.minimum = minimum;
            this.maximum = maximum;
        }

        
        public bool IsInRange(T value)
        {
            return value.CompareTo(minimum) >= 0 && value.CompareTo(maximum) <= 0;
        }

       
        public dynamic Length()
        {
           
            if (minimum is int && maximum is int)
                return (int)(object)maximum - (int)(object)minimum;
            if (minimum is double && maximum is double)
                return (double)(object)maximum - (double)(object)minimum;
            if (minimum is float && maximum is float)
                return (float)(object)maximum - (float)(object)minimum;

            throw new NotSupportedException("Length calculation not supported for this type");
        }
    }
}
