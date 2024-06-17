using PhotonContainer.Business.Interfaces;

namespace PhotonContainer.Business.TestStrings
{
    public class TestStringOne : ITestStrings
    {
        public string StringToReverse { get; set; } = "Lekker my maat die is die eerste string om te reverse. 1";
    }
}