﻿using CarPartsMarketplace.Business.Services.Abstract;
using CarPartsMarketplace.Core.Utilities.Results;
using CarPartsMarketplace.Core.Utilities.Security.Jwt;
using CarPartsMarketplace.Entities.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using IResult = CarPartsMarketplace.Core.Utilities.Results.IResult;


namespace CarPartsMarketplace.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        /// <summary>
        /// Login Endpoint
        /// </summary>
        /// <param name="userForLoginDto"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [Consumes("application/json")]
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IDataResult<AccessToken>))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized, Type = typeof(string))]
        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLoginDto userForLoginDto)
        {
            var userToLogin = await _authService.Login(userForLoginDto);
            if (userToLogin.Success)
            {
                return Ok(userToLogin);
            }
            return BadRequest(userToLogin);
        }
        /// <summary>
        /// Register Endpoint
        /// </summary>
        /// <param name="userForRegisterDto"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [Consumes("application/json")]
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IResult))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(IResult))]
        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            var registerResult = await _authService.Register(userForRegisterDto);
            if (registerResult.Success)
            {
                return Ok(registerResult);
            }
            return BadRequest(registerResult);
        }

       
    }
}
