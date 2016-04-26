using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCertify.Infrastructure
{
    public interface IMessage
    {
        // Marker interface
    }

    public class Event : IMessage
    {
        public int Version { get; set; }
    }
}
