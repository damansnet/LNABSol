using Infrastructure.Utility;
using System;
using Xunit;

namespace ServerSide.xTests
{
    public class UtilityTests
    {
        [Fact]
        public void EncryptingString_mustEncrypt()
        {
            string input = "Password";
            string output = Utility.MD5Hash(input);
            System.Diagnostics.Debug.Print(output);
            Assert.NotEqual(output, input);

        }


        [Theory]
        [InlineData("?d~?^g\u0011?U7R\u0018!+9d")]
        //[InlineData("?d~?^g\u0011?U7R\u0018!+9d1111")]
        public void Encrypted_MustMatch(string input)
        {

            string pass = "Password";
            bool output = Utility.IsPasswordMatched(pass, input);
            Assert.True(output);


        }


    }
}
