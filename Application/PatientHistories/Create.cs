using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.PatientHistories
{
  public class Create
  {
    public class Command : IRequest
    {
      public PatientHistory PatientHistory { get; set; }
    }

    public class Handler : IRequestHandler<Command>
    {
      private readonly DataContext context;
      public Handler(DataContext context)
      {
        this.context = context;
      }

      public async Task<Unit> Handle(Command command, CancellationToken cancellationToken)
      {
        context.PatientHistories.Add(command.PatientHistory);
        await context.SaveChangesAsync();
        return Unit.Value;
      }
    }
  }
}