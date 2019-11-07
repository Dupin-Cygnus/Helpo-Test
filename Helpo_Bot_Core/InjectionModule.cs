using Discord.WebSocket;
using Helpo_Bot_Core.Storage;
using Helpo_Bot_Core.Storage.Implementations;
using Ninject.Modules;
using Ninject.Injection;
using Ninject.Selection;
using Helpo_Bot_Core.Discord;

// Used for dependency injection
namespace Helpo_Bot_Core
{
    public class InjectionModule : NinjectModule
    {
        public override void Load()
        {

            Bind<IDataStorage>().To<JsonStorage>().InSingletonScope();
            Bind<ILogger>().To<Logger>().InSingletonScope();


            // This *should* work as an injection factory to use the GetDefault version of SocketConfig
            //  for DiscordSocketConfig as default.
            // Unity version:
            //  _container.RegisterType<DiscordSocketConfig>(new InjectionFactory(i => SocketConfig.GetDefault()));
            Bind<DiscordSocketConfig>().ToMethod(context => SocketConfig.GetDefault());

            // Still figuring this one out. Want to use a specific constructor instead of an empty one for DiscordSocketClient
            // Unity version:
            //  _container.RegisterSingleton<DiscordSocketClient>(new InjectionConstructor(typeof(DiscordSocketConfig)));
            // This attempt made based on the following post:
            //  https://github.com/ninject/ninject/issues/120#issuecomment-33205796
            Bind<DiscordSocketClient>().ToSelf().InSingletonScope().WithConstructorArgument(typeof(DiscordSocketConfig));
            /* Previous attempt
            Bind<DiscordSocketClient>(new ConstructorInjector(typeof(DiscordSocketConfig)))
                .ToSelf().InSingletonScope();
            */

            Bind<Discord.Connection>().ToSelf().InSingletonScope();
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
