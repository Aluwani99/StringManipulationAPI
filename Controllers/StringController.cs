using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Application.Services;

namespace API_Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StringController : ControllerBase
    {
        private readonly StringService _stringService;

        public StringController(StringService stringService)
        {
            _stringService = stringService;
        }

        [HttpGet("reverse-and-check-palindrome")]
        public IActionResult ReverseAndCheckPalindrome([FromQuery] string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return BadRequest("Input string cannot be null or empty.");
            }

            var reversedString = _stringService.ReverseString(input);
            var isPalindrome = _stringService.IsPalindrome(input);

            return Ok(new
            {
                ReversedString = reversedString,
                IsPalindrome = isPalindrome
            });
        }
    }
}
