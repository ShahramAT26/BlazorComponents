using BlazorTest.Infrastucture;
using System.Diagnostics.CodeAnalysis;

namespace BlazorTest.Infrastructure
{
    public class EComparer<T> : IEqualityComparer<T>
    {
        private readonly string _field;

        public EComparer(string field)
        {
            _field = field;
        }

        public bool Equals(T? x, T? y)
        {
            bool isEqual = GetHashCode(x) == GetHashCode(y);
            return isEqual;
        }

        public int GetHashCode([DisallowNull] T obj)
        {
            int hashCode = obj.GetFieldValue(_field).GetHashCode();
            return hashCode;
        }
    }
}
