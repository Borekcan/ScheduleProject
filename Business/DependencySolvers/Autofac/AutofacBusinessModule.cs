﻿using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using Core.Utilities.Security.JWT.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencySolvers.Autofac
{
  public  class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
           

            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();

            builder.RegisterType<MeetingManager>().As<IMeetingService>().SingleInstance();
            builder.RegisterType<EfMeetingDal>().As<IMeetingDal>().SingleInstance();

            builder.RegisterType<VoteManager>().As<IVoteService>().SingleInstance();
            builder.RegisterType<EfVoteDal>().As<IVoteDal>().SingleInstance();

            builder.RegisterType<AuthManager>().As<IAuthService>().SingleInstance();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>().SingleInstance();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();


        }
    }
}
