using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {

        static void Main(string[] args)
        {
        }

        public async Task<Dictionary<int,int>> RetornaPacotes(int pacote, int numTotalRegistros)
        {
            return await new RetornaPacotes().PackageGenerator(pacote, numTotalRegistros);
        }
    }
}
