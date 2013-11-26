using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EuropeanVatChecker.Tests
{
    public class EuropeanVatNumberIsFormatValidTests
    {
        [Fact]
        public void ValidUKVatNumberIsValidTest()
        {
            var number = "673633126";
            var vatNumber = new EuropeanVatNumber
            {
                MemberState = EuropeanState.UnitedKingdom,
                Number = number
            };
            Assert.True(vatNumber.IsFormatValid());
        }

        [Fact]
        public void StateNotSetReturnsInvalidTest()
        {
            var vatNumber = new EuropeanVatNumber
            {
                Number = "676786786786786"
            };

            Assert.False(vatNumber.IsFormatValid());
        }

        [Fact]
        public void NumberNotSetReturnsInvalidTest()
        {
            var vatNumber = new EuropeanVatNumber
            {
                MemberState = EuropeanState.UnitedKingdom
            };

            Assert.False(vatNumber.IsFormatValid());
        }

        [Fact]
        public void NumberTooShortReturnsInvalidTest()
        {
            var vatNumber = new EuropeanVatNumber
            {
                MemberState = EuropeanState.UnitedKingdom,
                Number = "2"
            };

            Assert.False(vatNumber.IsFormatValid());
        }

        [Fact]
        public void NumberTooLongReturnsInvalidTest()
        {
            var vatNumber = new EuropeanVatNumber
            {
                MemberState = EuropeanState.UnitedKingdom,
                Number = "2222222222222222222222222222222222222222222"
            };

            Assert.False(vatNumber.IsFormatValid());
        }
    }
}
