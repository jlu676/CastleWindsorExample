using System;
using CastleWindsorExample.CommonDependencies;
using CastleWindsorExample.Tests.Dependencies;
using CastleWindsorExample.Tests.Base;

namespace CastleWindsorExample.Tests
{
    public class TestThat: TestBase, ITestBase
    {
        public TestThat(ILogger Logger, ITester Tester, IFinder Finder):base(Logger, Tester, Finder) {}

         public void RunTest()
        {

            _logger.Log(_finder.Discover("That"));


            if (_tester.RunTest())
            {
                _logger.Log("Successful Ran That");
            }
            else
            {
                _logger.Log("Failed To Run That");
            }
        }
    }
}