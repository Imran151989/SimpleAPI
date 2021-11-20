using SimpleAPI.Controllers;
using System;
using Xunit;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
           WeatherForecastController obj;
        [Fact]
        public void GetReturnValue()
        {
            obj= new WeatherForecastController();
           var objGet= obj.Get(1);
            Assert.Equal("Imran S",objGet.Value);

        }
    }
}
