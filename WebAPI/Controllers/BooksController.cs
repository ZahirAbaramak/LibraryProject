using Bussines.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class BooksController : ControllerBase
    {
        IBooksService _bookService;
        public BooksController(IBooksService booksService)
        {
            _bookService= booksService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _bookService.GetAll();
            if(result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }

        }
        [HttpPost("Add")]
        public IActionResult Add(Books books)
        {
            var result = _bookService.Add(books);
            if(result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpGet("getallbookdetails")]
        public IActionResult GetAllBookDetails()
        {
            var result =_bookService.GetAllDetails();
             if(result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _bookService.GetById(id);
            if(result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpPost("delete")]
        public IActionResult Delete(Books books)
        {
            var result = _bookService.Delete(books);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpPost("update")]
        public IActionResult Update(Books books)
        {
            var result = _bookService.Update(books);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
            
        }
        [HttpGet("getbysum")]
        public IActionResult GetBySum(decimal min , decimal max)
        {
            var result = _bookService.GetBySum(min,max);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }


    }
}
