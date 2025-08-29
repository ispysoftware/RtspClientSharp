using System;
using System.Runtime.Serialization;

namespace RtspClientSharp.Rtsp
{
    public class HttpBadResponseException : Exception
    {
        public HttpBadResponseException()
        {
        }

        public HttpBadResponseException(string message) : base(message)
        {
        }

        public HttpBadResponseException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}