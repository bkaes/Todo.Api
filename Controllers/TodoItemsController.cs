using Todo.Api.Models;

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Todo.Api.Controllers 
{
    [ApiController]
    [Route("api.todos")]
    public class TodoItemsController : ControllerBase
    {
     [HttpGet]
     public IActionResult GetTodos()
     {
         var result = new List<TodoItem>(){
             new TodoItem{ Id = 1, Action="Thing one.", IsDone=true},
             new TodoItem{ Id = 2, Action="Thing two.", IsDone=false},
         };
         return Ok(result);
     }   
    }
}