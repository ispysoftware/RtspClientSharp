using System;
using System.Runtime.Serialization;

namespace RtspClientSharp.Rtsp
{
    public class RtspClientException : Exception
    {
        public RtspClientException()
        {
        }

        public RtspClientException(string message) : base(message)
        {
        }

        public RtspClientException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}