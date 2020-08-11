using GraphQL.Types;

namespace Partage.Gateway.Api.GraphQL
{
    public class PartageMutation : ObjectGraphType
    {
        public PartageMutation()
        {
            Field<NoteGraphType>("notemutation", "toto", resolve: context => new NoteModel { Id = 1, Content = "content" });
        }
    }
}
