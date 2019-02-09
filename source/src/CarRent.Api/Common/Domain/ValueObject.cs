namespace CarRent.Api.Common.Domain
{
  public abstract class ValueObject<TValueObject>
    where TValueObject : ValueObject<TValueObject>
  {
    public override bool Equals(object obj)
    {
      var valueObject = obj as TValueObject;
      if (ReferenceEquals(valueObject, null))
      {
        return false;
      }

      var properties = GetType().GetProperties();
      var isEqual = true;
      foreach (var property in properties)
      {
        var valueLeft = property.GetValue(this);
        var valueRight = property.GetValue(obj);
        isEqual = isEqual & valueLeft.Equals(valueRight);
      }

      return isEqual;
    }

    public override int GetHashCode()
    {
      var properties = GetType().GetProperties();
      var hashCode = 0;
      foreach (var property in properties)
      {
        var valueLeft = property.GetValue(this);
        hashCode ^= valueLeft.GetHashCode();
      }

      return hashCode;
    }

    public static bool operator ==(ValueObject<TValueObject> a, ValueObject<TValueObject> b)
    {
      if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
      {
        return true;
      }

      if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
      {
        return false;
      }

      return a.Equals(b);
    }

    public static bool operator !=(ValueObject<TValueObject> a, ValueObject<TValueObject> b)
    {
      return !(a == b);
    }

  }
}