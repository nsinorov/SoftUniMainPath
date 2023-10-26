using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villain_Names
{
    public static class SQLQueries
    {
        public const string GetVillainsWithNumberOfMinions = @"SELECT [Name],	COUNT(*) [TotalMinions]
                                                        FROM Villains v
                                                        JOIN MinionsVillains mv ON mv.VillainId = v.Id
                                                        GROUP BY [Name]
                                                        HAVING COUNT(*) > 3
                                                        ORDER BY TotalMinions
                                                        ";
    }
}
