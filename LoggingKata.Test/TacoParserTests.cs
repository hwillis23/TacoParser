using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything  _nothing to do so leave this part alone 

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("32.503039, -87.821677, Taco Bell Demopoli...", -87.821677)]
        [InlineData("34.719613, -86.578994, Taco Bell Huntsville...", -86.578994)]
        [InlineData("34.996237,-85.291147,Taco Bell Chattanooga...", -85.2911470)]
        [InlineData("30.188307,-85.757511,Taco Bell Panama City Beach...", -85.757511)]
        [InlineData("33.168176,-87.521815,Taco Bell Tuscaloosa...", -87.521815)]



        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            // write for Longitude in this scope
            
            //Arrange
            var tacoParserLong = new TacoParser();

            //Act
            var actual = tacoParserLong.Parse(line).Location.Longitude;


            //Assert
            Assert.Equal(expected,actual);
        }


        //TODO: Create a test for ShouldParseLatitude

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("32.503039, -87.821677, Taco Bell Demopoli...", 32.503039)]
        [InlineData("34.719613, -86.578994, Taco Bell Huntsville...", 34.719613)]
        [InlineData("34.996237,-85.291147,Taco Bell Chattanooga...", 34.996237)]
        [InlineData("30.188307,-85.757511,Taco Bell Panama City Beach...", 30.188307)]
        [InlineData("33.168176,-87.521815,Taco Bell Tuscaloosa...", 33.168176)]



        public void ShouldParseLatitude(string line, double expected)
        {
          //Write for Latitude 

            //Arrange
            var tacoParserLatitude = new TacoParser();

            //Act 
            var actual = tacoParserLatitude.Parse(line).Location.Latitude;


            //Assert

            Assert.Equal(expected, actual); 




        }

    }
}
