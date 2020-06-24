using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepertoireMachine.Api.Models;
using RepertoireMachine.Api.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RepertoireMachine.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        private readonly ISongData songData;
        private readonly IWebHostEnvironment env;
        private readonly IMapper mapper;

        public SongController(ISongData songData, IWebHostEnvironment env, IMapper mapper)
        {
            this.songData = songData;
            this.env = env;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                //var result = await _songData.GetSongs();
                var result = songData.GetSongs();

                SongModel[] models = mapper.Map<SongModel[]>(result);
                return Ok(models);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Could not retreive from DB");
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(uint id)
	    {
            return this.StatusCode(StatusCodes.Status501NotImplemented, "Not Yet Implemented");
	    }
    }
}
