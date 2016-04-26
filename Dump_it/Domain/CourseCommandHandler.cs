using iCertify.Domain.Course.Commands;
using iCertify.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCertify.Domain.Course
{
    public class CourseCommandHandler
    {
        private readonly IRepository<CourseAggregate> _repository;

        public CourseCommandHandler(IRepository<CourseAggregate> repository)
        {
            _repository = repository;
        }

        public void Handle(CreateCourse message)
        {
            var item = new CourseAggregate(message.CourseId, message.Name);
            _repository.Save(item, -1);
        }

        public void Handle(DeactivateCourse message)
        {
            var item = _repository.GetById(message.CourseId);
            item.Deactivate();
            _repository.Save(item, message.OriginalVersion);
        }

        public void Handle(RemoveCourse message)
        {
            var item = _repository.GetById(message.CourseId);
            item.Remove();
            _repository.Save(item, message.OriginalVersion);
        }

        public void Handle(AddCourse message)
        {
            var item = _repository.GetById(message.CourseId);
            item.CheckIn();
            _repository.Save(item, message.OriginalVersion);
        }

        public void Handle(RenameCourse message)
        {
            var item = _repository.GetById(message.CourseId);
            item.ChangeName(message.NewName);
            _repository.Save(item, message.OriginalVersion);
        }
    }
}
