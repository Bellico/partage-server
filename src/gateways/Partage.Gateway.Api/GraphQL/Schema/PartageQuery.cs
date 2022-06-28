using GraphQL.Types;
using MediatR;
using Partage.Gateway.Api.Application;

namespace Partage.Gateway.Api.GraphQL
{
    public class PartageQuery : ObjectGraphType
    {
        public PartageQuery(IMediator mediator)
        {
            Field<NoteGraphType>("GetNote", "Get a note",
                resolve: context => mediator.Send(new GetNoteCommand()));

            Field<LinkGraphType>("GetLink", "Get a link",
                resolve: context => mediator.Send(new GetLinkCommand()));
        }
    }
}
