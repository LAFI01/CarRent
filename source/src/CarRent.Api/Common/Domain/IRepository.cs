using System;
using System.Collections.Generic;

namespace CarRent.Api.Common.Domain
{
  public interface IRepository<TAggregate>
    where TAggregate : AggregateRoot
  {
    TAggregate GetById(Guid id);

    IReadOnlyList<TAggregate> GetAll();

    void Add(TAggregate aggregate);

    void Remove(TAggregate aggregate);
  }
}