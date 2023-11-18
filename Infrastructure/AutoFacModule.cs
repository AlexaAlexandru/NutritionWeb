using System;
using Autofac;

namespace Infrastructure
{
    public sealed class AutoFacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
        }
    }
}

