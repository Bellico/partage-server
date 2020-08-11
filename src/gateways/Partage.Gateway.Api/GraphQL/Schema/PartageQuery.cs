using GraphQL.Types;

namespace Partage.Gateway.Api.GraphQL
{
    public class PartageQuery : ObjectGraphType
    {
        public PartageQuery()
        {
            Field<NoteGraphType>("note", "toto", resolve: context => new NoteModel { Id = 1, Content = "content" });
        }
    }
}
