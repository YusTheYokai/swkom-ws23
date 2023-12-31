using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Rest.Logic.Service;
using Rest.Model;

namespace Rest.Web.Controller;

[ApiController]
public class TagsController : ControllerBase
{
    private readonly IDocTagService _service;

    // /////////////////////////////////////////////////////////////////////////
    // Init
    // /////////////////////////////////////////////////////////////////////////

    public TagsController(IDocTagService service)
    {
        _service = service;
    }

    // /////////////////////////////////////////////////////////////////////////
    // Methods
    // /////////////////////////////////////////////////////////////////////////

    [HttpPost]
    [Route("/api/tags")]
    [Consumes("application/json", "text/json", "application/*+json")]
    public virtual IActionResult CreateTag([FromBody] DocTag docTag)
    {
        var newDocTag = _service.Add(docTag);
        return Created("/api/tags/" + newDocTag.Id, newDocTag);
    }

    [HttpDelete]
    [Route("/api/tags/{id}")]
    public virtual IActionResult DeleteTag([FromRoute(Name = "id")][Required] int id)
    {
        _service.Remove(id);
        return NoContent();
    }

    [HttpGet]
    [Route("/api/tags")]
    public virtual IActionResult GetTags()
    {
        return Ok(_service.GetAll());
    }

    [HttpPut]
    [Route("/api/tags/{id}")]
    [Consumes("application/json", "text/json", "application/*+json")]
    public virtual IActionResult UpdateTag([FromRoute(Name = "id")][Required] int id, [FromBody] DocTag docTag)
    {
        docTag.Id = id;
        return Ok(_service.Update(docTag));
    }
}
