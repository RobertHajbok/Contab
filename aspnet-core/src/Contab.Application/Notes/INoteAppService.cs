using Abp.Application.Services;
using Contab.Notes.Dto;

namespace Contab.Notes
{
    public interface INoteAppService : IAsyncCrudAppService<NoteDto, int, PagedNoteResultRequestDto, CreateNoteDto, NoteDto>
    {
    }
}
