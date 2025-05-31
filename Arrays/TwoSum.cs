using System;
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i = 0; i < nums.Length - 1; i++)
        {
            for(int j = i + 1; j < nums.Length; j++)
            {
                if(nums[i] + nums[j] == target)
                {
                    return new int []{i,j};
                }              
            }
        } 
        return new int []{-1,-1};
    }
}

public class Program
{
    public static void Main(string [] args)
    {
        Console.WriteLine("Enter the elements of the array: ");
        string[] input = Console.ReadLine().Split(' ');
        int [] nums = Array.ConvertAll(input, s => Convert.ToInt32(s));

        Console.WriteLine("Enter the target value: ");
        int target = Convert.ToInt32(Console.ReadLine());

        Solution sol = new Solution();
        int [] result = sol.TwoSum(nums, target);
        Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
    }
}
