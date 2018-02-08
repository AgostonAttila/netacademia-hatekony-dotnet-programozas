using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Kliens_WebserviceIT_
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "NagyonService" in both code and config file together.
    public class NagyonService : INagyonService
    {
        string[] DoWork(string minta)
        {
            string[] retval = new string[10];

            for (int i = 0; i < 10; i++)
            {
                retval[i] = string.Format("{0}-{1}", minta, i);
            }
            return retval;
        }
    }
}
