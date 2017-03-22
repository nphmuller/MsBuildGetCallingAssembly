using Microsoft.AspNetCore.Hosting;
using System;
using Xunit;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            var server = new Microsoft.AspNetCore.TestHost.TestServer(
                new Microsoft.AspNetCore.Hosting.WebHostBuilder().UseStartup<Api.Startup>());
        }
    }
}
