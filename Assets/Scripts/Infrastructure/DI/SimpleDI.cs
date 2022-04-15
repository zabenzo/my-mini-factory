using Infrastructure.Services;

namespace Infrastructure.DI
{
    public class SimpleDI
    {
        private static SimpleDI _instance;
        public static SimpleDI Container => _instance ??= new SimpleDI();

        public void RegisterSingle<TService>(TService implementation) where TService : IService => 
            Implementation<TService>.ServiceInstance = implementation;

        public TService Single<TService>() where TService : IService => 
            Implementation<TService>.ServiceInstance;

        private static class Implementation<TService> where TService : IService
        {
            public static TService ServiceInstance;
        }
    }
}