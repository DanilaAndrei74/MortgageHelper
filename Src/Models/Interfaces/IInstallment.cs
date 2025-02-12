using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    public interface IInstallment
    {
        double Principal { get; }
        double Interest { get; }
        double Insurance { get; }
        double Total { get; }
    }
}
