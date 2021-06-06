﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult:Result
    {
        public ErrorResult(bool success,string message):base(success,message)
        {

        }

        public ErrorResult(string message):base(false,message)
        {

        }

        public ErrorResult():base(false)
        {

        }
    }
}
