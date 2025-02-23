using Models.Interfaces;
using MortgageHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IInstallmentExtractor
    {
        List<string> ExtractInstallments(string filePath);
    }
}
