using CarPartsMarketplace.Business.Services.Abstract;
using CarPartsMarketplace.Core.Utilities.Results;
using CarPartsMarketplace.Core.Utilities.Security.Jwt;
using CarPartsMarketplace.Entities.Dtos.ApplicationUser;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using IResult = CarPartsMarketplace.Core.Utilities.Results.IResult;


namespace CarPartsMarketplace.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : BaseApiController
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
            return Unauthorized(userToLogin);
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

            var host = HttpContext.Request.Host;
            var registerResult = await _authService.Register(userForRegisterDto);
            if (registerResult.Success)
            {
                return Ok(registerResult);
            }
            return BadRequest(registerResult);
        }
        /// <summary>
        /// Email Confirmation Endpoint
        /// </summary>
        /// <param name="confirmationDto"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet("email-confirmation")]
        public async Task<IActionResult> EmailConfirmation([FromQuery]UserEmailConfirmationDto confirmationDto)
        {            
            var registerResult = await _authService.EmailConfirmation(confirmationDto);
            if (registerResult.Success)
            {
                return Ok(registerResult);
            }
            return BadRequest(registerResult);
        }
        /// <summary>
        /// Account Activation Endpoint
        /// </summary>
        /// <param name="confirmationDto"></param>
        /// <returns></returns>
        ///
        [Authorize]
        [HttpGet("account-activation")]
        public async Task<IActionResult> AccountActivation([FromQuery] AccountActivationDto accountActivationDto)
        {
            var registerResult = await _authService.AccountActivation(accountActivationDto);
            if (registerResult.Success)
            {
                return Ok(registerResult);
            }
            return BadRequest(registerResult);
        }
    }
}
