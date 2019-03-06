// ************************************************************************************
// FileName: IContractRepository.cs
// Author: 
// Created on: 06.03.2019
// Last modified on: 06.03.2019
// Copy Right: JELA Rocks
// ------------------------------------------------------------------------------------
// Description: 
// ------------------------------------------------------------------------------------
// ************************************************************************************
namespace CarRent.Api.ContractManagment.Domain
{
  using System.Collections.Generic;

  public interface IContractRepository
  {
    IReadOnlyList<Contract> GetAll();
  }
}