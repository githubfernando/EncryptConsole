using EncryptConsole.Utils;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EncryptConsole
{
    public class EncryptConsole
    {
        
        private readonly IConfiguration _configuration;
        private readonly IEncryptionHelper _encrypt;
        private readonly Messages _msg;
        public EncryptConsole(IConfiguration configuration, IEncryptionHelper eh)
        {
            _configuration = configuration;
            _encrypt = eh;
            _msg = new Messages();
            Run();
        }

        public void Run() 
        {
            string input, command ="", result=string.Empty;
            string key = _configuration["KeyApplication"];
            var options = new List<string>(){"1","2"};

            Print(_msg.title);
            while (command != "3")
            {
                input = command = result = string.Empty;
                Print(_msg.options);
                command = Read();
                if (options.Any(option => option == command))
                {
                    Print(_msg.input);
                    input = Read();
                    if (command == "1")
                        PrintResult(_encrypt.Encrypt(input, key));
                    else
                        PrintResult(_encrypt.Decrypt(input, key));
                }
                else if(command=="3")
                    Environment.Exit(0);
                else
                    Print(_msg.wrong);
            }
        }

        private void Print(string text)
        {
            Console.WriteLine(text);
        }

        private string Read()
        {
            return Console.ReadLine();
        }

        private void PrintResult(string text)
        {
            Print(_msg.result + text);
        }

    }
}
