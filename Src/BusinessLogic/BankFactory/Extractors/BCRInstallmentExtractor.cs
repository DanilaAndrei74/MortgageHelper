using BusinessLogic.Services;
using Models;
using MortgageHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BankFactory.Extractors
{
    public class BCRInstallmentExtractor : BaseInstallmentExtractor
    {
        public override List<string> ExtractInstallments(string filePath)
        {
            var pdfText = ExtractTextFromPdf(filePath);
            var lines = GetLinesFromRegex(pdfText, Constants.RegexPatterns.BCR);

            return lines;
        }
    }
}
