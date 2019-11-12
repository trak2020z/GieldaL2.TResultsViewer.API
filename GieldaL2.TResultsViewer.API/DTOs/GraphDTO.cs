using GieldaL2.TResultsViewer.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GieldaL2.TResultsViewer.API.DTOs
{
    public class GraphDTO
    {
        public int ActiveClientsQuantity { get; set; }
        public string TestStartTime { get; set; }
        public string ReqType { get; set; }
        public int ReqTime { get; set; }
        public int BackendTime { get; set; }
        public static GraphDTO FromDB(GeneratorLog model)
        {
            return new GraphDTO()
            {
                ActiveClientsQuantity = model.ActiveClientsQuantity,
                TestStartTime = model.TestStartTime.ToString(),
                ReqType=model.ReqType,
                ReqTime=model.ReqTime,
                BackendTime=model.BackendTime
            };
        }
    }
}
