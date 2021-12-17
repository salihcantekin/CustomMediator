using CustomMediator.Library.Interfaces;
using System.Threading.Tasks;

namespace CustomMediator.Api.Command
{
    public class UpdateNameCommandHandler : IRequestHandler<UpdateNameCommand, int>
    {
        public Task<int> Handle(UpdateNameCommand request)
        {
            // update on db

            return Task.FromResult(1);
        }
    }
}
