using MediatR;

namespace Partage.Gateway.Api.Application
{
    public class GetNoteCommand : IRequest<NoteModel>
    {
        public string? Title { get; set; }
    }
}
