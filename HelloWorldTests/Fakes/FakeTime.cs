using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldTests.Fakes
{
    public class FakeTime : ITime
    {
        public DateTime DateToReturn { get; set; }

        public DateTime Date
        {
            get
            {
                return DateToReturn;
            }
        }
    }
}
