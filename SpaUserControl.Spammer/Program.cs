using Microsoft.Practices.Unity;
using SpaUserControl.Domain.Contracts.Services;
using SpaUserControl.Startup;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpaUserControl.Spammer
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = new CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;

            var container = new UnityContainer();
            DependencyResolver.Resolve(container);

            var service = container.Resolve<IUserService>();
            try
            {
                service.Register("Diego Neves", "diegoneves1989@gmail.com", "diegoneves", "diegoneves");
                Console.WriteLine("Usuário cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                service.Dispose();
            }

            Console.ReadKey();
        }
    }
}
