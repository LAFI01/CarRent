﻿// ************************************************************************************
// FileName: IHandle.cs
// Author: 
// Created on: 04.02.2019
// Last modified on: 10.02.2019
// Copy Right: JELA Rocks
// ------------------------------------------------------------------------------------
// Description: 
// ------------------------------------------------------------------------------------
// ************************************************************************************
namespace CarRent.Api.Common.Domain
{
  public interface IHandle<T>
    where T : IDomainEvent
  {
    void Handle(T domainEvent);
  }
}