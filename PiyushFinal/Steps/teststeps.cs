using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace PiyushFinal.Steps
{
    [Binding]
    class teststeps
    {



        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            Console.WriteLine("ghghh");
        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            Console.WriteLine("ghghh");
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            Console.WriteLine("yyyy");
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            Console.WriteLine("oooo");
        }

    }
}
