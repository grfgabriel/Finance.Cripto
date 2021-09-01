// using System.Threading;
// using System.Threading.Tasks;
// using MediatR;

// namespace Service.Mediator
// {
//     public class Mediator : IMediator
//     {
//         public Mediator(ServiceFactory serviceFactory)
//         {
//             serviceFactory.
//         }
//         public Task Publish(object notification, CancellationToken cancellationToken = default)
//         {
//             throw new System.NotImplementedException();
//         }

//         public Task Publish<TNotification>(TNotification notification, CancellationToken cancellationToken = default) where TNotification : INotification
//         {
//             throw new System.NotImplementedException();
//         }

//         public Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default)
//         {
//             throw new System.NotImplementedException();
//         }

//         public Task<object> Send(object request, CancellationToken cancellationToken = default)
//         {
//             throw new System.NotImplementedException();
//         }
//     }
// }