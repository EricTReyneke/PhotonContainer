using PhotonContainer.Business.DIContainers;
using PhotonContainer.Business.Interfaces;
using PhotonContainer.Business.ReverseStrings;
using PhotonContainer.Business.TestStrings;

namespace PhotonContainer
{
    public class Program
    {
        static IContainers container = new PhotonDIContainer();

        public static void Main(string[] args)
        {
            DIServices();

            IStringReversals reversalService = container.Resolve<IStringReversals>();

            Console.WriteLine($"Reversed: {reversalService.ReverseString()}");

            Console.ReadLine();
        }

        private static void DIServices()
        {
            container.Register<IStringReversals, PhotonReversal>();
            container.Register<ITestStrings, TestStringOne>();

            container.Resolve<ITestStrings>();
        }
    }
}