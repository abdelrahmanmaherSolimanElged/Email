﻿using Microsoft.AspNetCore.Mvc;

namespace Email.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public IActionResult SendEmail(MailFields email)
        {
            _emailService.SendEmail(email);
            return Ok();
        }
    }

}

