using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Quartz
{
    public  class JobSchedule
    {
        public Type JobType { get; }
   

        public JobSchedule(Type jobType)
        {
            JobType = jobType;
           
        }
    }
}
