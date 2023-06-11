using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmPrograms
{
    public class Permutations
    {
        int count = 0;

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

        //public List<List<int>> Permute(List<int> nums)
        //{
        //    var res = new List<List<int>>();
        //    Helper(res, new List<int>(), nums);
        //    return res;
        //}

        //private void Helper(List<List<int>> res, List<int> temp, List<int> nums)
        //{
        //    if (temp.Count == nums.Count)
        //        res.Add(new List<int>(temp));
        //    else
        //        foreach (var num in nums)
        //            if (!temp.Contains(num))
        //            {
        //                temp.Add(num);
        //                Helper(res, temp, nums);
        //                temp.RemoveAt(temp.Count - 1);
        //            }

        //}

        //public List<List<int>> permute(int[] nums)
        //{
        //    var result = new List<List<int>>();
        //    BackTrack(result, new List<int>(), nums);
        //    return result;
        //}

        //public void BackTrack(List<List<int>> resualt, List<int> temp, int[] nums)
        //{

        //        if (temp.Count() == nums.Length)
        //        {
        //            resualt.Add(new List<int>(temp));
        //            return;
        //        }


        //        foreach (var number in nums)
        //        {
        //            if (temp.Contains(number))
        //            {
        //                continue;
        //            }

        //            temp.Add(number);
        //            BackTrack(resualt, temp, nums);
        //            temp.Remove(temp.Count() - 1);        
        //        }


        //}




        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> permutations = new List<IList<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                Combination(nums, i, permutations, new List<int>());
            }

            return permutations;
        }

        public void Combination(int[] nums, int currentIndex, IList<IList<int>> list, IList<int> contains)
        {
            contains.Add(nums[currentIndex]);

            if (contains.Count == nums.Length) list.Add(contains);
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i != currentIndex && contains.Contains(nums[i]) == false)
                    {
                        Combination(nums, i, list, new List<int>(contains));
                    }
                }
            }
        }






        public IList<IList<int>> MyPermute(int[] nums)
        {
            IList<IList<int>> resualt = new List<IList<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                MyCombination(nums, i, resualt, new List<int>());
            }

            return resualt;
        }

        public void MyCombination(int[] nums, int curentIndex, IList<IList<int>> resualt, List<int> empty)
        {
            empty.Add(nums[curentIndex]);
            if (empty.Count() == nums.Length) resualt.Add(empty);
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i != curentIndex && empty.Contains(nums[i]) == false)
                    {
                        MyCombination(nums, i, resualt, empty);
                    }
                }
            }
        }

        //public IList<IList<int>> DuplicatePermut(int[] num)
        //{
        //    var resualt = new List<IList<int>>();
        //    var used = new bool[num.Length];
        //    Array.Sort(num);

        //    for (int i = 0; i < num.Length; i++)
        //    {
        //        Helper(num, resualt, new List<int>(), i, used);

        //    }

        //    return resualt;

        //}

        //public void Helper(int[] num, List<IList<int>> result, List<int> empty, int currentIndex,bool[]used)
        //{
        //    used[currentIndex] = true;
        //    empty.Add(num[currentIndex]);


        //    if (empty.Count == num.Length )                     //&& !result.Contains(empty) 
        //    {
        //        result.Add(empty);
        //    }
        //    else
        //    {
        //        for (int i = 0; i < num.Length; i++)
        //        {
        //            if (i != currentIndex && empty.Contains(num[i]) == false)
        //            {
        //                used[i] = false;

        //                Helper(num, result, empty, i , used);
        //            }
        //            else
        //            {
        //                used[i] = false;

        //            }

        //        }
        //    }
        //}
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            Array.Sort(nums);
            Backtrack(nums, new bool[nums.Length], new List<int>(), ans);
            return ans;
        }

        private void Backtrack(int[] nums, bool[] taken, IList<int> li, IList<IList<int>> ans)
        {
            if (li.Count == nums.Length)
            {
                ans.Add(new List<int>(li));
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (!taken[i] && (i == 0 || taken[i - 1] || nums[i] != nums[i - 1]))
                {
                    taken[i] = true;
                    li.Add(nums[i]);
                    Backtrack(nums, taken, li, ans);
                    taken[i] = false;
                    li.RemoveAt(li.Count - 1);
                }
            }
        }

        public int NumTilePossibilities(string tiles)
        {
            var tills = tiles.ToCharArray();
            Array.Sort(tills);
            NumTilleHelper(tills, new bool[tiles.Length]);
            return count - 1;

        }

        public void NumTilleHelper(char[] tills, bool[] taken)
        {
            count++;
            for (int i = 0; i < tills.Length; i++)
            {
                if (taken[i] || (i > 0 && tills[i] == tills[i - 1] && !taken[i - 1]))
                    continue;
                else
                {
                    taken[i] = true;
                    NumTilleHelper(tills, taken);
                    taken[i] = false;
                }
            }
        }
    }
}










//  for (int i = 0; i<nums.Length; i++)
//        {
//            if (temp.Contains(temp[i]))
//            {
//                continue;
//            }

//            temp.Add(temp[i]);
//            BackTrack(resualt, temp, nums);
//            temp.Remove(temp.Count() - 1);
//        }