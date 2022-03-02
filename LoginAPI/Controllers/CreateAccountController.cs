using LoginAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginAPI.Controllers
{
    [Route("CreateAccount")]
    [ApiController]
    public class CreateAccountController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<LoginDetails>> PostLoginDetails(LoginDetails loginDetails)
        {
            _context.LoginDetails.Add(loginDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLoginDetails", new { id = loginDetails.Id }, loginDetails);
        }

    }
}
