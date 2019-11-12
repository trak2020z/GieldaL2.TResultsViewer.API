using GieldaL2.TResultsViewer.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GieldaL2.TResultsViewer.DB.Repositories
{
    public class GraphRepository
    {
        private readonly GieldaL2TesterContext _context;
        public GraphRepository()
        {
            _context = new GieldaL2TesterContext();
        }

        public List<GeneratorLog> Get()
        {
            return _context.GeneratorLog.ToList();
        }
    }
}
