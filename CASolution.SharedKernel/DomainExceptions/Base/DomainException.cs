﻿using System;

namespace CASolution.SharedKernel.DomainExceptions.Base
{
    public class DomainException : Exception
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
