using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicPerformance.Entities
{
    public abstract class BaseItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
