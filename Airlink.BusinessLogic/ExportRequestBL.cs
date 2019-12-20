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
    public class ExportRequestBL
    {
        private AirlinkDbEntities context = DataAccess.Context;
        public Result<List<ExportRequest>> GetAllRequests(string airbill,int statusID,int? page, int? pageSize)
        {
            var result = new Result<List<ExportRequest>>();

            var query = from d in context.ExportRequests where d.Status==statusID
                        select d;
            if (ValidationHelper.IsIntValid(airbill))
            {
                query = from d in query
                        where d.AirbillNo.Contains(airbill)
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

        public Result<ExportRequest> GetRequestById(int id)
        {
            var result = new Result<ExportRequest>();

            if (ValidationHelper.IsIntValid(id+""))
            {
                result.HasError = true;
                result.Messages.Add("Invalid Airbill No. ");
                return result;
            }

            int expId = id;

            //result.Data = context.ExportRequests.FirstOrDefault(d => d.Id == empId+"");
            result.Data = context.ExportRequests.FirstOrDefault(e => e.Id == expId);

            return result;
        }

        public Result<ExportRequest> Delete(int id)
        {
            var result = new Result<ExportRequest>();

            try
            {
                var exportReqTable = context.ExportRequests.FirstOrDefault(e => e.Id == id);
                if (exportReqTable == null)
                {
                    result.HasError = true;
                    result.Messages.Add("Invalid ID");
                    return result;
                }

                context.ExportRequests.Remove(exportReqTable);
                context.SaveChanges();

                result.Data = exportReqTable;
            }
            catch (Exception ex)
            {
                result.HasError = true;
                result.Messages.Add(ex.Message);
            }
            return result;
        }





        public Result<ExportRequest> SaveExportTable(ExportRequest exp)
        {
            var result = new Result<ExportRequest>();
            try
            {
                if (!ValidationHelper.IsStringValid(exp.ParcelType))
                {
                    result.HasError = true;
                    result.Messages.Add("Invalid Info");
                    return result;
                }
                if (!ValidationHelper.IsStringValid(exp.SenderAddress))
                {
                    result.HasError = true;
                    result.Messages.Add("Invalid Info");
                    return result;
                }
                if (!ValidationHelper.IsStringValid(exp.SenderContactNo))
                {
                    result.HasError = true;
                    result.Messages.Add("Invalid Info");
                    return result;
                }
                if (!ValidationHelper.IsStringValid(exp.SenderName))
                {
                    result.HasError = true;
                    result.Messages.Add("Invalid Info");
                    return result;
                }
                if (!ValidationHelper.IsStringValid(exp.ReceiverCountry))
                {
                    result.HasError = true;
                    result.Messages.Add("Invalid Info");
                    return result;
                }
                if (!ValidationHelper.IsStringValid(exp.SenderContactNo))
                {
                    result.HasError = true;
                    result.Messages.Add("Invalid Info");
                    return result;
                }
                if (!ValidationHelper.IsStringValid(exp.ReceiverAddress))
                {
                    result.HasError = true;
                    result.Messages.Add("Invalid Info");
                    return result;
                }
                if (!ValidationHelper.IsStringValid(exp.ReceiverName))
                {
                    result.HasError = true;
                    result.Messages.Add("Invalid Info");
                    return result;
                }






                var exportRequest = context.ExportRequests.FirstOrDefault(d => d.Id == exp.Id);
                if (exportRequest == null)
                {

                    exportRequest = new ExportRequest();
                    exportRequest.Id = exp.Id;
                    context.ExportRequests.Add(exportRequest);
                }


                exportRequest.Status = exp.Status;
                exportRequest.ReceiverName = exp.ReceiverName;
                exportRequest.ReceiverCountry = exp.ReceiverCountry;
                exportRequest.ReceiverAddress = exp.ReceiverAddress;
                exportRequest.ReceiverContactNo = exp.ReceiverContactNo;
                exportRequest.SenderName = exp.SenderName;
                exportRequest.SenderAddress = exp.SenderAddress;
                exportRequest.SenderContactNo = exp.SenderContactNo;
                exportRequest.ParcelType = exp.ParcelType;
                exportRequest.Medium = exp.Medium;

                if (exp.AirbillNo != null)
                {
                    exportRequest.AirbillNo = exp.AirbillNo;
                }
                



                context.SaveChanges();
                result.Data = exportRequest;
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

