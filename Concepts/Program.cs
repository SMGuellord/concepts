
using System.Linq.Expressions;

//Expression<Func<SomeClass, bool>> expr = el => el.SomeProperty == "abc" && el.AnotherProperty >= 123;

var someClassType = typeof(SomeClass);
var parameterExpression = Expression.Parameter(someClassType, "el");
var somePropertyExpression = Expression.Property(parameterExpression, nameof(SomeClass.SomeProperty));
var valueToCompareToSomePropertyExpression = Expression.Constant("abc");
var equalExpression = Expression.Equal(somePropertyExpression, valueToCompareToSomePropertyExpression);
var anotherPropertyExpression = Expression.Property(parameterExpression, nameof (SomeClass.AnotherProperty));
var valueToCompareToAnotherPropertyExpression = Expression.Constant(123);
var greaterThanEqualExpression = Expression.GreaterThanOrEqual(anotherPropertyExpression, valueToCompareToAnotherPropertyExpression);
var andExpression = Expression.And(equalExpression, greaterThanEqualExpression);

var lambda = Expression.Lambda<Func<SomeClass, bool>>(andExpression, parameterExpression);

SomeClass someClass = new SomeClass
{
    SomeProperty = "abc",
    AnotherProperty = 122,
};

var compiledResult = lambda.Compile().Invoke(someClass);
Console.WriteLine(compiledResult);


public class SomeClass
{
    public string SomeProperty { get; set; } = string.Empty;
    public int AnotherProperty { get; set; }
}