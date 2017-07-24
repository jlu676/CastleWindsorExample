using System;

namespace CastleWindsorExample.Tests.Dependencies
{
    public interface IFinder
    {
        string Discover(string search);
    }
}