// ************************************************************************************
// FileName: InMemoryRepository.cs
// Author: 
// Created on: 09.02.2019
// Last modified on: 10.02.2019
// Copy Right: JELA Rocks
// ------------------------------------------------------------------------------------
// Description: 
// ------------------------------------------------------------------------------------
// ************************************************************************************
namespace CarRent.Api.Common.Persistence
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using Domain;

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