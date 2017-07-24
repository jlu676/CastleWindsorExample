using System;

namespace CastleWindsorExample.Tests.Dependencies
{
    public class Finder : IFinder
    {
        public string Discover(string search)
        {
           return $"Found {search}";
        }
    }
}