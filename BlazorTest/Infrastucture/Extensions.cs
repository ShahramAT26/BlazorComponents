using System.Reflection;

namespace BlazorTest.Infrastucture
{
    public static class Extensions
    {
        public static string GetFieldValue(this object obj,  string field)
        {
            if (obj.GetType().IsPrimitive || obj.GetType() == typeof(string) || 
                obj.GetType().IsEnum || string.IsNullOrEmpty(field))
            {
                return obj.ToString();
            }
            else
            {
                return obj.GetType().GetProperty(field).GetValue(obj, null).ToString();
            }
        }
    }
}
