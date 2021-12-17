using CustomMediator.Library.Interfaces;

namespace CustomMediator.Api.Query
{
    public class GetUserByIdQuery : IRequest<UserViewModel>
    {
        public int Id { get; init; }

        public GetUserByIdQuery(int id)
        {
            Id = id;
        }
    }
}
