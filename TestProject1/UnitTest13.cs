namespace TestProject1
{
    public class UnitTest13
    {
        [Fact]
        public void Test1()
        {
            var input_5 = "211 + 1 - 4 / 2 * 5 + 18 / 3 - 4 * 30"; 
            var result = Exo_13.Process(input_5);
            Assert.Equal(result, 88);
        }
    }
}