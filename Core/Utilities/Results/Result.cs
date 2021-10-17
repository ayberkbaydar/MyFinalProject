using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        public Result(bool success, string message):this(success)//otomatik olarak tek parametreli ctor'u da çalıştıracak.
        {
            //get=>readonly (ctor içinde set işlemi yapılabilir.)
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}

