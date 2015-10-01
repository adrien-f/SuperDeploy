using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SuperDeploy.Supervisor.Tests
{
    public class SupervisorTests
    {
        private readonly SupervisorClient _client;

        public SupervisorTests()
        {
            _client = new SupervisorClient("127.0.0.1", 8888);
        }

        [Fact]
        public void GetApiVersion()
        {
            var version = _client.Api.GetApiVersion();
            Assert.Equal(version, "3.0");
        }

        [Fact]
        public void GetAllProcesses()
        {
            var processes = new List<Process>(_client.Api.GetAllProcesses());
            Assert.True(processes.Count >= 0);
        }
    }
}
