using System;
using Xunit;
using BinaryStringToDecimal;


namespace BinaryStringToDecimalTest1
{
  public class UnitTest1
  {
    [Fact]
    public void ParseBinary_Check_Execution_ReturnDecimal()
    {
      //arrange
      var obj = new Program();
      //act
      var result = obj.ParseBinary("00001111");

      // assert
      Assert.Equal(15, result);

    }
  }
}
