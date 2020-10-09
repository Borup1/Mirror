using System;

namespace Mirror.Tests
{
    public class FakeNetworkConnection : NetworkConnectionToClient
    {
        public FakeNetworkConnection() : base(1, 0)
        {
        }

        public override string address => "Test";

        public override void Disconnect()
        {
            // nothing
        }

        internal override bool Send(ArraySegment<byte> segment, int channelId = 0)
        {
            return true;
        }
    }
}
