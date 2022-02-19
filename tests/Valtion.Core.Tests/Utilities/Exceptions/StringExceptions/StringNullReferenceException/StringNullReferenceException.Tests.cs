using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Valtion.Core.Utilities.Exceptions.StringExceptions;

namespace Valtion.Core.Tests.Utilities.Exceptions.StringExceptions
{
    public class StringNullReferenceException_Tests
    {
        [Fact]
        public void Throw_StringNullReferenceException_Without_Parameters()
        {
            Action Throw = () => throw new StringNullReferenceException();

            Assert.Throws<StringNullReferenceException>(Throw);
        }
    }
}
