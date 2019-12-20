using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Airlink.Data;
using Airlink.Framework;
using Microsoft.SqlServer.Server;

namespace Airlink.BusinessLogic
{
    public class RatesBL
    {
        private AirlinkDbEntities context = DataAccess.Context;
        public Result<List<Rate>> GetAllRates(string country, int? page, int? pageSize)
        {
            var result = new Result<List<Rate>>();

            var query = from d in context.Rates
                select d;
            if (ValidationHelper.IsStringValid(country))
            {
                query = from d in query
                    where d.Country.Contains(country)
                    select d;
            }
            if (page.HasValue && pageSize.HasValue)
            {
                query = (from d in query
                    select d).Skip((page.Value - 1)*pageSize.Value).Take(pageSize.Value);
            }

            result.Data = query.ToList();
            return result;

        }

        public Result<Rate> GetRateById(string id)
        {
            var result = new Result<Rate>();

            if (ValidationHelper.IsIntValid(id))
            {
                result.HasError = true;
                result.Messages.Add("Invalid Id ");
                return result;
            }

            //int deptId = Int32.Parse(id);
            int rateId = Int32.Parse(id);

            result.Data = context.Rates.FirstOrDefault(d => d.RatesID == rateId);

            return result;
        }

        public Result<Rate> Delete(int id)
        {
            var result = new Result<Rate>();

            try
            {
                var rate = context.Rates.FirstOrDefault(d => d.RatesID == id);

                if (rate == null)
                {
                    result.HasError = true;
                    result.Messages.Add("Invalid ID");
                    return result;
                }

                context.Rates.Remove(rate);
                context.SaveChanges();

                result.Data = rate;
            }
            catch (Exception ex)
            {
                result.HasError = true;
                result.Messages.Add(ex.Message);
            }
            return result;
        }





        public Result<Rate> SaveRate(Rate r)
        {
            var result = new Result<Rate>();
            try
            {
                if (!ValidationHelper.IsStringValid(r.Country))
                {
                    result.HasError = true;
                    result.Messages.Add("Invalid Country Name");
                    return result;
                }

                if (context.Rates.Any(d => d.Country == r.Country && r.RatesID != r.RatesID))
                {
                    result.HasError = true;
                    result.Messages.Add("Name Already Exist");
                    return result;
                }

                var rate = context.Rates.FirstOrDefault(d => d.RatesID == r.RatesID);
                if (rate == null)
                {
                    rate = new Rate();
                    context.Rates.Add(rate);
                }

                rate.Country = r.Country;
                rate.DHLRate = r.DHLRate;
                rate.DPEXRate = r.DPEXRate;
                rate.TNTRate = r.TNTRate;

                context.SaveChanges();
                result.Data = rate;
            }
            catch (Exception ex)
            {
                result.HasError = true;
                result.Messages.Add(ex.Message);
            }

            return result;
        }

    }
}

