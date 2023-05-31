using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmPrograms
{
    public class Permutations
    {

        //public List<List<int>> permute(int[] nums)
        //{

        //    List<List<int>> resultList = new List<List<int>>();

        //    backtrack(resultList, new List<List<int>>(), nums);
        //    return resultList;
        //}



        //private void backtrack(List<List<int>> resultList,
        //    ArrayList<int> tempList, int[] nums)
        //{
        //    If we match the length, it is a permutation
        //    if (tempList.Count == nums.Length)
        //    {
        //        resultList.add(new ArrayList<>(tempList));
        //        return;
        //    }

        //    for (int number : nums)
        //    {
        //        Skip if we get same element
        //        if (tempList.contains(number))
        //            continue;

        //        Add the new element
        //        tempList.add(number);

        //        Go back to try other element
        //        backtrack(resultList, tempList, nums);

        //        Remove the element
        //        tempList.remove(tempList.size() - 1);
        //        }
        //}

        //        public List<List<int>> permution(int[]num)
        //    {
        //        List<List<int>>resualtlist=new List<List<int>>();
        //        List<int>? tempList = new List<int>();
        //        Backtraking(num, resualtlist, tempList);
        //        return resualtlist;
        //    }

        //    public void Backtraking(int[] num, List<List<int>> resualtlist, List<int> tempList)
        //    {



        //        foreach (var number in num)
        //        {
        //            if (!tempList.Contains(number))
        //            {
        //                tempList.Add(number);


        //            }
        //            else
        //            {
        //                continue;

        //            }



        //        }
        //        if (num.Length == tempList.Count)
        //        {
        //            resualtlist.Add(new List<int>(tempList));

        //        }
        //        Backtraking(num, resualtlist, tempList);

        //        tempList.Remove(tempList.Capacity - 1);
        //    }

        public IList<IList<int>> Permute(int[] nums)
        {
            var res = new List<IList<int>>();
            Helper(res, new List<int>(), nums);
            return res;
        }

        private void Helper(List<IList<int>> res, List<int> temp, int[] nums)
        {
            if (temp.Count == nums.Length)
                res.Add(new List<int>(temp));
            else
                foreach (var t in nums)
                    if (!temp.Contains(t))
                    {
                        temp.Add(t);
                        Helper(res, temp, nums);
                        temp.RemoveAt(temp.Count - 1);
                    }
           
        }
    }
}
