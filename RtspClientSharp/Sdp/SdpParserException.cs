using System;
using System.Runtime.Serialization;

namespace RtspClientSharp.Sdp
{
    public class SdpParserException : Exception
    {
        public SdpParserException()
        {
        }

        public SdpParserException(string message) : base(message)
        {
        }

        public SdpParserException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}