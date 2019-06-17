using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;


namespace RemotingServiceHost
{
    class Program
    {
        static void Main()
        {
            OpetRemotingService.OpetRemotingService remotingService = new OpetRemotingService.OpetRemotingService();

            TcpChannel channel = new TcpChannel(8080);
            ChannelServices.RegisterChannel(channel);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(OpetRemotingService.OpetRemotingService), "GetMessage", WellKnownObjectMode.Singleton);

            Console.WriteLine("Remoting server started @ " + DateTime.Now);
            Console.ReadLine();

        }
    }
}
