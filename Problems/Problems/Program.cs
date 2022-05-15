using Autofac;
using Problems.Solutions;
using System;

namespace Problems
{
    internal class Program
    {
        private static IContainer _container;

        private static void Main(string[] args)
        {
            RegisterType();

            using (var scope = _container.BeginLifetimeScope())
            {
                var currentSolution = scope.Resolve<ISolution>();
                currentSolution.Exec();
            }

            Console.ReadLine();
        }

        private static void RegisterType()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Solution35>().As<ISolution>();
            _container = builder.Build();
        }
    }
}