using System;
using Autofac;

namespace NutritionBackend
{
    public sealed class AutoFacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<Application.AutoFacModule>();
            builder.RegisterModule<Infrastructure.AutoFacModule>();
        }
    }
}

