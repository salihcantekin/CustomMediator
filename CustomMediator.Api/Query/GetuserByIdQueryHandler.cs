using CustomMediator.Library.Interfaces;
using System.Threading.Tasks;

namespace CustomMediator.Api.Query
{
    public class GetuserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserViewModel>
    {
        public Task<UserViewModel> Handle(GetUserByIdQuery request)
        {
            // get data from db

            return Task.FromResult(new UserViewModel()
            {
                FirstName = "Salih",
                LastName = "Cantekin"
            });
        }
    }
}
