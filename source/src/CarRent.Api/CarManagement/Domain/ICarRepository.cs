// ************************************************************************************
// FileName: ICarRepository.cs
// Author: 
// Created on: 24.01.2019
// Last modified on: 10.02.2019
// Copy Right: JELA Rocks
// ------------------------------------------------------------------------------------
// Description: 
// ------------------------------------------------------------------------------------
// ************************************************************************************
namespace CarRent.Api.CarManagement.Domain
{
  using System.Collections.Generic;

  public interface ICarRepository
  {
    IReadOnlyList<Car> GetAll();
  }
}