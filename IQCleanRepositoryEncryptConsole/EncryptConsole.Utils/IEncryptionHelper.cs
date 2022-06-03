using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptConsole.Utils
{
    public interface IEncryptionHelper
    {
        string Encrypt(string text, string EncryptionKey);
        string Decrypt(string cypher, string EncryptionKey);
    }
}
