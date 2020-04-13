using System;
using System.Collections.Generic;

namespace StaticallyTypedIds
{
    public sealed class CompanyId : IEquatable<CompanyId>
    {
        public CompanyId(int value) => Value = value;

        public int Value { get; }

        public override bool Equals(object obj) => Equals(obj as CompanyId);

        public bool Equals(CompanyId other) => other != null && Value == other.Value;

        public override int GetHashCode() => HashCode.Combine(Value);

        public static bool operator ==(CompanyId left, CompanyId right) => EqualityComparer<CompanyId>.Default.Equals(left, right);

        public static bool operator !=(CompanyId left, CompanyId right) => !(left == right);
    }
}
