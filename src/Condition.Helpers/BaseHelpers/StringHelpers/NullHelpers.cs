using System;

namespace Nilgon.Net.Condition.Helpers
{
	public static partial class StringHelpers
	{
		/// <summary>
        /// IsNull
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
		public static bool IsNull(this string value)
        {
			return value == null;
        }
	}
}

