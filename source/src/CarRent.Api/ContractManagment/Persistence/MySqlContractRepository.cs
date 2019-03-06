// ************************************************************************************
// FileName: MySqlContractRepository.cs
// Author: 
// Created on: 06.03.2019
// Last modified on: 06.03.2019
// Copy Right: JELA Rocks
// ------------------------------------------------------------------------------------
// Description: 
// ------------------------------------------------------------------------------------
// ************************************************************************************
namespace CarRent.Api.ContractManagment.Persistence
{
  using System.Collections.Generic;
  using Common.Persistence;
  using Domain;

  public class MySqlContractRepository : MySqlBaseRespository, IContractRepository
  {
    public MySqlContractRepository(string connectionString) : base(connectionString)
    {

    }

    public IReadOnlyList<Contract> GetAll()
    {
      IReadOnlyList<Contract> allContracts = new List<Contract>();

      return allContracts;
    }
  }
}