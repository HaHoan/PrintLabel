using System;

namespace PrintLabel.Common
{
    public static class ObjectMethods
    {
        public static bool IsEquals<T>(this T obj, T other)
        {
            if (obj is ValueType)
            {
                return obj.Equals(other);
            }
            return (object) obj == (object) other;
        }

        public static bool IsNull<T>(this T obj)
        {
            return !(obj is ValueType) && obj == null;
        }
    }
}
