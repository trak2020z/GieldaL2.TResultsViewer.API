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
        private GraphRepository _repository { get; set; }
        public GraphService(GieldaL2TesterContext context)
        {
            _repository = new GraphRepository(context);
        }

        public GraphsDTO GetData(string DateFrom, string DateTo)
        {
            List<GeneratorLog> data= _repository.Get(DateFrom, DateTo);
            GraphsDTO graphs = new GraphsDTO();
            data.ForEach(x => graphs.Graphs.Add(GraphDTO.FromDB(x)));
            return graphs;
        }

        public DeleteDTO ClearData()
        {
            try
            {
                _repository.Delete();

                return new DeleteDTO()
                {
                    Success = true
                };
            }
            catch(Exception e)
            {
                return new DeleteDTO()
                {
                    Success = false,
                };
            }
        }
    }
}
