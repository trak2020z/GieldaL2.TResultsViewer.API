using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GieldaL2.TResultsViewer.API.DTOs;
using GieldaL2.TResultsViewer.API.Services;
using GieldaL2.TResultsViewer.DB.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GieldaL2.TResultsViewer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GraphController : ControllerBase
    {
        private GraphService _graphService { get; set; }
        public GraphController(GieldaL2TesterContext context)
        {
            _graphService = new GraphService(context);
        }


        [HttpGet]
        public GraphsDTO Get(string DateFrom, string DateTo)
        {   
            return _graphService.GetData(DateFrom, DateTo);
        }

        [HttpDelete]
        public DeleteDTO Delete()
        {   
            return _graphService.ClearData();
        }
    }
}