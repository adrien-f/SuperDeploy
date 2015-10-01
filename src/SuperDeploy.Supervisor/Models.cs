using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookComputing.XmlRpc;

namespace SuperDeploy.Supervisor
{
    public class Process
    {
        [XmlRpcMember("name")]
        public string Name { get; set; }
        [XmlRpcMember("group")]
        public string Group { get; set; }
        [XmlRpcMember("start")]
        public int Start { get; set; }
        [XmlRpcMember("stop")]
        public int Stop { get; set; }
        [XmlRpcMember("now")]
        public int Now { get; set; }
        [XmlRpcMember("state")]
        public int State { get; set; }
        [XmlRpcMember("statename")]
        public string StateName { get; set; }
        [XmlRpcMember("stdout_logfile")]
        public string StdoutLogFile { get; set; }
        [XmlRpcMember("stderr_logfile")]
        public string StderrLogFile { get; set; }
        [XmlRpcMember("spawnerr")]
        public string SpawnErr { get; set; }
        [XmlRpcMember("exitstatus")]
        public int ExitStatus { get; set; }
        [XmlRpcMember("pid")]
        public int Pid { get; set; }
    }
}
