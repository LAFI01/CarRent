using System.Collections.Generic;

namespace CarRent.Api.Common.Domain
{
  public abstract class AggregateRoot : Entity
  {
    private readonly List<IDomainEvent> _domainEvents = new List<IDomainEvent>();

    public IReadOnlyList<IDomainEvent> DomainEvents => _domainEvents;

    protected void AddDomainEvent(IDomainEvent newEvent)
    {
      _domainEvents.Add(newEvent);
    }

    internal void ClearEvents()
    {
      _domainEvents.Clear();
    }
  }

}