using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GieldaL2.TResultsViewer.API.DTOs;
using GieldaL2.TResultsViewer.API.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GieldaL2.TResultsViewer.API.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("newpolicy")]
    [ApiController]
    public class GraphController : ControllerBase
    {
        [HttpGet]
        [Route("last")]
        public GraphsDTO Get()
        {
            return GraphService.GetData();
        }
    }
}