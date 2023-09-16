using System;
namespace ObjectOrientedPractics.Services;

/// <summary>
/// Summary description for IdGenerator,
/// </summary>
public class IdGenerator
{
	private static int _nextId = 1;

	public static int GetNextId()
	{
		return _nextId++;

	}
}
