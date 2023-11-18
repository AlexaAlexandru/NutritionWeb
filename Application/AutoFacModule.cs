using System;
using System.Reflection;
using Application.Behaviours;
using Autofac;
using MediatR;
using MediatR.Extensions.Autofac.DependencyInjection;
using MediatR.Extensions.Autofac.DependencyInjection.Builder;

namespace Application
{
    public sealed class AutoFacModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterMediatR(MediatRConfigurationBuilder.Create(ThisAssembly).WithAllOpenGenericHandlerTypesRegistered().Build());

            builder.RegisterGeneric(typeof(ValidationBehaviour<,>)).As(typeof(IPipelineBehavior<,>)).InstancePerLifetimeScope();

        }
    }
}

