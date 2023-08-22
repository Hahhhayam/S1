﻿using Newtonsoft.Json;
using System.Text;

namespace Core.MapObj.Parsers.Program4you
{
    internal class Program4youParser
    {
        const string PATH = @"C:\Users\reset\source\repos\Courier\Core\MapObj\data\";
        public Program4youParser(string name)
        {
            string data;

            using (FileStream fs = File.OpenRead(PATH + name + ".graph"))
            {
                Console.WriteLine(fs.Name);
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                data = Encoding.Default.GetString(buffer);
            }

            Graph = JsonConvert.DeserializeObject<Program4youGraph>(data)
                ?? throw new NullReferenceException();
        }

        public Program4youGraph Graph { get; set; }
    }
}
