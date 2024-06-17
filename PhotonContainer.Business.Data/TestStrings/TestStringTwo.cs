using PhotonContainer.Business.Data.Interfaces;

namespace PhotonContainer.Business.Data.TestStrings
{
    public class TestStringTwo : ITestStrings
    {
        public string StringToReverse { get; set; } = "Lekker my maat die is die tweede string om te reverse. 2";
    }
}