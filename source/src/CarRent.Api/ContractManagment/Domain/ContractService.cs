// ************************************************************************************
// FileName: ContractService.cs
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

  public class ContractService : IContractService
  {
    public ContractService(IContractRepository contractRepository)
    {
      ContractRepository = contractRepository;
    }

    private IContractRepository ContractRepository { get; }

    public IReadOnlyList<Contract> GetAll()
    {
      return ContractRepository.GetAll();
    }
  }
}