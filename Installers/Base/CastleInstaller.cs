using System;
using System.Reflection;
using System.Linq;
using CastleWindsorExample.CommonDependencies;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Components;
using Castle.MicroKernel.SubSystems.Configuration;


namespace CastleWindsorExample.Installers.Base
{
    public class CastleInstaller : IWindsorInstaller
    {
        private Assembly _assembly;
        private Type _classType;

        public CastleInstaller(Type ClassType)
        {
            _classType = ClassType;
            _assembly = ClassType.GetTypeInfo().Assembly;
        }

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            var classInterface = _classType.GetInterfaces().SingleOrDefault();
            container.Register(Classes.FromAssemblyContaining(_classType).BasedOn(classInterface)
                .WithService
                .AllInterfaces()
                .LifestyleTransient());
            AddCustomDependicies(container);
            AddCommonDependicies(container);
        }

        public virtual void AddCustomDependicies(IWindsorContainer container)
        {

        }


        public void AddCommonDependicies(IWindsorContainer container)
        {
            container.Register(Classes.FromAssembly(typeof(Logger).GetTypeInfo().Assembly)
                .Where(Component.IsInNamespace("CastleWindsorExample.CommonDependencies"))
                .WithService.DefaultInterfaces()
                .LifestyleTransient());
        }

    }
}