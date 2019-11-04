using Helpo_Bot_Core.Storage;
using Helpo_Bot_Core.Storage.Implementations;
using Ninject.Modules;

// Used for dependency injection
namespace Helpo_Bot_Core
{
    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDataStorage>().To<InMemoryStorage>().InSingletonScope();

            /*
            Format: Bind<Interface>().To<Class>().InSingletonScope();
            Format: Bind<Class>().ToSelf().InSingletonScope();
            InSingletonScope() when there's only one instance of the thing being binded to

            In other classes
            using Ninject;
            /...
            IKernel kernel = new StandardKernel(new ApplicationModule());
            objectType newObject = kernel.Get<objectType>();
            */
        }
    }
}
