using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Primitives
{
    public abstract class ValueObject:IEquatable<ValueObject>
    {
        public abstract IEnumerable<object> GetAtomicValue();
        public override bool Equals(object? obj)
        {
            return obj is ValueObject other && ValueAreEqual(other);
        }

        public override int GetHashCode()
        {
            return GetAtomicValue()
                .Aggregate(
                    default(int),HashCode.Combine
                );
        }
        private bool ValueAreEqual(ValueObject other)
        {
            return GetAtomicValue().SequenceEqual(other.GetAtomicValue());
        }

        public bool Equals(ValueObject? other)
        {
           return other is not null && ValueAreEqual(other);
        }

        public static bool operator ==(ValueObject? first, ValueObject? second)
        {
            return first is not null && second is not null && first.Equals(second);
        }
        public static bool operator !=(ValueObject? first, ValueObject? second)
        {
            return !(first == second);
        }
    }
}
