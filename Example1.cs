using System;

namespace StaticallyTypedIds
{
    public sealed class Example1
    {
        public void Run()
        {
            var company = new Company();
            var person = new Person();
            var task = new Task();

            {
                // Correct order.
                var taskDetails =
                    GetTaskDetails(
                        company.Id,
                        person.Id,
                        task.Id);
            }

            {
                // Incorrect order.
                var taskDetails =
                    GetTaskDetails(
                        person.Id,
                        company.Id,
                        task.Id);
            }
        }

        public TaskDetails GetTaskDetails(
            int companyId,
            int personId,
            int taskId)
        {
            // Implementation here.
            throw new NotImplementedException();
        }
    }
}
