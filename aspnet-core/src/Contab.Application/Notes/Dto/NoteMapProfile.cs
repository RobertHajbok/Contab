using AutoMapper;

namespace Contab.Notes.Dto
{
    public class NoteMapProfile : Profile
    {
        public NoteMapProfile()
        {
            CreateMap<Note, NoteDto>().ReverseMap();
        }
    }
}
