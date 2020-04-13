using System;
using System.Collections.Generic;

namespace StaticallyTypedIds
{
    public sealed class TaskId : IEquatable<TaskId>
    {
        public TaskId(int value) => Value = value;

        public int Value { get; }

        public override bool Equals(object obj) => Equals(obj as TaskId);

        public bool Equals(TaskId other) => other != null && Value == other.Value;

        public override int GetHashCode() => HashCode.Combine(Value);

        public static bool operator ==(TaskId left, TaskId right) => EqualityComparer<TaskId>.Default.Equals(left, right);

        public static bool operator !=(TaskId left, TaskId right) => !(left == right);
    }
}
