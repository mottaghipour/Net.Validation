namespace Nilgon.Net.Condition.Helpers
{
	public static partial class StringConditionHelpers
	{
        /// <summary>
        /// Indicates whether the specified <see cref="string"/> is not empty string("").
        /// </summary>
        /// <param name="value"></param>
        /// <returns><see langword="true"/> if the <paramref name="value"/> parameter is not empty string(""). otherwise, <see langword="false"/>.</returns>
        public static bool IsNotEmpty(this string value)
        {
			return value != string.Empty;
        }
	}
}
