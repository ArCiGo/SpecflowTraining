using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using SpecFlow.Assist.Dynamic;

namespace SpecflowIntro
{
    [Binding]
    class SampleFeatureSteps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int numbers)
        {
            Console.WriteLine(numbers);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("Pressed Add button");
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int result)
        {
            if (result == 120)
            {
                Console.WriteLine("The test passed");
            }
            else
            {
                Console.WriteLine("The test failed");
            }
        }

        [When(@"I fill all mandatory details in form")]
        public void WhenIFillAllMandatoryDetailsInForm(Table table)
        {
            //var empDetails = table.CreateSet<EmployeeDetails>();

            //foreach (EmployeeDetails item in empDetails)
            //{
            //    Console.WriteLine("Employee details");
            //    Console.WriteLine(item.Age);
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.Email);
            //    Console.WriteLine(item.Phone);
            //}

            /* Working with Dynamic Assist */
            var details = table.CreateDynamicSet();

            Console.WriteLine("Working with Dynamic Assist");
            foreach(var item in details)
            {
                Console.WriteLine("Employee details");
                Console.WriteLine(item.Age);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Email);
                Console.WriteLine(item.Phone);
            }
        }

        [When(@"I fill all mandatory details in form (.*), (.*) and (.*)")]
        public void WhenIFillAllMandatoryDetailsInFormKarthikAnd(string name, int age, Int64 phone)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Phone: " + phone);

            ScenarioContext.Current["InfoForNextStep"] = "Step 1 passed";
            Console.WriteLine(ScenarioContext.Current["InfoForNextStep"].ToString());

            List<EmployeeDetails> empDetails = new List<EmployeeDetails>()
            {
                new EmployeeDetails() { Name = "Abraham", Age =20, Email="abraham@executeautomation.com", Phone=1234567890},
                new EmployeeDetails() { Name="Mike", Age=12, Email="mike@executeautomation.com", Phone=0987654321},
                new EmployeeDetails() {Name="Jacob", Age=23, Email="jacob@executeautomation.com", Phone=5432167890}
            };

            // Save the value in ScenarioContext
            ScenarioContext.Current.Add("EmpDetails", empDetails);

            // Get the value out from Scenario Context
            var empList = ScenarioContext.Current.Get<IEnumerable<EmployeeDetails>>("EmpDetails");

            foreach(EmployeeDetails item in empList)
            {
                Console.WriteLine("The Employee name is: " + item.Name);
                Console.WriteLine("The Employee age is: " + item.Age);
                Console.WriteLine("The Employee email is: " + item.Email);
                Console.WriteLine("The Employee phone is: " + item.Phone);
                Console.WriteLine("\n");
            }

            Console.WriteLine(ScenarioContext.Current.Count);
            Console.WriteLine(ScenarioContext.Current.CurrentScenarioBlock);
        }
    }
}
