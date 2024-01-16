using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Duty
    {
        private static List<Ilist> _tasks = new List<Ilist>();
        public static void ADDTasks(int type, string name, int Priority,DateTime date, int hour)
        {
            if (type == 1)
            {
                var personal = new PersonalDuty(name, Priority, date);
                personal.DutyName = name;
                personal.Priority = Priority;
                personal.Date = DateTime.Now.AddHours(hour);
                _tasks.Add(personal);
            }
            if (type == 2)
            {
                var job = new JobList(name, Priority, date);
                job.DutyName = name;
                job.Priority = Priority;
                job.Date = DateTime.Now.AddHours(hour);
                _tasks.Add(job);
            }
        }
        public static void ShowTasks()
        {

            foreach (var task in _tasks)
            {
                task.ShowList();
            }

        }
    }
}
