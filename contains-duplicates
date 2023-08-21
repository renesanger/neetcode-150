/*
  217. Contains Duplicates
  Level: Easy
  Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

  Example 1:
    Input: nums = [1,2,3,1]
    Output: true
*/

var containsDuplicate = function(nums) {
    var hash = {}
    for(var i=0;i<nums.length;i++)
    {
        if(!hash.hasOwnProperty(nums[i]))
        {
            hash[nums[i]]=1
        }
        else
        {
            return true;
        }
    }
    return false;
};
