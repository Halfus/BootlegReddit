using Entities.Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PostsController : ControllerBase
{
    private IPostHome postHome;

    public PostsController(IPostHome postHome)
    {
        this.postHome = postHome;
    }
    
    [HttpGet]
    public async Task<ActionResult<ICollection<Post>>> GetAll()
    {
        try
        {
            ICollection<Post> posts = await postHome.GetAsync();
            return Ok(posts);
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
    
    [HttpPost]
    public async Task<ActionResult<Post>> AddPost([FromBody] Post post)
    {
        try
        {
            Post added = await postHome.AddAsync(post);
            return Created($"/posts/{added.Id}", added);
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
    
    [HttpGet]
    [Route("{id:int}")]
    public async Task<ActionResult<Post>> GetPostById([FromRoute] int id)
    {
        try
        {
            Post post = await postHome.GetByIdAsync(id);
            return post;
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }

    [HttpDelete]
    [Route("{id:int}")]
    public async Task<ActionResult> DeletePostById([FromRoute] int id)
    {
        try
        {
            await postHome.DeleteAsync(id);
            return Ok();
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        } 
    }

    [HttpPatch]
    public async Task<ActionResult> Update([FromBody] Post post)
    {
        try
        {
            await postHome.UpdateAsync(post);
            return Ok();
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }  
    }
}