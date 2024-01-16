using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
   abstract class MainList : Ilist
    {
        public string DutyName { get; set; }

        public int Priority { get; set; }
      public DateTime Date { get; set; }
        public MainList(string dutyname,int priority, DateTime date)
        {
            DutyName = dutyname;
            Priority = priority;
            Date = date;
        }

        public  virtual void ShowList()
        {
            Console.WriteLine($"dutyname:{DutyName},priority:{Priority},date:{Date}");
        }
    }
}
