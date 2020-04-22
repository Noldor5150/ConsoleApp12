using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double AverageMark { get; set; }
        public bool IsGettingTuition { get; set; }


        public override string ToString()
        {
            return $"Student {Id} {Name} - age:{Age} mark:{AverageMark} tuition:{IsGettingTuition}";
        }
    }

}
