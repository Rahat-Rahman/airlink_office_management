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
    public class ImportRequestBL
    {
        private AirlinkDbEntities context = DataAccess.Context;
        public Result<List<ImportRequest>> GetAllRequests(string airbill,int statusID,int? page, int? pageSize)
        {
            var result = new Result<List<ImportRequest>>();

            var query = from d in context.ImportRequests where d.Status==statusID 
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

        public Result<ImportRequest> GetRequestById(int id)
        {
            var result = new Result<ImportRequest>();

            if (ValidationHelper.IsIntValid(id+""))
            {
                result.HasError = true;
                result.Messages.Add("Invalid Airbill No. ");
                return result;
            }

            int impId = id;

            //result.Data = context.ExportRequests.FirstOrDefault(d => d.Id == empId+"");
            result.Data = context.ImportRequests.FirstOrDefault(e => e.Id == impId);

            return result;
        }

        public Result<ImportRequest> Delete(int id)
        {
            var result = new Result<ImportRequest>();

            try
            {
                var importReqTable = context.ImportRequests.FirstOrDefault(e => e.Id == id);
                if (importReqTable == null)
                {
                    result.HasError = true;
                    result.Messages.Add("Invalid ID");
                    return result;
                }

                context.ImportRequests.Remove(importReqTable);
                context.SaveChanges();

                result.Data = importReqTable;
            }
            catch (Exception ex)
            {
                result.HasError = true;
                result.Messages.Add(ex.Message);
            }
            return result;
        }





        public Result<ImportRequest> SaveImportTable(ImportRequest imp)
        {
            var result = new Result<ImportRequest>();
            try
            {
                if (!ValidationHelper.IsStringValid(imp.ParcelType))
                {
                    result.HasError = true;
                    result.Messages.Add("Invalid Info");
                    return result;
                }
                
                if (!ValidationHelper.IsStringValid(imp.SenderContactNo))
                {
                    result.HasError = true;
                    result.Messages.Add("Invalid Info");
                    return result;
                }
                if (!ValidationHelper.IsStringValid(imp.SenderName))
                {
                    result.HasError = true;
                    result.Messages.Add("Invalid Info");
                    return result;
                }
                if (!ValidationHelper.IsStringValid(imp.ReceiverName))
                {
                    result.HasError = true;
                    result.Messages.Add("Invalid Info");
                    return result;
                }
                if (!ValidationHelper.IsStringValid(imp.ReceiverContact))
                {
                    result.HasError = true;
                    result.Messages.Add("Invalid Info");
                    return result;
                }
                if (!ValidationHelper.IsStringValid(imp.ReceiverAddress))
                {
                    result.HasError = true;
                    result.Messages.Add("Invalid Info");
                    return result;
                }
               

                var importRequest = context.ImportRequests.FirstOrDefault(d => d.Id == imp.Id);
                if (importRequest == null)
                {

                    importRequest = new ImportRequest();
                    importRequest.Id = imp.Id;
                    context.ImportRequests.Add(importRequest);
                }


                importRequest.Status =imp.Status;
                importRequest.ReceiverName = imp.ReceiverName;
                importRequest.ReceiverAddress = imp.ReceiverAddress;
                importRequest.ReceiverContact = imp.ReceiverContact;
                importRequest.SenderName = imp.SenderName;
                importRequest.SenderContactNo = imp.SenderContactNo;
                importRequest.ParcelType = imp.ParcelType;
                importRequest.Medium = imp.Medium;

                if (imp.AirbillNo != null)
                {
                    importRequest.AirbillNo = imp.AirbillNo;
                }
                



                context.SaveChanges();
                result.Data = importRequest;
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

