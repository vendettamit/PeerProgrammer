using iCertify.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCertify.Domain.Course.Events
{
    public sealed class CourseDeactivated : Event
    {
        public readonly Guid Id;

        public CourseDeactivated(Guid id)
        {
            Id = id;
        }
    }

    public sealed class CourseCreated : Event
    {
        public readonly Guid Id;
        public readonly string Name;
        public CourseCreated(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public sealed class CourseRenamed : Event
    {
        public readonly Guid Id;
        public readonly string NewName;

        public CourseRenamed(Guid id, string newName)
        {
            Id = id;
            NewName = newName;
        }
    }

    public sealed class CourseAdded : Event
    {
        public Guid Id;

        public CourseAdded(Guid id)
        {
            Id = id;
        }
    }

    public sealed class CourseRemoved : Event
    {
        public Guid Id;

        public CourseRemoved(Guid id)
        {
            Id = id;
        }
    }
}
