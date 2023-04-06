using AutoMapper;
using Notes.Application.Common.Mappings;
using Notes.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Application.Entities.Notes.Queries.GetListNote
{
    public class NoteListDto : IMapWith<Note>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public void Mapping(Profile profile) {
            profile.CreateMap<Note, NoteListDto>()
                .ForMember(dto => dto.Id, option => option.MapFrom(note => note.Id))
                .ForMember(dto => dto.Title, option => option.MapFrom(note => note.Title));
        }
    }
}
