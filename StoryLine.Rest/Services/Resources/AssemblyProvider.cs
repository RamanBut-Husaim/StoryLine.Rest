using System;
using System.Collections.Generic;
using System.Reflection;

namespace StoryLine.Rest.Services.Resources
{
    public class AssemblyProvider : IAssemblyProvider
    {
        private Assembly[] _assemblies = new Assembly[0];

        public Assembly[] Assemblies
        {
            get => _assemblies;
            set => _assemblies = value ?? throw new ArgumentNullException(nameof(value));
        }

        public IEnumerable<Assembly> GetAssemblies()
        {
            return Assemblies;
        }
    }
}