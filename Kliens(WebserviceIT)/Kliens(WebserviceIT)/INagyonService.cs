using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Kliens_WebserviceIT_
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "INagyonService" in both code and config file together.
    [ServiceContract]
    public interface INagyonService
    {
        [OperationContract]
        string[] DoWork(string minta);
    }
}
