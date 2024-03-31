using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Shared
{
    public  class ResultT<TValue> :Result
    {
        private readonly TValue? _value;
        protected internal ResultT(TValue? value, bool isSuccess,Error error):base(isSuccess,error)
        {
            _value = value;
        }
        public TValue? Value =>IsSuccess 
            ?_value 
            : throw new InvalidOperationException("the value of a failure result can not be accessed .");
        public static implicit operator ResultT<TValue>(TValue? value)=>Create(value);
    }
}
