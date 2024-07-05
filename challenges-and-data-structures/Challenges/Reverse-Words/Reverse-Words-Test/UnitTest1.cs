namespace Reverse_Words_Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("csharp is programming language", "language programming is csharp")]
        [InlineData("Reverse the words in this sentence", "sentence this in words the Reverse")]
        [InlineData("challenges and data structures", "structures data and challenges")]
        public void ReverseCase(string word ,string reversed)
        {

          string result=  Reverse_Words.Program.ReverseWords(word);

            Assert.Equal(result, reversed);
        }
    }
}