using System;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using MyOwnSite.BusinessService;
using MyOwnSite.DataAccess;
using MyOwnSite.Interfaces;
using MyOwnSite.Validators;

namespace MyOwnSite.App_Start
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below. Make sure to add a Microsoft.Practices.Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your types here
            // container.RegisterType<IProductRepository, ProductRepository>();

            //container.RegisterType<IExportService, ExportService>();
            container.RegisterType<ICommentDao, CommentDao>();
            container.RegisterType<ICommentService, CommentService>();
            container.RegisterType<IPostDao, PostDao>();
            container.RegisterType<IUserDao, UserDao>();
            container.RegisterType<IUserService, UserService>();
            container.RegisterType<IPostService, PostService>();
            container.RegisterType<IUserContext, UserContext>();
            container.RegisterType<IValidator, RegistrationValidator>();


        }
    }
}
