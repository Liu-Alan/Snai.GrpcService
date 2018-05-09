using Grpc.Core;
using Snai.GrpcService.Protocol;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snai.GrpcClient
{
    public static class MsgServiceClient
    {
        private static Channel _channel;
        private static MsgService.MsgServiceClient _client;

        static MsgServiceClient()
        {
            _channel = new Channel("127.0.0.1:40001", ChannelCredentials.Insecure);
            _client = new MsgService.MsgServiceClient(_channel);
        }

        public static GetMsgSumReply GetSum(int num1, int num2)
        {
            return _client.GetSum(new GetMsgNumRequest
            {
                Num1 = num1,
                Num2 = num2
            });
        }
    }
}
