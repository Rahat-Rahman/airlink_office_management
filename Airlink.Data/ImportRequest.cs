//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Airlink.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ImportRequest
    {
        public int Id { get; set; }
        public int Status { get; set; }
        public string SenderName { get; set; }
        public string SenderContactNo { get; set; }
        public string Medium { get; set; }
        public string AirbillNo { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverAddress { get; set; }
        public string ReceiverContact { get; set; }
        public string ParcelType { get; set; }
        public Nullable<bool> IsArrived { get; set; }
    }
}
