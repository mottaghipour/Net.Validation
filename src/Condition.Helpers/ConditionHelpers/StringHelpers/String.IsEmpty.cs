namespace Nilgon.Net.Condition.Helpers
{
	public static partial class StringConditionHelpers
	{
        /// <summary>
        /// Indicates whether the specified <see cref="string"/> is empty string("").
        /// </summary>
        /// <param name="value"></param>
        /// <returns><see langword="true"/> if the <paramref name="value"/> parameter is empty string(""). otherwise, <see langword="false"/>.</returns>
        public static bool IsEmpty(this string value)
        {
			return value == string.Empty;
        }
	}
}
