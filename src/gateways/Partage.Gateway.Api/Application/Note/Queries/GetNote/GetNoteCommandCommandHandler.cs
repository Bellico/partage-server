
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Partage.Gateway.Api.Application
{
    public class GetNoteCommandCommandHandler : IRequestHandler<GetNoteCommand, NoteModel>
    {
        private readonly INoteService noteService;

        public GetNoteCommandCommandHandler(INoteService noteService)
        {
            this.noteService = noteService;
        }

        public async Task<NoteModel> Handle(GetNoteCommand request, CancellationToken cancellationToken)
        {
            return await noteService.GetNoteAsync();
        }
    }
}
