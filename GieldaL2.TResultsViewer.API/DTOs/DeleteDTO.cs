using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GieldaL2.TResultsViewer.API.DTOs
{
    public class DeleteDTO
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}
