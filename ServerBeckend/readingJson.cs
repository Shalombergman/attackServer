using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;


namespace attackServer
{
    internal class readingJson
    {
        static string  filePathToRead = "../../missiles.json";

        public static async Task<string> ReadJsonFile()
        {
            string jsonContent =await Task.Run(() => File.ReadAllText(filePathToRead));          
            return jsonContent;
        }
    }

}



