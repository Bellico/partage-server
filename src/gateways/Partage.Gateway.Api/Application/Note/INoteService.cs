using System.Threading.Tasks;

namespace Partage.Gateway.Api.Application
{
    public interface INoteService
    {
        Task<NoteModel> GetNoteAsync();
    }
}
