using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator.Infrastructure.Interfaces;

namespace TaxCalculator.Application
{
    public class Taxation
    {
        protected readonly IAccount _account;
        public Taxation(IAccount account)
        {
            this._account = account;
        }
    }
}
