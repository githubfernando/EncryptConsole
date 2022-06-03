using EncryptConsole.Utils;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace EncryptConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("EncryptConsoleSettings.json", optional: true, reloadOnChange: true)
                    .AddJsonFile("EncryptConsoleSettings.json", optional: true, reloadOnChange: true);
            IConfiguration Configuration = builder.Build();

            //ServiceCollection services = new ServiceCollection();
            //services.AddTransient<IEncryptionHelper, EncryptionHelper>();
            //ServiceProvider = services.BuildServiceProvider();
            IEncryptionHelper encrypt = new EncryptionHelper();
            EncryptConsole app = new EncryptConsole(Configuration, encrypt);
        }
        

    }
}
