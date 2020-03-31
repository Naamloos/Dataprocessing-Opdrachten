﻿// Keeping as a sample.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseHelper;
using DatabaseHelper.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DataprocessingApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SpotifyController : ControllerBase
    {
        private Database database;

        public SpotifyController(Database database)
        {
            this.database = database;
        }

        /// <summary>
        /// Returns a set amount of Spotify top song objects
        /// </summary>
        /// <param name="limit">Maximum amount of objects to return. Not required.</param>
        /// <returns>An array of spotify song objects.</returns>
        [HttpGet]
        public IEnumerable<SpotifyTrendingSong> Get(int limit = 25)
        {
            return database.SpotifyData.Take(limit);
        }

        [HttpGet("single")]
        public SpotifyTrendingSong Get()
        {
            return database.SpotifyData.First();
        }
    }
}
