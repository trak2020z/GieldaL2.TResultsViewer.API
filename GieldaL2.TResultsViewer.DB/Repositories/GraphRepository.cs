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

        public List<GeneratorLog> Get(string DateFrom, string DateTo)
        {
            IQueryable<GeneratorLog> query = _context.GeneratorLog;
            if(!string.IsNullOrEmpty(DateFrom))
            {
                DateTime.TryParse(DateFrom, out DateTime DateF);
                query = query.Where(x => x.TestStartTime > DateF);
            }
            if (!string.IsNullOrEmpty(DateTo))
            {
                DateTime.TryParse(DateTo, out DateTime DateT);
                query = query.Where(x => x.TestStartTime < DateT.AddDays(1));
            }
            return query.ToList();
        }
    }
}
