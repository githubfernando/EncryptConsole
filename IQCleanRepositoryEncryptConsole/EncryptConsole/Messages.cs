using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptConsole
{
    public class Messages
    {
        public string title { get; }
        public string options { get; }
        public string input { get; }
        public string wrong { get; }
        public string result { get; }

        public Messages()
        {
            title = "Consola de encripción para las cadenas de conexión de CleanRepository";
            options = "Digite :  1. Para encriptar   2. Para desencriptar  3.Salir";
            input = "Copie aqui la cadena de texto a convertir y presiones enter: ";
            wrong = "Opción incorrecta.";
            result = "Proceso realizado correctamente: ";
        }

    }
}
