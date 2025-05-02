using System;

namespace WOLTool.Common
{
    public sealed class WOLException : Exception
    {
        public WOLException()
        {
        }

        public WOLException(string message)
            : base(message)
        {
        }

        public WOLException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
