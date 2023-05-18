using Xunit;

namespace LeapYear.Tests
{ 
    public class YearTest
    {
        [Fact]
        public void A_Year_Not_Divisible_By_4_IsNot_LeapYear()
        {
            Assert.False(IsLeapYear(2017));
        }
        
        [Fact]
        public void A_Year_Divisible_By_400_Is_LeapYear()
        {
            Assert.True(IsLeapYear(2000));
        }

        [Fact]
        public void A_Year_Divisible_By_100_But_Not_By_400_IsNot_LeapYear()
        {
            Assert.False(IsLeapYear(1700));
        }

        [Fact]
        public void A_Year_Divisible_By_4_But_Not_By_100_IsLeapYear()
        {
            Assert.True(IsLeapYear(2008));
        }
        
        private static bool IsLeapYear(int year)
        {
            return new Year(year).IsLeap();
        }
    }
}