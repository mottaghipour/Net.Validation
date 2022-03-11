using System;
using System.Collections.Generic;
using System.Text;

namespace Nilgon.Net.Condition.Helpers
{
    public static partial class StringConditionHelpers
    {
        /// <summary>
        /// Indicates whether the specified <see cref="string"/> is <see langword="null"/>.
        /// </summary>
        /// <param name="value"></param>
        /// <returns><see langword="true"/> if the <paramref name="value"/> parameter is <see langword="null"/>. otherwise, <see langword="false"/>.</returns>
        public static bool IsNull(this string value)
        {
            return value == null;
        }
    }
}
