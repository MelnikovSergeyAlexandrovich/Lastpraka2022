using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace lastpractin2022___________
{
    internal class jsonchik
    {
       
        public static void Serialize<T>(T User, string filename)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string json = JsonConvert.SerializeObject(User);
            File.WriteAllText(desktop + "\\" + filename, json);
            
        }
        public static T Deserialize<T>(string fileName)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string json = File.ReadAllText(desktop + "\\" + fileName);
            T humans = JsonConvert.DeserializeObject<T>(json);
            return humans;
        }
    }
}
