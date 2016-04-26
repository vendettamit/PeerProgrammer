using iCertify.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCertify.Domain.Course.Commands
{
    public sealed class DeactivateCourse : Command
    {
        public readonly Guid CourseId {get; private set;}
        public readonly int OriginalVersion { get; private set; }

        public DeactivateCourse(Guid courseId, int originalVersion)
        {
            CourseId = courseId;
            OriginalVersion = originalVersion;
        }
    }

    public sealed class CreateCourse : Command
    {
        public readonly Guid CourseId { get; private set; }
        public readonly string Name { get; private set; }

        public CreateCourse(Guid courseId, string name)
        {
            CourseId = courseId;
            Name = name;
        }
    }

    public sealed class RenameCourse : Command
    {
        public readonly Guid CourseId { get; private set; }
        public readonly string NewName{ get; private set; }
        public readonly int OriginalVersion{ get; private set; }

        public RenameCourse(Guid courseId, string newName, int originalVersion)
        {
            CourseId = courseId;
            NewName = newName;
            OriginalVersion = originalVersion;
        }
    }

    public sealed class AddCourse : Command
    {
        public readonly Guid CourseId { get; private set; }

        public readonly int OriginalVersion { get; private set; }

        public AddCourse(Guid courseId, int originalVersion)
        {
            CourseId = courseId;
            OriginalVersion = originalVersion;
        }
    }

    public sealed class RemoveCourse : Command
    {
        public readonly Guid CourseId { get; private set; }
        public readonly int OriginalVersion { get; private set; }

        public RemoveCourse(Guid courseId, int originalVersion)
        {
            CourseId = courseId;
            OriginalVersion = originalVersion;
        }
    }
}
