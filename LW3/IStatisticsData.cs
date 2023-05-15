using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW3
{
    public interface IStatisticsData
    {
        bool LoadData(string filePath);

        string[] GetFields();

        List<string[]> GetEntries();

        string GetSummary();
    }
}
