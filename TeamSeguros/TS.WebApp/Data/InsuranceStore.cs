using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TS.WebApp.Models;

namespace TS.WebApp.Data
{
    public class InsuranceStore
    {
        public TSContext Context { get; set; }
        public InsuranceStore(TSContext context)
        {
            Context = context;
        }

        internal void DeleteInsurance(Guid id)
        {
            var insurance = Context.Insurance.FirstOrDefault(x => x.Id == id);
            Context.Insurance.Remove(insurance);
            Context.SaveChanges();
        }

        internal List<Insurance> GetInsurances()
        {
            return Context.Insurance.ToList();
        }

        
    }
}
