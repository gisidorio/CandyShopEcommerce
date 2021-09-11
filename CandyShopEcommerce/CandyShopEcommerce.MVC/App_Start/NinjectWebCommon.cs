[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(CandyShopEcommerce.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(CandyShopEcommerce.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace CandyShopEcommerce.MVC.App_Start
{
    using System;
    using System.Web;
    using CandyShopEcommerce.Application;
    using CandyShopEcommerce.Application.Interfaces;
    using CandyShopEcommerce.Domain.Interfaces.Repositories;
    using CandyShopEcommerce.Domain.Interfaces.Services;
    using CandyShopEcommerce.Domain.Services;
    using CandyShopEcommerce.Infra.Data.Repositories;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application.
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            // COMPANIES
            kernel.Bind<ICompanyAppService>().To<CompanyAppService>();
            kernel.Bind<ICompanyService>().To<CompanyService>();
            kernel.Bind<ICompanyRepository>().To<CompanyRepository>();

            // PRODUCTS
            kernel.Bind<IProductAppService>().To<ProductAppService>();
            kernel.Bind<IProductService>().To<ProductService>();
            kernel.Bind<IProductRepository>().To<ProductRepository>();

            // COMPANIES X PRODUCTS
            kernel.Bind<ICompanyProductAppService>().To<CompanyProductAppService>();
            kernel.Bind<ICompanyProductService>().To<CompanyProductService>();
            kernel.Bind<ICompanyProductRepository>().To<CompanyProductRepository>();

            // CITIES
            kernel.Bind<ICityAppService>().To<CityAppService>();
            kernel.Bind<ICityService>().To<CityService>();
            kernel.Bind<ICityRepository>().To<CityRepository>();

            // EMPLOYEES
            kernel.Bind<IEmployeeAppService>().To<EmployeeAppService>();
            kernel.Bind<IEmployeeService>().To<EmployeeService>();
            kernel.Bind<IEmployeeRepository>().To<EmployeeRepository>();

            // DEPARTMENTS
            kernel.Bind<IDepartmentAppService>().To<DepartmentAppService>();
            kernel.Bind<IDepartmentService>().To<DepartmentService>();
            kernel.Bind<IDepartmentRepository>().To<DepartmentRepository>();

            // POSITIONS
            kernel.Bind<IPositionAppService>().To<PositionAppService>();
            kernel.Bind<IPositionService>().To<PositionService>();
            kernel.Bind<IPositionRepository>().To<PositionRepository>();

            // CLIENTS
            kernel.Bind<IClientAppService>().To<ClientAppService>();
            kernel.Bind<IClientService>().To<ClientService>();
            kernel.Bind<IClientRepository>().To<ClientRepository>();

            // USERS
            kernel.Bind<IUserAppService>().To<UserAppService>();
            kernel.Bind<IUserService>().To<UserService>();
            kernel.Bind<IUserRepository>().To<UserRepository>();

            // FAQS
            kernel.Bind<IFAQAppService>().To<FAQAppService>();
            kernel.Bind<IFAQService>().To<FAQService>();
            kernel.Bind<IFAQRepository>().To<FAQRepository>();

            // IMAGES
            kernel.Bind<IImageAppService>().To<ImageAppService>();
            kernel.Bind<IImageService>().To<ImageService>();
            kernel.Bind<IImageRepository>().To<ImageRepository>();

            // KEYWORDS
            kernel.Bind<IKeywordAppService>().To<KeywordAppService>();
            kernel.Bind<IKeywordService>().To<KeywordService>();
            kernel.Bind<IKeywordRepository>().To<KeywordRepository>();

            // KEYWORDS X PRODUCTS
            kernel.Bind<IKeywordProductAppService>().To<KeywordProductAppService>();
            kernel.Bind<IKeywordProductService>().To<KeywordProductService>();
            kernel.Bind<IKeywordProductRepository>().To<KeywordProductRepository>();
        }
    }
}