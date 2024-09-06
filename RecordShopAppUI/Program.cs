using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using RecordShopAppDAL.Concrete;
using RecordShopAppDAL.Context;
using RecordShopAppDAL.Interface;
using RecordShopService.Services;
using WindowsFormsApp2;

namespace RecordShopAppUI
{
    internal static class Program
    {


        //static IAlbumRepo albumRepo = new AlbumRepo();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {



            AppDbContext context = new AppDbContext();

            AdminRepo adminRepo = new AdminRepo(context);
            AdminService adminService = new AdminService(adminRepo);

            AlbumRepo albumRepo = new AlbumRepo(context);
            AlbumService albumService = new AlbumService(albumRepo);
            ReportService reportService = new ReportService(albumRepo);
            LoginService loginService = new LoginService(adminService);




            //var serviceCollection = new ServiceCollection();
            ////ConfigureServices(serviceCollection);
            //var serviceProvider = serviceCollection.BuildServiceProvider();
            //Application.EnableVisualStyles();



            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login(albumService,adminService, reportService,loginService));
        }
        //public static void ConfigureServices(ServiceCollection services)
        //{
        //    services.AddDbContext<AppDbContext>(options => options.UseSqlServer("Data Source=DESKTOP-4810D6L\\SQLEXPRESS;Initial Catalog=RecordShopDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False"));

        //    services.AddScoped<IAdminService, AdminService>();

        // //   services.AddScoped<IAdminRepo, AdminRepo>();

        //}

    }
}