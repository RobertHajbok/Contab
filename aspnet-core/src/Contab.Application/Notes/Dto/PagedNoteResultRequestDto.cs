using Abp.Application.Services.Dto;

namespace Contab.Notes.Dto
{
    public class PagedNoteResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}
