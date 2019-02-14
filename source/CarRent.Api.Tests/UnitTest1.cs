// ************************************************************************************
// FileName: UnitTest1.cs
// Author: 
// Created on: 04.02.2019
// Last modified on: 10.02.2019
// Copy Right: JELA Rocks
// ------------------------------------------------------------------------------------
// Description: 
// ------------------------------------------------------------------------------------
// ************************************************************************************
namespace CarRent.Api.Tests
{
  using System;
  using Common.Domain;
  using Microsoft.VisualStudio.TestTools.UnitTesting;

  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {
      Money m1 = new Money(10, "CHF");
      Money m2 = new Money(10, "CHF");

      Assert.IsTrue(m1 == m2);
    }
  }

  public class Money : ValueObject<Money>
  {
    public Money(decimal amount, string currency)
    {
      Amount = amount;
      Currency = currency;
    }

    public decimal Amount { get; set; }

    public string Currency { get; set; }
  }

  public class MyEvent : IDomainEvent
  {
  }

  public class MyEventHandler : IHandle<MyEvent>, IHandle<MyEvent2>
  {
    public void Handle(MyEvent domainEvent)
    {
      throw new NotImplementedException();
    }

    public void Handle(MyEvent2 domainEvent)
    {
      throw new NotImplementedException();
    }
  }

  public class MyEvent2 : IDomainEvent
  {
  }
}