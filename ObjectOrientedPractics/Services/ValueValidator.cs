using System;
namespace ObjectOrientedPractics.Services;

/// <summary>
/// Summary description for Class1
/// </summary>
public class ValueValidator
{
	public static void AssertStringOnLength(string value, int maxLength, string propertyName)
    {
		if(value,Length > maxLength)
		{
			throw new ArgumentException($"{propertyName} должен быть меньше {maxLength} символов");

		}		
	}
}
