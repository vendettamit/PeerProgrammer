using iCertify.Domain.Course.Events;
using iCertify.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCertify.Domain.Course
{
    public class CourseAggregate : AggregateRoot
    {
        private bool _activated;
        private Guid _id;

        public CourseAggregate()
        {
            // used to create in repository ... many ways to avoid this, eg making private constructor
        }

        public CourseAggregate(Guid id, string name)
        {
            ApplyChange(new CourseCreated(id, name));
        }

        public void ChangeName(string newName)
        {
            if (string.IsNullOrEmpty(newName)) throw new ArgumentException("newName");
            ApplyChange(new CourseRenamed(_id, newName));
        }

        public void Remove()
        {
            ApplyChange(new CourseRemoved(_id));
        }


        public void CheckIn()
        {
            ApplyChange(new CourseAdded(_id));
        }

        public void Deactivate()
        {
            if(!_activated) throw new InvalidOperationException("already deactivated");
            ApplyChange(new CourseDeactivated(_id));
        }

        public override Guid Id
        {
            get { return _id; }
        }

        private void Apply(CourseCreated e)
        {
            _id = e.Id;
            _activated = true;
        }

        private void Apply(CourseDeactivated e)
        {
            _activated = false;
        }
    }
}
