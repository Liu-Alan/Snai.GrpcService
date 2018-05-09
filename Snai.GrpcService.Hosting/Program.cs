using Snai.GrpcService.Impl;
using System;

namespace Snai.GrpcService.Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            RpcConfig.Start();
        }
    }
}
