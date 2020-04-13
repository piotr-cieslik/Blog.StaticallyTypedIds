using System;

namespace StaticallyTypedIds
{
    public sealed class Example2
    {
        public void Run()
        {
            var company = new Company();
            var person = new Person();
            var task = new Task();

            var taskDetails =
                GetTaskDetails(
                    new CompanyId(company.Id),
                    new PersonId(person.Id),
                    new TaskId(task.Id));
        }

        public TaskDetails GetTaskDetails(
            CompanyId companyId,
            PersonId personId,
            TaskId taskId)
        {
            throw new NotImplementedException();
        }
    }
}
