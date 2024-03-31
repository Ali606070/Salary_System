using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Shared
{
    public sealed record Error(string Code , string? Descripton=null)
    {
        public static readonly Error None = new(string.Empty);
    }
}
