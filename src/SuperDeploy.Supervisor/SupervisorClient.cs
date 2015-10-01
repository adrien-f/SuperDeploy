using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookComputing.XmlRpc;

namespace SuperDeploy.Supervisor
{
    public class SupervisorClient
    {
        public ISupervisorRpc Api { get; set; }
        public SupervisorClient(string hostname, int port, string scheme = "http", string username = null, string password = null)
        {
            Api = XmlRpcProxyGen.Create<ISupervisorRpc>();
            Api.Url = new UriBuilder(scheme, hostname, port, "RPC2").ToString();
        }
    }

    public interface ISupervisorRpc : IXmlRpcProxy
    {
        [XmlRpcMethod("supervisor.getAPIVersion")]
        string GetApiVersion();

        [XmlRpcMethod("supervisor.getAllProcessInfo")]
        Process[] GetAllProcesses();
    }
}
