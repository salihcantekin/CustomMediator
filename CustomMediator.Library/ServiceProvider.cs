using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomMediator.Library
{
    public class ServiceProvider
    {
        private static IServiceProvider _serviceProvicer;
        public static IServiceProvider ServiceProvicer => _serviceProvicer;

        public static void SetInstance(IServiceProvider serviceProvider)
        { 
            _serviceProvicer = serviceProvider;
        }
    }
}
