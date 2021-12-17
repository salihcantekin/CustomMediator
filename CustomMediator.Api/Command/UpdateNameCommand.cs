using CustomMediator.Library.Interfaces;
using System;

namespace CustomMediator.Api.Command
{
    public class UpdateNameCommand : IRequest<int>
    {
        public string FirstName { get; init; }

        public UpdateNameCommand(string firstName)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
        }
    }
}
