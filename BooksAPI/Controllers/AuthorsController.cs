using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BooksAPI.BusinessLogic.DTOs.Author;
using BooksAPI.BusinessLogic.Responses;
using BooksAPI.BusinessLogic.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorService _service;
        public AuthorsController(IAuthorService service)
        {
            _service = service;
        }
        public ResultResponse Get()
        {
            return _service.GetAll();
        }

        [HttpGet("{id}")]
        public ResultResponse GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public async Task<ResultResponse> Add([FromBody]AuthorDto dto)
        {
            return await _service.CreateAsync(dto);
        }

        [HttpPut("{id}")]
        public async Task<ResultResponse> Update(int id, [FromBody]AuthorDto dto)
        {
            return await _service.Update(dto);
        }

        [HttpDelete("{id}")]
        public ResultResponse Delete(int id)
        {
            return _service.Delete(id);
        }

    }
}