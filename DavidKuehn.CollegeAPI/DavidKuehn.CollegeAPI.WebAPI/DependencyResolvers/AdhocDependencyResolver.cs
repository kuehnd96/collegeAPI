﻿using DavidKuehn.CollegeAPI.Core;
using DavidKuehn.CollegeAPI.Core.Interfaces;
using DavidKuehn.CollegeAPI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;

namespace DavidKuehn.CollegeAPI.WebAPI.DependencyResolvers
{
    public class AdhocDependencyResolver : IDependencyResolver, IDisposable
    {
        //NOTE: If this was production code this class would start up a 3rd-party IOC container instance

        public IDependencyScope BeginScope()
        {
            return new AdhocDependencyResolver();
        }

        public void Dispose()
        {
            // Dispose of IOC container
        }

        public object GetService(Type serviceType)
        {
            // Ad-hoc dependency injection
            if (serviceType == typeof(ITuitionCalculator))
            {
                return new AdvicentTuitionCalculator();
            }

            if (serviceType == typeof(ICollegeRepository))
            {
                return new CollegeCSVRepository();
            }

            return null;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            // Resolve multiple things
            return new List<object>();
        }
    }
}