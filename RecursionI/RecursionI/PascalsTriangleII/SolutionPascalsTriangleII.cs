using System.Collections.Generic;
using System.Linq;

namespace RecursionI.PascalsTriangleII
{
    public class SolutionPascalsTriangleII
    {
        public IList<int> GetRow(int rowIndex)
        {
            if (rowIndex == 0 || rowIndex == 1)
            {
                return FillRow(rowIndex);
            }

            return GetNextRow(FillRow(1), rowIndex);
        }

        public IList<int> FillRow(int rowIndex)
        {
            var result = new List<int>();

            for (int i = 0; i <= rowIndex; i++)
            {
                result.Add(1);
            }

            return result;
        }

        public IList<int> GetNextRow(IList<int> prewList, int rowIndex)
        {
            int currentRowIndex = prewList.Count();

            if (currentRowIndex - 1 == rowIndex)
            {
                return prewList;
            }

            var result = new List<int>();
            result.Add(1);
            for (int i = 1; i < prewList.Count(); i++)
            {
                result.Add(prewList[i - 1] + prewList[i]);
            }
            result.Add(1);

            return GetNextRow(result, rowIndex);
        }
    }
}