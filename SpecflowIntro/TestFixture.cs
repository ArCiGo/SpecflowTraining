using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowIntro
{
    [Binding]
    public sealed class TestFixture
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeFeature]
        public static void BeforeFeatures()
        {
            Console.WriteLine("Calling before features");
        }
        
        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("Calling before scenario");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("Calling after scenario");
        }
    }
}
