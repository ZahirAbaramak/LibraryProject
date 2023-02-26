﻿using Bussines.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("getall")]
        
        public IActionResult GetAll()
        {
            var result = _categoryService.GetAll();
           if( result.Success)
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
