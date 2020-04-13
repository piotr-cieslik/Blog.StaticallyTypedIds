using System;
using System.Collections.Generic;

namespace StaticallyTypedIds
{
    public sealed class EmployeeId : IEquatable<EmployeeId>
    {
        public EmployeeId(
            CompanyId companyId,
            PersonId personId)
        {
            CompanyId = companyId;
            PersonId = personId;
        }

        public CompanyId CompanyId { get; }

        public PersonId PersonId { get; }

        public override bool Equals(object obj) => Equals(obj as EmployeeId);

        public bool Equals(EmployeeId other) =>
            other != null &&
                Equals(CompanyId, other.CompanyId) &&
                Equals(PersonId, other.PersonId);

        public override int GetHashCode() => HashCode.Combine(CompanyId, PersonId);

        public static bool operator ==(EmployeeId left, EmployeeId right) => EqualityComparer<EmployeeId>.Default.Equals(left, right);

        public static bool operator !=(EmployeeId left, EmployeeId right) => !(left == right);
    }
}
