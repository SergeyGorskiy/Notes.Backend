using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Notes.Application.Notes.Queries.GetNoteList;

namespace Notes.WebApi.Controllers
{
    public class NoteController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<NoteListVm>> GetAll()
        {
            var query = new GetNoteListQuery
            {
                UserId = UserId
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }
    }
}
