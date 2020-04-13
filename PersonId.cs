using System;
using System.Collections.Generic;

namespace StaticallyTypedIds
{
    public sealed class PersonId : IEquatable<PersonId>
    {
        public PersonId(int value) => Value = value;

        public int Value { get; }

        public override bool Equals(object obj) => Equals(obj as PersonId);

        public bool Equals(PersonId other) => other != null && Value == other.Value;

        public override int GetHashCode() => HashCode.Combine(Value);

        public static bool operator ==(PersonId left, PersonId right) => EqualityComparer<PersonId>.Default.Equals(left, right);

        public static bool operator !=(PersonId left, PersonId right) => !(left == right);
    }
}
