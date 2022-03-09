using System;
namespace Nilgon.Net.Condition.Helpers
{
	public static partial class StringConditionHelpers
	{
		public static bool IsNull(this string value)
        {
			return value == null;
        }
	}
}

