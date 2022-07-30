using KonusarakOgren.DataAccess.Abstract;
using KonusarakOgren.DataAccess.EntityFramework.Abstract;

namespace KonusarakOgrenDemo.Mvc.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void Scoped(this IServiceCollection services)
        {
            services.AddScoped <IAddressRepository, AddressRepository> ();
            services.AddScoped <IBaseAttributeRepository, BaseAttributeRepository> ();
            services.AddScoped <ICartItemRepository, CartItemRepository> ();
            services.AddScoped <ICartRepository, CartRepository> ();
            services.AddScoped <ICategoryAttributeRepository, CategoryAttributeRepository> ();
            services.AddScoped <ICategoryRepository, CategoryRepository> ();
            services.AddScoped <ICommentRepository, CommentRepository> ();
            services.AddScoped <IDiscountRepository, DiscountRepository> ();
            services.AddScoped <IOrderItemRepository, OrderItemRepository> ();
            services.AddScoped <IOrderRepository, OrderRepository> ();
            services.AddScoped <IProductRepository, ProductRepository> ();
            services.AddScoped <IStoreRepository, StoreRepository> ();
            services.AddScoped <IVariantRepository, VariantRepository> ();

            //services.AddScoped <, > ();
        }
    }
}
