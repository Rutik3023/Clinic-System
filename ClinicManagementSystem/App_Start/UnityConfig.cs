using ClinicManagementSystem.Iservises;
using ClinicManagementSystem.Servises;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace ClinicManagementSystem
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterType<IClinic, ClinicRepo>();
            container.RegisterType<IDoctor, DoctorRepo>();
            container.RegisterType<IStaff, StaffRepo>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}