using System.Linq;
using Training.Features;

namespace Training
{
    internal static class Program
    {
        static void Main(string[] args)
        {

            var clients = AccountMixer.Mix();

            var sumValue =  clients.Select(x => x.Accounts).ToList();

            var sumBynames = clients.Where(x => x.LastName.Contains("კა")).Select(x => x.Accounts.Sum(x => x.Value));

            var groupBy = clients.GroupBy(x => x.FirstName);

            var specificNatia = clients.Where(x => x.FirstName.Contains("გიორგი")).Select(x => new
            {
                jami = x.Accounts.Sum(x => x.Value),
                vinaoba = x.FullName
            }).Where(x => x.jami > 4000);

        }
    }
}