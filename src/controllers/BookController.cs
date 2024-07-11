using HomeLibraryCG.src.data;
using HomeLibraryCG.src.models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HomeLibraryCG.src.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public BookController(DataContext dataContext) { 
            _dataContext = dataContext;
        }
        [HttpGet]
        public async Task<ActionResult<List<Book>>> Get()
        {
            try
            {
                var book = await _dataContext.Books.FirstAsync();
                return Ok(book);
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }
    }
}
