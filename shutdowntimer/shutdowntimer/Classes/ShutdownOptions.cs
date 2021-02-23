using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shutdowntimer.Classes
{
    public static class ShutdownOptions
    {
        public enum Options
        {
            ShutdownIn,
            ShutdownAt,
            ShutdownOn
        };

        public enum Actions
        {
            Shutdown,
            Restart,
            Logout,
        };
    }
}
