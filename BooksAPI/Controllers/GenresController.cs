using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BooksAPI.BusinessLogic.DTOs.Genre;
using BooksAPI.BusinessLogic.Responses;
using BooksAPI.BusinessLogic.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IGenreService _service;
        public GenresController(IGenreService service)
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
        public async Task<ResultResponse> Add([FromBody]GenreDto dto)
        {
            return await _service.CreateAsync(dto);
        }

        [HttpPut("{id}")]
        public async Task<ResultResponse> Update(int id, [FromBody]GenreDto dto)
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