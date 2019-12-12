using GieldaL2.TResultsViewer.API.DTOs;
using GieldaL2.TResultsViewer.DB.Models;
using GieldaL2.TResultsViewer.DB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GieldaL2.TResultsViewer.API.Services
{
    public class GraphService
    {
        public static GraphsDTO GetData(string DateFrom, string DateTo)
        {
            GraphRepository _repository = new GraphRepository();
            List<GeneratorLog> data= _repository.Get(DateFrom, DateTo);
            GraphsDTO graphs = new GraphsDTO();
            data.ForEach(x => graphs.Graphs.Add(GraphDTO.FromDB(x)));
            return graphs;
        }
    }
}
