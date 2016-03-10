
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using Sample.Core.ViewModels;

namespace Sample.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<EmployeeViewModel>();
           // RegisterAppStart<ViewModels.EmployeeViewModel>();
        }
    }
}