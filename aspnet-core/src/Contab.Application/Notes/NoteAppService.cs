using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Abp.Runtime.Session;
using Contab.Authorization;
using Contab.Notes.Dto;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Contab.Notes
{
    [AbpAuthorize(PermissionNames.Pages_Notes)]
    public class NoteAppService : AsyncCrudAppService<Note, NoteDto, int, PagedNoteResultRequestDto, CreateNoteDto, NoteDto>, INoteAppService
    {
        private readonly IRepository<Note> _noteRepository;
        private readonly IAbpSession _session;

        public NoteAppService(IRepository<Note> noteRepository, IAbpSession session) : base(noteRepository)
        {
            _noteRepository = noteRepository;
            _session = session;
        }

        public override async Task<NoteDto> CreateAsync(CreateNoteDto input)
        {
            var note = new Note
            {
                Title = input.Title,
                Text = input.Text,
                UserId = _session.GetUserId()
            };
            await _noteRepository.InsertAsync(note);
            return ObjectMapper.Map<NoteDto>(note);
        }

        public override async Task<PagedResultDto<NoteDto>> GetAllAsync(PagedNoteResultRequestDto input)
        {
            var query = _noteRepository.GetAll().Where(x => x.UserId == _session.GetUserId()).WhereIf(!string.IsNullOrWhiteSpace(input.Keyword), x =>
                x.Title.Contains(input.Keyword) || x.Text.Contains(input.Keyword));

            var notes = await query.Skip(input.SkipCount).Take(input.MaxResultCount).Select(x => ObjectMapper.Map<NoteDto>(x)).ToListAsync();
            return new PagedResultDto<NoteDto>(await query.CountAsync(), notes);
        }

        public override async Task<NoteDto> UpdateAsync(NoteDto input)
        {
            var note = await _noteRepository.GetAsync(input.Id);
            note.Title = input.Title;
            note.Text = input.Text;
            await _noteRepository.UpdateAsync(note);
            return ObjectMapper.Map<NoteDto>(note);
        }
    }
}
