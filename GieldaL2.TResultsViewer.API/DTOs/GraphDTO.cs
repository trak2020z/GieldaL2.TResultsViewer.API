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
        public string RespType { get; set; }
        public int BackendTime { get; set; }
        public int DbSelectsQuantity { get; set; }
        public int DbSelectsTime { get; set; }
        public int DbUpdatesQuantity { get; set; }
        public int DbUpdatesTime { get; set; }
        public int DbInsertsQuantity { get; set; }
        public int DbInsertsTime { get; set; }
        public int DbDeletesQuantity { get; set; }
        public int DbDeletesTime { get; set; }
        public static GraphDTO FromDB(GeneratorLog model)
        {
            return new GraphDTO()
            {
                ActiveClientsQuantity = model.ActiveClientsQuantity,
                TestStartTime = model.TestStartTime.ToString(),
                ReqType=model.ReqType,
                ReqTime=model.ReqTime,
                BackendTime=model.BackendTime,
                DbSelectsQuantity=model.DbSelectsQuantity,
                DbSelectsTime=model.DbSelectsTime,
                DbUpdatesQuantity=model.DbUpdatesQuantity,
                DbUpdatesTime=model.DbUpdatesTime,
                DbInsertsQuantity=model.DbInsertsQuantity,
                DbInsertsTime=model.DbInsertsTime,
                DbDeletesQuantity=model.DbDeletesQuantity,
                DbDeletesTime=model.DbDeletesTime,
                RespType=model.RespType
    };
        }
    }
}
