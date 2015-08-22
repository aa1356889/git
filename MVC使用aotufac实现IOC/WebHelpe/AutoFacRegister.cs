using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autofac.Integration.Mvc;
using Autofac;
using System.Reflection;
namespace WebHelpe
{
    /// <summary>
    /// 用于注册autufac的方法
    /// </summary>
   public class AutoFacRegister
    {
       public static void Register()
       {
           //初始化一个autofac容器
           var autoConainer = new ContainerBuilder();
           //告诉autofac查找控制器类需要扫描的程序集
           autoConainer.RegisterControllers(Assembly.Load("Test"));

           //将指定程序集下的类的实例保存到autofac容器 用于注入
           autoConainer.RegisterTypes(Assembly.Load("DAL").GetTypes()).AsImplementedInterfaces();
           autoConainer.RegisterTypes(Assembly.Load("BLL").GetTypes()).AsImplementedInterfaces();

          var c=autoConainer.Build();
           //告诉mvc底层  创建控制器由autofac 容器接管
           System.Web.Mvc.DependencyResolver.SetResolver(new AutofacDependencyResolver(c));

       }

    }
}
