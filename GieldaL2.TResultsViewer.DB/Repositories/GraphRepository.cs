using GieldaL2.TResultsViewer.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace GieldaL2.TResultsViewer.DB.Repositories
{
    public class GraphRepository
    {
        private readonly GieldaL2TesterContext _context;
        public GraphRepository(GieldaL2TesterContext context)
        {
            _context = context;
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
                query = query.Where(x => x.TestStartTime < DateT);
            }
            return query.ToList();
        }
        public void Delete()
        {
            _context.GeneratorLog.FromSql("DELETE FROM [dbo].[generator_log]").ToList(); ;
        }
    }
}
