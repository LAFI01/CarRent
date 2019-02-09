using System;
using System.Collections.Generic;
using System.Linq;
using CarRent.Api.Common.Domain;

namespace CarRent.Api.Common.Persistence
{
  public abstract class InMemoryRepository<TAggregate> : IRepository<TAggregate>
    where TAggregate : AggregateRoot
  {
    private readonly List<TAggregate> _aggregates;

    protected InMemoryRepository()
    {
      _aggregates = new List<TAggregate>();
    }

    public void Add(TAggregate aggregate)
    {
      _aggregates.Add(aggregate);
    }

    public IReadOnlyList<TAggregate> GetAll()
    {
      return _aggregates;
    }

    public TAggregate GetById(Guid id)
    {
      return _aggregates.Where(x => x.Id == id).Single();
    }

    public void Remove(TAggregate aggregate)
    {
      _aggregates.Remove(aggregate);
    }
  }
}