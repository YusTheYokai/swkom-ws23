using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Rest.Logic.Service;
using Rest.Model;

namespace Rest.Web.Controller
{
    [ApiController]
    [Route("/api/documents")]
    public class DocumentsController : ControllerBase
    {
        private readonly IDocumentService _service;

        public DocumentsController(IDocumentService service)
        {
            _service = service;
        }

        // /////////////////////////////////////////////////////////////////////////
        // Methods
        // /////////////////////////////////////////////////////////////////////////

        [HttpDelete]
        [Route("/{id}")]
        public virtual IActionResult DeleteDocument([FromRoute(Name = "id")][Required] int id)
        {
            _service.Remove(id);
            return NoContent();
        }

        [HttpGet]
        [Route("/{id}/download")]
        public virtual IActionResult DownloadDocument([FromRoute(Name = "id")][Required] int id, [FromQuery(Name = "original")] bool? original)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("/{id}/metadata")]
        public virtual IActionResult GetDocumentMetadata([FromRoute(Name = "id")][Required] int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("/{id}/preview")]
        public virtual IActionResult GetDocumentPreview([FromRoute(Name = "id")][Required] int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("/{id}/thumb")]
        public virtual IActionResult GetDocumentThumb([FromRoute(Name = "id")][Required] int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public virtual IActionResult GetDocuments(/*[FromQuery(Name = "Page")] int? page, [FromQuery(Name = "page_size")] int? pageSize, [FromQuery(Name = "query")] string query, [FromQuery(Name = "ordering")] string ordering, [FromQuery(Name = "tags__id__all")] List<int> tagsIdAll, [FromQuery(Name = "document_type__id")] int? documentTypeId, [FromQuery(Name = "correspondent__id")] int? correspondentId, [FromQuery(Name = "truncate_content")] bool? truncateContent*/)
        {
            return Ok(_service.GetAll());
        }

        [HttpPut]
        [Route("/{id}")]
        [Consumes("application/json", "text/json", "application/*+json")]
        public virtual IActionResult UpdateDocument([FromRoute(Name = "id")][Required] int id, [FromBody] Document document)
        {
            document.Id = id;
            return Ok(_service.Update(document));
        }

        [HttpPost]
        [Route("/post_document")]
        [Consumes("multipart/form-data")]
        public virtual IActionResult UploadDocument([FromForm(Name = "title")] string title, [FromForm(Name = "created")] DateTime? created, [FromForm(Name = "document_type")] int? documentType, [FromForm(Name = "tags")] List<int> tags, [FromForm(Name = "correspondent")] int? correspondent, [FromForm(Name = "document")] List<Stream> document)
        {
            throw new NotImplementedException();
        }
    }
}