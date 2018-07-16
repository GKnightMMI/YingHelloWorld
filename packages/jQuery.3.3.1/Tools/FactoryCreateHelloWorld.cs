using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldClass
{
    public static class FactoryCreateHelloWorld
    {

        public static string GetHellowWorld(string AccessType)
        {
            switch (AccessType)
            {
                case "Simple":
                    return "Hello World";

                case "Database":
                    //Database Context function
                    return "Under Construction";

                default:
                    return "unknown";
            }


        }
    }
}
