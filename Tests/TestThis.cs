using System;
using CastleWindsorExample.CommonDependencies;
using CastleWindsorExample.Tests.Dependencies;
using CastleWindsorExample.Tests.Base;

namespace CastleWindsorExample.Tests
{
    public class TestThis : TestBase, ITestBase
    {
        public TestThis(ILogger Logger, ITester Tester, IFinder Finder):base(Logger, Tester, Finder) {}
        public void RunTest()
        {

            _logger.Log(_finder.Discover("This"));


            if (_tester.RunTest())
            {
                _logger.Log("Successful Ran This");
            }
            else
            {
                _logger.Log("Failed To Run This");
            }
        }

    }
}