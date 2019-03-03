// ************************************************************************************
// FileName: MySqlBaseRespository.cs
// Author: 
// Created on: 03.03.2019
// Last modified on: 03.03.2019
// Copy Right: JELA Rocks
// ------------------------------------------------------------------------------------
// Description: 
// ------------------------------------------------------------------------------------
// ************************************************************************************
namespace CarRent.Api.Common.Persistence
{
  using System;
  using System.Data;
  using MySql.Data.MySqlClient;

  public class MySqlBaseRespository
  {
    protected MySqlBaseRespository(string connectionString)
    {
      MySqlConnection = new MySqlConnection(connectionString);
    }

    private void ExecuteStatemante(string statement)
    {
      try
      {
        MySqlConnection.Open();
        IDbCommand command = CreateCommand(MySqlConnection, CommandType.Text, statement);
        command.ExecuteNonQuery();
      }
      finally
      {
        MySqlConnection.Close();
      }
    }

    protected void DeleteRow(string tablename, string rowName, int value)
    {
        var statement = "DELETE FROM " + tablename + " WHERE " + rowName + " = " + value + ";";
        ExecuteStatemante(statement);
    }

    protected void UpdateRow(string tablename, string rowName, object newValue, int id, string idName)
    {
      var statement = "UPDATE " + tablename + " SET " + rowName + " = " + newValue + " WHERE " + idName + " = " + id + ";";
      ExecuteStatemante(statement);
    }

    protected DateTime ConvertToDateTime(object obj)
    {
      DateTime date;
      DateTime.TryParse(obj.ToString(), out date);

      return date;
    }

    protected IDbConnection MySqlConnection { get; set; }

    protected bool ConvertToBool(object obj)
    {
      var i = false;
      if (obj is bool)
      {
        i = (bool) obj;
      }

      return i;
    }

    protected decimal ConvertToDecimal(object obj)
    {
      decimal i = 0;
      if (obj is decimal @decimal)
      {
        i = @decimal;
      }

      return i;
    }

    protected int ConvertToInt(object obj)
    {
      var i = 0;
      if (obj is int)
      {
        i = (int) obj;
      }

      return i;
    }

    protected IDbCommand CreateCommand(IDbConnection myConnection, CommandType commandType, string coomandText)
    {
      IDbCommand command = MySqlConnection.CreateCommand();
      command.CommandType = commandType;
      command.CommandText = coomandText;

      return command;
    }
  }
}