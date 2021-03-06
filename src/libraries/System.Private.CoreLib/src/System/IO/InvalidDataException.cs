// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.Serialization;

namespace System.IO
{
    [Serializable]
    [System.Runtime.CompilerServices.TypeForwardedFrom("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
    public sealed class InvalidDataException : SystemException
    {
        public InvalidDataException()
            : base(SR.GenericInvalidData)
        {
        }

        public InvalidDataException(string? message)
            : base(message)
        {
        }

        public InvalidDataException(string? message, Exception? innerException)
            : base(message, innerException)
        {
        }

        private InvalidDataException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
