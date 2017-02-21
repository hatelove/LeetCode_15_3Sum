using ExpectedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_15_3Sum
{
    [TestClass]
    public class UnitTest1
    {
        [TestCategory("leetcode")]
        [TestMethod]
        public void Test_From_leetcode_description()
        {
            var nums = new int[] { -1, 0, 1, 2, -1, -4 };

            var expected = new List<IList<int>>
            {
                new List<int> {-1, 0, 1},
                new List<int> {-1, -1, 2},
            };

            ShouldBeEqual(nums, expected);
        }

        private static void ShouldBeEqual(int[] nums, IList<IList<int>> expected)
        {
            var actual = new Solution().ThreeSum(nums);

            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod]
        public void test_nums_0_0_0()
        {
            var nums = new int[] { 0, 0, 0 };
            var expected = new List<IList<int>>
                {new List<int>() {0, 0, 0}};

            ShouldBeEqual(nums, expected);
        }

        [TestMethod]
        public void test_nums_m1_m2_0_3()
        {
            var nums = new int[] { -1, -2, 0, 3 };
            var expected = new List<IList<int>>
                {new List<int>() {-2, -1, 3}};

            ShouldBeEqual(nums, expected);
        }

        [TestMethod]
        public void nums_3_0_m2_m1_1_2()
        {
            var nums = new int[] { 3, 0, -2, -1, 1, 2 };
            var expected = new List<IList<int>>
            {
                new List<int>() {-2, -1, 3},
                new List<int>() {-2, 0, 2},
                new List<int>() {-1, 0, -1}
            };

            ShouldBeEqual(nums, expected);
        }
    }

    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] oNums)
        {
            var nums = oNums.OrderBy(x => x).ToArray();
            var set = new List<IList<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                var item1 = nums[i];

                if (item1 > 0)
                {
                    break;
                }

                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                for (int j = i + 1; j < nums.Length; j++)
                {
                    var item2 = nums[j];
                    if (item1 + item2 > 0)
                    {
                        break;
                    }

                    if (j > i + 1 && nums[j] == nums[j - 1])
                    {
                        continue;
                    }

                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        var item3 = nums[k];

                        var threeSum = item1 + item2 + item3;
                        if (threeSum > 0)
                        {
                            break;
                        }

                        if (k > j + 1 && nums[k] == nums[k - 1])
                        {
                            continue;
                        }

                        if (threeSum == 0)
                        {
                            set.Add(new List<int> { item1, item2, item3 });
                        }
                    }
                }
            }

            return set;
        }
    }
}