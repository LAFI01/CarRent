// ************************************************************************************
// FileName: ContractController.cs
// Author: 
// Created on: 06.03.2019
// Last modified on: 06.03.2019
// Copy Right: JELA Rocks
// ------------------------------------------------------------------------------------
// Description: 
// ------------------------------------------------------------------------------------
// ************************************************************************************
namespace CarRent.Api.ContractManagment.Controller
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using Domain;
  using Microsoft.AspNetCore.Mvc;

  [Route("api/[controller]")]
  [ApiController]
  public class ContractController : ControllerBase
  {
    public ContractController(IContractService contractService)
    {
      ContractService = contractService;
    }

    private IContractService ContractService { get; }

    // DELETE: api/ApiWithActions/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }

    // GET: api/Contract
    [HttpGet]
    public IEnumerable<ContractDto> Get()
    {
      var contracs = ContractService.GetAll();

      return contracs.Select(c => new ContractDto
      {

      });
    }

    // GET: api/Contract/5
    [HttpGet]
    public string Get(int id)
    {
      throw  new NotImplementedException();
    }

    // POST: api/Contract
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT: api/Contract/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }
  }
}