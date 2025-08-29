using System;
using System.Runtime.Serialization;

namespace RtspClientSharp.MediaParsers
{
    public class MediaPayloadParserException : Exception
    {
        public MediaPayloadParserException()
        {
        }

        public MediaPayloadParserException(string message) : base(message)
        {
        }

        public MediaPayloadParserException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}