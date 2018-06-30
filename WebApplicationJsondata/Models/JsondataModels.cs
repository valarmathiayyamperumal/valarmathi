using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationJsondata.Models
{
    public class JsondataModels 
    {
        public string Id { get; set; }

        public string ApplicationId { get; set; }
        public string Type { get; set; }
        public string Summary { get; set; }
        public string  Amount { get; set; }
        public string PostingDate { get; set; }
        public string IsCleared { get; set; }

        public string ClearedDate { get; set; }

       
    }
}