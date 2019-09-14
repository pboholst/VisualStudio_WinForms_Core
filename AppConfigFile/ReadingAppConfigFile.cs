using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoholStreet.AppConfigFile
{
    public class ReadingAppConfigFile
    {
        public ReadingAppConfigFile()
        {
            MethodName();
        }
        /* Prerequisite
         *  1. Reference -> Add Reference -> Assemblies  -> System.Configuration
         *  2. using System.Configuration;
         *  3. using System.Collections.Specialized;
         *  4. In App.config file add
         *      <configuration>
         *          <appSettings>
         *              <add key="key one" value="the value of 1"/>
         *              <add key="key two" value="the value of 2"/>
         *              <add key="key three" value="the value of 3"/>
         *          </appSettings>
         *      </configuration>
         * **/

        public static void MethodName()
        {
            // Read one of the keys from app.config file
            string s1 = ConfigurationManager.AppSettings["key one"];
            Console.WriteLine(s1);

            // Read all the keys from the app.config file
            NameValueCollection sAll = ConfigurationManager.AppSettings;

            foreach (string s in sAll.AllKeys)
                Console.WriteLine("Key: " + s + " Value: " + sAll.Get(s));
        }
    }
}
