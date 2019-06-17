using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpetRemotingService
{
    public class OpetRemotingService : MarshalByRefObject, IOpetRemotingService.IOpetRemotingService
    {
        public string GetMessage(string ime)
        {
            return "Vase ima je: " + ime;
        }
    }
}
