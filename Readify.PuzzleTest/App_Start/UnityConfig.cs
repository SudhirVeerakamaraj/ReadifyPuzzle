using Microsoft.Practices.Unity;
using Readify.PuzzleTest.BusinessLogicLayer.Implementations;
using Readify.PuzzleTest.BusinessLogicLayer.Interfaces;
using System.Web.Http;
using Unity.WebApi;

namespace Readify.PuzzleTest
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<ITriangleTypeLogic, TriangleTypeLogic>();
            container.RegisterType<IFibonacciLogic, FibonacciLogic>();
            container.RegisterType<IReverseWordsLogic, ReverseWordsLogic>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}