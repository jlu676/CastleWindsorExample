using System;
using CastleWindsorExample.Installers.Base;
using CastleWindsorExample.Tests;
using CastleWindsorExample.Tests.Dependencies;
using Castle.Windsor;
using Castle.MicroKernel.Registration;


namespace CastleWindsorExample.Installers
{
    public class TestThatInstaller : CastleInstaller
    {
        public TestThatInstaller () : base(typeof(TestThat)){}

        public override void AddCustomDependicies(IWindsorContainer container)
        {
            container.Register(Component.For<IFinder>().ImplementedBy<Finder>());
        } 
    }
}