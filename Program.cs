using System;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using CastleWindsorExample.Tests;
using CastleWindsorExample.Installers;
using CastleWindsorExample.Tests.Base;

namespace CastleWindsorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var thisContainer = CreateThisContainer();
            var thatContainer = CreateThatContainer();

            var testThisClass = thisContainer.Resolve<ITestBase>();
            testThisClass.RunTest();

            var testThatClass = thatContainer.Resolve<ITestBase>();
            testThisClass.RunTest();
        }

        static WindsorContainer CreateThisContainer()
        {
            var container = new WindsorContainer();
           container.Install( new TestThisInstaller());
            return container;
        }

        static WindsorContainer CreateThatContainer()
        {
            var container = new WindsorContainer();
            container.Install( new TestThatInstaller());
            return container;
        }




    }
}
