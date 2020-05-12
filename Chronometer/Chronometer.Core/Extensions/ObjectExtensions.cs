using System;

namespace Chronometer.Core.Extensions
{
    public static class ObjectExtensions
    {
        public static int ToInt(this object value)
        {
            return value == null || string.IsNullOrEmpty(value.ToString())
                ? default(int)
                : Convert.ToInt32(value);
        }
    }
}
