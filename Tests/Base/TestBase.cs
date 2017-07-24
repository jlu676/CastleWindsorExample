using System;
using CastleWindsorExample.CommonDependencies;
using CastleWindsorExample.Tests.Dependencies;

namespace CastleWindsorExample.Tests.Base
{
    public class TestBase
    {
        protected ILogger _logger;
        protected ITester _tester;
        protected IFinder _finder;

        public TestBase(ILogger Logger, ITester Tester, IFinder Finder)
        {
            _logger = Logger;
            _tester = Tester;
            _finder = Finder;
        }
    }
}