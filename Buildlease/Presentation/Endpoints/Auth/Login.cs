﻿using System;
using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Services.Abstractions;

namespace Presentation.Endpoints.Auth
{
    [Route("api")]
    public class Login : EndpointBaseSync
        .WithRequest<LoginRequest>
        .WithActionResult
    {
        private readonly IServiceManager _serviceManager;
        public Login(IServiceManager serviceManager) => _serviceManager = serviceManager;

        [HttpPost("Login")]
        public override ActionResult Handle([FromBody] LoginRequest request)
        {
            try
            {
                _serviceManager.AuthService.Login(request.Login, request.Password);
            }
            catch (InvalidOperationException ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
            return new OkResult();
        }
    }

    public class LoginRequest
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
