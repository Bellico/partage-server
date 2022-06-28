using GraphQL.Types;

namespace Partage.Gateway.Api.GraphQL
{
    public class NoteGraphType : ObjectGraphType<NoteModel>
    {
        public NoteGraphType()
        {
            Name = "Note";
            Description = "A note";
            Field(x => x.Id).Description("The Id");
            Field(x => x.Title).Description("The Title");
            Field(x => x.Content).Description("The Content");
        }
    }
}
