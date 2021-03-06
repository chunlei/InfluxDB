﻿// <copyright file="RandomStatusCodeController.cs" company="Allan Hardy">
// Copyright (c) Allan Hardy. All rights reserved.
// </copyright>

using MetricsInfluxDBSandboxMvc.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace MetricsInfluxDBSandboxMvc.JustForTesting
{
    [Route("api/[controller]")]
    public class RandomStatusCodeController : Controller
    {
        private readonly RandomValuesForTesting _randomValuesForTesting;

        public RandomStatusCodeController(RandomValuesForTesting randomValuesForTesting)
        {
            _randomValuesForTesting = randomValuesForTesting;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return StatusCode(_randomValuesForTesting.NextStatusCode());
        }
    }
}
