using Domain.Entities;
using MediatR;

namespace Application.Notifications
{
    internal record ExampleUpdatedNotification(Example Example) : INotification;

    internal class ExampleUpdatedNotificationHandler : INotificationHandler<ExampleUpdatedNotification>
    {
        public Task Handle(ExampleUpdatedNotification notification, CancellationToken cancellationToken)
        {
            // Handle the notification (e.g., log it, send an email, add data to cache, add change notification change to message bus)
            throw new NotImplementedException();
        }
    }
}
