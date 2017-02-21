using ExpectedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode_15_3Sum
{
    [TestClass]
    public class UnitTest1
    {
        [Ignore]
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
                {new List<int>() {-1, -2, 3}};

            ShouldBeEqual(nums, expected);
        }
    }

    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        var item1 = nums[i];
                        var item2 = nums[j];
                        var item3 = nums[k];

                        if (item1 + item2 + item3 == 0)
                        {
                            result.Add(new List<int> { item1, item2, item3 });
                        }
                    }
                }
            }

            return result;
        }
    }
}