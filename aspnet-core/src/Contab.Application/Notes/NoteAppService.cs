using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Contab.Authorization;
using Contab.Notes.Dto;

namespace Contab.Notes
{
    [AbpAuthorize(PermissionNames.Pages_Notes)]
    public class NoteAppService : AsyncCrudAppService<Note, NoteDto, int, PagedNoteResultRequestDto, CreateNoteDto, NoteDto>, INoteAppService
    {
        public NoteAppService(IRepository<Note> repository) : base(repository)
        {
        }
    }
}
