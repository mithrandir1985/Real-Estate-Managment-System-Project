using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS
{
    internal class transfer
    {
        private static List<transfer> users = new List<transfer>();
        public string usern { get; set; }
        public string pass { get; set; }
        public void trans()
        {
            Console.WriteLine("Saved");
            users.Add(this);
        }
        public static List<transfer> getuser()
        {
            return users;
        }

        public string getpass()
        {
            return pass;
        }
    }
}
