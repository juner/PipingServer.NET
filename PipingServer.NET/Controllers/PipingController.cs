﻿using System;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Piping.Attributes;
using Piping.Models;

namespace Piping.Controllers
{
    [Route("")]
    [ApiController]
    [DisableFormValueModelBinding]
    public class PipingController : ControllerBase
    {
        readonly IWaiters Waiters;
        readonly Encoding Encoding;
        public PipingController(IWaiters Waiters, Encoding Encoding)
        {
            this.Waiters = Waiters;
            this.Encoding = Encoding;
        }
        [HttpPut("/{**RelativeUri}")]
        [HttpPost("/{**RelativeUri}")]
        public IActionResult Upload(string RelativeUri)
        {
            try
            {
                return Waiters.AddSender(RelativeUri, HttpContext);
            }catch(InvalidOperationException e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("/{**RelativeUri}")]
        public IActionResult Download(string RelativeUri)
        {
            try
            {
                return Waiters.AddReceiver(RelativeUri, HttpContext);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpOptions()]
        public IActionResult Options()
        {
            var Response = HttpContext.Response;
            Response.StatusCode = 200;
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            Response.Headers.Add("Access-Control-Allow-Methods", "GET, HEAD, POST, PUT, OPTIONS");
            Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type, Content-Disposition");
            Response.Headers.Add("Access-Control-Max-Age", "86400");
            return new EmptyResult();
        }
        protected IActionResult BadRequest(string Message)
        {
            var Content = this.Content(Message, $"text/plain; charset={Encoding.WebName}", Encoding);
            Content.StatusCode = 400;
            return Content;
        }
    }
}
