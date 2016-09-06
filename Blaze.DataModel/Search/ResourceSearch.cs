﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blaze.Common.Tools;
using Blaze.DataModel.DatabaseModel.Base;
using System.Linq.Expressions;
using System.Reflection;

namespace Blaze.DataModel.Search
{
  public class ResourceSearch<T> where T : ResourceIndexBase
  {
    private string CollectionPostfix = "List";
    private string DateIndexPostfix = "DateTimeOffset";

    public Expression<Func<T, bool>> StringPropertyEqualTo(string Property, string Value)
    {
      //(x => x.FhirId == "a99b5c95-b546-46ee-8992-19a7ca703d4a")
      var type = typeof(T);
      var ParameterReferance = Expression.Parameter(type, "x");
      var propertyReference = Expression.Property(ParameterReferance, Property);
      var constantReference = Expression.Constant(StringSupport.ToLowerAndRemoveDiacritics(Value.Trim()));
      var BinaryExpression = Expression.Equal(propertyReference, constantReference);
      return Expression.Lambda<Func<T, bool>>(BinaryExpression, new[] { ParameterReferance });
    }

    public Expression<Func<T, bool>> StringPropertyStartsWith(string Property, string Value)
    {
      //(x => x.FhirId.StartsWith("a99b5c95-b546-46ee-8992-19a7ca703d4a"))      
      MethodInfo MethodStartsWith = typeof(String).GetMethods().Where(m => m.Name == "StartsWith" && m.GetParameters().Length == 1).Single();

      var type = typeof(T);
      var ParameterReferance = Expression.Parameter(type, "x");
      var propertyReference = Expression.Property(ParameterReferance, Property);
      var constantReference = Expression.Constant(StringSupport.ToLowerAndRemoveDiacritics(Value.Trim()));
      var MethodStartsWithCall = Expression.Call(propertyReference, MethodStartsWith, constantReference);
      return Expression.Lambda<Func<T, bool>>(MethodStartsWithCall, ParameterReferance);
    }

    public Expression<Func<T, bool>> StringPropertyStartsOrEndsWith(string Property, string Value)
    {
      //(x => x.FhirId.StartsWith("a99b5c95-b546-46ee-8992-19a7ca703d4a"))      
      MethodInfo MethodStartsWith = typeof(String).GetMethods().Where(m => m.Name == "StartsWith" && m.GetParameters().Length == 1).Single();
      MethodInfo MethodEndsWith = typeof(String).GetMethods().Where(m => m.Name == "EndsWith" && m.GetParameters().Length == 1).Single();

      var type = typeof(T);
      var ParameterReferance = Expression.Parameter(type, "x");
      var propertyReference = Expression.Property(ParameterReferance, Property);
      var constantReference = Expression.Constant(StringSupport.ToLowerAndRemoveDiacritics(Value.Trim()));

      var MethodStartsWithCall = Expression.Call(propertyReference, MethodStartsWith, constantReference);
      var MethodEndsWithCall = Expression.Call(propertyReference, MethodEndsWith, constantReference);
      var OrExpression = Expression.OrElse(MethodStartsWithCall, MethodEndsWithCall);

      return Expression.Lambda<Func<T, bool>>(OrExpression, ParameterReferance);
    }

    public Expression<Func<T, bool>> StringPropertyContains(string Property, string Value)
    {
      //(x => x.FhirId.Contains("d3da-493a-b4f2"))      
      MethodInfo MethodContains = typeof(String).GetMethods().Where(m => m.Name == "Contains" && m.GetParameters().Length == 1).Single();

      var type = typeof(T);
      var ParameterReferance = Expression.Parameter(type, "x");
      var propertyReference = Expression.Property(ParameterReferance, Property);
      var constantReference = Expression.Constant(StringSupport.ToLowerAndRemoveDiacritics(Value.Trim()));
      var MethodContainsCall = Expression.Call(propertyReference, MethodContains, constantReference);
      return Expression.Lambda<Func<T, bool>>(MethodContainsCall, ParameterReferance);
    }

    public Expression<Func<T, bool>> StringCollectionAnyEqualTo(string Property, string Value)
    {
      //(x => x.family_List.Any(c => c.String.Equals("héllo UPPER")))
      var type = typeof(T);
      string DbPropertyName = Property + "_" + CollectionPostfix;
      //Inner
      MethodInfo MethodEquals = typeof(String).GetMethods().Where(m => m.Name == "Equals" && m.GetParameters().Length == 1 && m.GetParameters()[0].ParameterType == typeof(String)).Single();

      ParameterExpression InnerParameter = Expression.Parameter(typeof(StringIndex), "c");
      MemberExpression InnerProperty = Expression.Property(InnerParameter, "String");
      ConstantExpression InnerValue = Expression.Constant(StringSupport.ToLowerAndRemoveDiacritics(Value.Trim()));
      //ConstantExpression InnerStringComparison = Expression.Constant(StringComparison.Ordinal);
      MethodCallExpression MethodEqualsCall = Expression.Call(InnerProperty, MethodEquals, InnerValue);
      Expression<Func<StringIndex, bool>> InnerFunction = Expression.Lambda<Func<StringIndex, bool>>(MethodEqualsCall, InnerParameter);

      //Outer Any
      MethodInfo MethodAny = typeof(Enumerable).GetMethods().Where(m => m.Name == "Any" && m.GetParameters().Length == 2).Single().MakeGenericMethod(typeof(StringIndex));

      ParameterExpression PatientParameter = Expression.Parameter(typeof(T), "x");
      MemberExpression CollectionProperty = Expression.Property(PatientParameter, typeof(T).GetProperty(DbPropertyName));
      MethodCallExpression MethodAnyCall = Expression.Call(MethodAny, CollectionProperty, InnerFunction);
      return Expression.Lambda<Func<T, bool>>(MethodAnyCall, PatientParameter);
    }

    public Expression<Func<T, bool>> StringCollectionAnyStartsWith(string Property, string Value)
    {
      //(x => x.family_List.Any(c => c.String.StartsWith("Mill")));
      var type = typeof(T);
      string DbPropertyName = Property + "_" + CollectionPostfix;

      //Inner
      MethodInfo MethodStartsWith = typeof(String).GetMethods().Where(m => m.Name == "StartsWith" && m.GetParameters().Length == 1).Single();

      ParameterExpression InnerParameter = Expression.Parameter(typeof(StringIndex), "c");
      MemberExpression InnerProperty = Expression.Property(InnerParameter, "String");
      ConstantExpression InnerValue = Expression.Constant(StringSupport.ToLowerAndRemoveDiacritics(Value.Trim()));
      MethodCallExpression MethodStartsWithCall = Expression.Call(InnerProperty, MethodStartsWith, InnerValue);
      Expression<Func<StringIndex, bool>> InnerFunction = Expression.Lambda<Func<StringIndex, bool>>(MethodStartsWithCall, InnerParameter);

      //Outer Any
      MethodInfo MethodAny = typeof(Enumerable).GetMethods().Where(m => m.Name == "Any" && m.GetParameters().Length == 2).Single().MakeGenericMethod(typeof(StringIndex));

      ParameterExpression PatientParameter = Expression.Parameter(typeof(T), "x");
      MemberExpression CollectionProperty = Expression.Property(PatientParameter, typeof(T).GetProperty(DbPropertyName));
      MethodCallExpression MethodAnyCall = Expression.Call(MethodAny, CollectionProperty, InnerFunction);
      return Expression.Lambda<Func<T, bool>>(MethodAnyCall, PatientParameter);
    }

    public Expression<Func<T, bool>> StringCollectionAnyStartsOrEndsWith(string Property, string Value)
    {
      //(x => x.family_List.Any(c => c.String.StartsWith("Mill")));
      var type = typeof(T);
      string DbPropertyName = Property + "_" + CollectionPostfix;

      //Inner
      MethodInfo MethodStartsWith = typeof(String).GetMethods().Where(m => m.Name == "StartsWith" && m.GetParameters().Length == 1).Single();
      MethodInfo MethodEndsWith = typeof(String).GetMethods().Where(m => m.Name == "EndsWith" && m.GetParameters().Length == 1).Single();

      ParameterExpression InnerParameter = Expression.Parameter(typeof(StringIndex), "c");
      MemberExpression InnerProperty = Expression.Property(InnerParameter, "String");
      ConstantExpression InnerValue = Expression.Constant(StringSupport.ToLowerAndRemoveDiacritics(Value.Trim()));

      MethodCallExpression MethodStartsWithCall = Expression.Call(InnerProperty, MethodStartsWith, InnerValue);
      MethodCallExpression MethodEndsWithCall = Expression.Call(InnerProperty, MethodEndsWith, InnerValue);

      var OrExpression = Expression.OrElse(MethodStartsWithCall, MethodEndsWithCall);
      Expression<Func<StringIndex, bool>> InnerFunction = Expression.Lambda<Func<StringIndex, bool>>(OrExpression, InnerParameter);

      //Outer Any
      MethodInfo MethodAny = typeof(Enumerable).GetMethods().Where(m => m.Name == "Any" && m.GetParameters().Length == 2).Single().MakeGenericMethod(typeof(StringIndex));

      ParameterExpression PatientParameter = Expression.Parameter(typeof(T), "x");
      MemberExpression CollectionProperty = Expression.Property(PatientParameter, typeof(T).GetProperty(DbPropertyName));
      MethodCallExpression MethodAnyCall = Expression.Call(MethodAny, CollectionProperty, InnerFunction);
      return Expression.Lambda<Func<T, bool>>(MethodAnyCall, PatientParameter);
    }

    public Expression<Func<T, bool>> StringCollectionAnyContains(string Property, string Value)
    {
      //(x => x.family_List.Any(c => c.String.Contains("Mill")));
      var type = typeof(T);
      string DbPropertyName = Property + "_" + CollectionPostfix;

      //Inner
      MethodInfo MethodContains = typeof(String).GetMethods().Where(m => m.Name == "Contains" && m.GetParameters().Length == 1).Single();

      ParameterExpression InnerParameter = Expression.Parameter(typeof(StringIndex), "c");
      MemberExpression InnerProperty = Expression.Property(InnerParameter, "String");
      ConstantExpression InnerValue = Expression.Constant(StringSupport.ToLowerAndRemoveDiacritics(Value.Trim()));
      MethodCallExpression MethodContainsCall = Expression.Call(InnerProperty, MethodContains, InnerValue);
      Expression<Func<StringIndex, bool>> InnerFunction = Expression.Lambda<Func<StringIndex, bool>>(MethodContainsCall, InnerParameter);

      //Outer Any
      MethodInfo MethodAny = typeof(Enumerable).GetMethods().Where(m => m.Name == "Any" && m.GetParameters().Length == 2).Single().MakeGenericMethod(typeof(StringIndex));

      ParameterExpression PatientParameter = Expression.Parameter(typeof(T), "x");
      MemberExpression CollectionProperty = Expression.Property(PatientParameter, typeof(T).GetProperty(DbPropertyName));
      MethodCallExpression MethodAnyCall = Expression.Call(MethodAny, CollectionProperty, InnerFunction);
      return Expression.Lambda<Func<T, bool>>(MethodAnyCall, PatientParameter);
    }

    public Expression<Func<T, bool>> TokenPropertyEqualTo(string Property, Common.BusinessEntities.Search.DtoSearchParameterToken.TokenValue TokenValue)
    {
      //MyPredicate = MyPredicate.Or(x => x.active_Code == "Code" && x.active_System == "System");
      var type = typeof(T);
      var ParameterReferance = Expression.Parameter(type, "x");

      if (string.IsNullOrWhiteSpace(TokenValue.System))
      {
        var CodePropertyReference = Expression.Property(ParameterReferance, "gender_Code");
        var CodeConstantReference = Expression.Constant(StringSupport.ToLowerAndRemoveDiacritics(TokenValue.Code.Trim()));
        var CodeBinaryExpression = Expression.Equal(CodePropertyReference, CodeConstantReference);
        return Expression.Lambda<Func<T, bool>>(CodeBinaryExpression, new[] { ParameterReferance });

      }
      else
      {
        var CodePropertyReference = Expression.Property(ParameterReferance, "gender_Code");
        var CodeConstantReference = Expression.Constant(StringSupport.ToLowerAndRemoveDiacritics(TokenValue.Code.Trim()));
        var CodeBinaryExpression = Expression.Equal(CodePropertyReference, CodeConstantReference);

        var SystemPropertyReference = Expression.Property(ParameterReferance, "gender_System");
        var SystemConstantReference = Expression.Constant(StringSupport.ToLowerAndRemoveDiacritics(TokenValue.Code.Trim()));
        var SystemBinaryExpression = Expression.Equal(SystemPropertyReference, SystemConstantReference);

        var CodeAndSystemExpression = Expression.And(CodeBinaryExpression, SystemBinaryExpression);

        return Expression.Lambda<Func<T, bool>>(CodeAndSystemExpression, new[] { ParameterReferance });

      }

    }


    public Expression<Func<T, bool>> DatePropertyEqualTo(string Property, DateTimeOffset Value)
    {
      //(x => x.birthdate_DateTimeOffset == TestDate);
      var type = typeof(T);
      var ParameterReferance = Expression.Parameter(type, "x");
      var propertyReference = Expression.Property(ParameterReferance, Property + "_" + DateIndexPostfix);
      var constantReference = Expression.Constant(Value, typeof(DateTimeOffset?));
      var BinaryExpression = Expression.Equal(propertyReference, constantReference);
      return Expression.Lambda<Func<T, bool>>(BinaryExpression, new[] { ParameterReferance });
    }


    public Expression<Func<T, bool>> DateCollectionAnyStartsOrEndsWith(string Property, DateTimeOffset Value)
    {
      //(x => x.birthdate_DateTimeOffset == TestDate);
      var type = typeof(T);
      string DbPropertyName = Property + "_" + CollectionPostfix;

      //Inner
      MethodInfo MethodStartsWith = typeof(String).GetMethods().Where(m => m.Name == "StartsWith" && m.GetParameters().Length == 1).Single();
      MethodInfo MethodEndsWith = typeof(String).GetMethods().Where(m => m.Name == "EndsWith" && m.GetParameters().Length == 1).Single();

      ParameterExpression InnerParameter = Expression.Parameter(typeof(StringIndex), "c");
      MemberExpression InnerProperty = Expression.Property(InnerParameter, "String");
      ConstantExpression InnerValue = Expression.Constant(Value);

      MethodCallExpression MethodStartsWithCall = Expression.Call(InnerProperty, MethodStartsWith, InnerValue);
      MethodCallExpression MethodEndsWithCall = Expression.Call(InnerProperty, MethodEndsWith, InnerValue);

      var OrExpression = Expression.OrElse(MethodStartsWithCall, MethodEndsWithCall);
      Expression<Func<StringIndex, bool>> InnerFunction = Expression.Lambda<Func<StringIndex, bool>>(OrExpression, InnerParameter);

      //Outer Any
      MethodInfo MethodAny = typeof(Enumerable).GetMethods().Where(m => m.Name == "Any" && m.GetParameters().Length == 2).Single().MakeGenericMethod(typeof(StringIndex));

      ParameterExpression PatientParameter = Expression.Parameter(typeof(T), "x");
      MemberExpression CollectionProperty = Expression.Property(PatientParameter, typeof(T).GetProperty(DbPropertyName));
      MethodCallExpression MethodAnyCall = Expression.Call(MethodAny, CollectionProperty, InnerFunction);
      return Expression.Lambda<Func<T, bool>>(MethodAnyCall, PatientParameter);
    }


  }
}
