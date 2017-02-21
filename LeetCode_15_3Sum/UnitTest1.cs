﻿using ExpectedObjects;
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

            var expected = new List<List<int>>
            {
                new List<int> {-1, 0, 1},
                new List<int> {-1, -1, 2},
            };

            var actual = new Solution().ThreeSum(nums);

            expected.ToExpectedObject().ShouldEqual(actual);
        }


    }

    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            return null;
        }
    }
}