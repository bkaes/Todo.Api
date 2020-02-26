using Todo.Api.Models;

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Todo.Api.Services;
using System;

namespace Todo.Api.Controllers 
{
    [ApiController]
    [Route("api/todos")]
    public class TodoItemsController : ControllerBase
    {
    private ITodoRepository respository;
    public TodoItemsController(ITodoRepository todoRepository)
    {
     respository = todoRepository ??
        throw new ArgumentNullException(nameof(todoRepository));   
    }
     [HttpGet]
     public IActionResult GetTodos()
     {
         var result = respository.GetAllTodoItems();
             if (result == null)
             {
                 return NotFound();
             }  
         return Ok(result);
        }   
}
}