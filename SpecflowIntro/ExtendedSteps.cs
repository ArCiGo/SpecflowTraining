using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowIntro
{
    [Binding]
    public sealed class ExtendedSteps
    {
        public readonly EmployeeDetails empDetails;

        public ExtendedSteps(EmployeeDetails empDetails)
        {
            this.empDetails = empDetails;
        }

        [Then(@"I should get the same value from Extended Steps")]
        public void ThenIShouldGetTheSameValueFromExtendedSteps()
        {
            Console.WriteLine(empDetails.Age);
            Console.WriteLine(empDetails.Email);
            Console.WriteLine(empDetails.Name);
            Console.WriteLine(empDetails.Phone);
        }
    }
}
