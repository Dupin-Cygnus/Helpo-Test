using Helpo_Bot_Core.Storage;
using Helpo_Bot_Core.Storage.Implementations;
using Unity;

namespace Helpo_Bot_Core
{
    public static class Unity
    {
        private static UnityContainer _container;

        public static UnityContainer Container
        {
            get
            {
                if (_container == null)
                    RegisterTypes();
                return _container;
            }
        }

        public static void RegisterTypes()
        {
            _container = new UnityContainer();
            _container.RegisterType<IDataStorage, InMemoryStorage>();
        }
    }
}
