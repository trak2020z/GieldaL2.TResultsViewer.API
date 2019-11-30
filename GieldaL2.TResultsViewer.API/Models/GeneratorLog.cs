using System;
using System.Collections.Generic;

namespace GieldaL2.TResultsViewer.API.Models
{
    public partial class GeneratorLog
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ActiveClientsQuantity { get; set; }
        public DateTime TestStartTime { get; set; }
        public string TestType { get; set; }
        public int ReqNo { get; set; }
        public string ReqType { get; set; }
        public string RespType { get; set; }
        public int ReqTime { get; set; }
        public int BackendTime { get; set; }
        public int DbSelectsQuantity { get; set; }
        public int DbSelectsTime { get; set; }
        public int DbUpdatesQuantity { get; set; }
        public int DbUpdatesTime { get; set; }
        public int DbInsertsQuantity { get; set; }
        public int DbInsertsTime { get; set; }
        public int DbDeletesQuantity { get; set; }
        public int DbDeletesTime { get; set; }
    }
}
