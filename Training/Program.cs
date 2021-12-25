using Training.Features;

namespace Training
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var clients = AccountMixer.Mix();
        }
    }
}