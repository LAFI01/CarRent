using System;

namespace CarRent.Api.Common.Domain
{
  public abstract class Entity
  {
    //mit this ruft man den anderen Konstuktor auf - so kann man zum Testen eine GUID verwedenen, die man kennt

    protected Entity()
      : this(Guid.NewGuid())
    {
    }

    protected internal Entity(Guid initial)
    {
      Id = initial;
    }

    public Guid Id { get; }

    public override bool Equals(object obj)
    {
      var other = obj as Entity;

      if (ReferenceEquals(other, null))
      {
        return false;
      }

      if (ReferenceEquals(this, other))
      {
        return true;
      }

      if (Id == Guid.Empty || other.Id == Guid.Empty)
      {
        return false;
      }

      return Id == other.Id;
    }

    public override int GetHashCode()
    {
      return Id.GetHashCode();
    }
  }
}