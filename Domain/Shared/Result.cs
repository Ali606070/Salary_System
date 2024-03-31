using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Shared
{
    public class Result
    {
        public bool IsSuccess { get; }
        public bool IsFailure => !IsSuccess;
        public Error Error { get; }
        protected internal Result(bool isSuccess , Error error)
        {
            if (isSuccess && error != Error.None || !isSuccess && error == Error.None)
            {
                throw new ArgumentException("Invalid Error",nameof(error));
            }
            IsSuccess = isSuccess;
            Error = error;

        }

        public static Result Success() =>new(true,Error.None);

        public static ResultT<TValue> Success<TValue>(TValue value) => new(value, true, Error.None);
        
        public static Result Failure(Error error) => new(false, error);
        public static ResultT<TValue> Failure<TValue>(Error error) => new(default(TValue), false, error);
           

        public static ResultT<TValue> Create<TValue>(TValue? value)
        {
            if (value != null)
            {
                return new ResultT<TValue>(value, true, Error.None);
            }
            else
            {
                return new ResultT<TValue>(default, false, new Error("ValueIsNull", "The value is null."));
            }
        }
    }
}
