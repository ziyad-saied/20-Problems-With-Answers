
//using System.Collections.Generic;

//namespace leetcode
//{
//    internal class Program
//    {

//        //public static int RomanToInt(string s)
//        //{
//        //    Dictionary<char, int> Roman = new Dictionary<char, int>
//        //    {
//        //        {'I', 1},
//        //        {'V', 5},
//        //        { 'X', 10},
//        //        { 'L', 50},
//        //        { 'C', 100},
//        //        { 'D', 500},
//        //        { 'M', 1000}
//        //    };
            
//        //    //s.ToArray();
//        //    int total=0;
//        //    for (int i = 0; i < s.Length; i++)
//        //    {

//        //        int compared = Roman[s[i]];
//        //        if (i + 1 < s.Length && compared < Roman[s[i + 1]])
//        //        {
//        //            total -= compared;
//        //        }
//        //        else
//        //        {
//        //            total += compared;
//        //        }
//        //    }
//        //    return total;
//        //}
//        //public static List<int> DeleteZeros(int[] num)
//        //{
//        //    List<int> list = new List<int>();
//        //    for (int i = 0; i < num.Length; i++)
//        //    {
//        //        if (num[i] == 0)
//        //        {
//        //            continue;
//        //        }
//        //        else
//        //        {
//        //            list.Add(num[i]);
//        //        }
//        //    }
//        //    return list;
//        //}

//        //[2,7,11,15] 9
//        //public static int[] TwoSum(int[] nums, int target)
//        //{
//        //    //[3, 2, 4,5,6,7,8,9] [2,5,5,11]
//        //    List<int>li=new List<int> ();
//        //    for (int i = 0;i < nums.Length;i++)
//        //    {
//        //        for (int j = i+1; j < nums.Length; j++)
//        //        {
//        //            if (target == nums[i] + nums[j])
//        //            {
//        //                li.Add(i);
//        //                li.Add(j);
//        //            }
//        //        }
//        //        if (li.Count() == 2)
//        //        {
//        //            break;
//        //        }
//        //        else
//        //        {
//        //            continue ;
//        //        }
//        //    }
//        //    int[] res = li.ToArray();

//        //    foreach (var item in res)
//        //    {
//        //        Console.WriteLine(item);

//        //    }
//        //    return res;
//        //}
//        //public static void Merge(int[] nums1, int m, int[] nums2, int n)
//        //{
//        //    Array.Sort(nums1);
//        //    Array.Sort(nums2);
//        //    List<int> list1 = new List<int>();
//        //    List<int> list2 = new List<int>();
//        //    list1 = DeleteZeros(nums1);
//        //    list2 = DeleteZeros(nums2);
//        //    int[] store1 = list1.ToArray();
//        //    int[] store2 = list2.ToArray();
//        //    int[] merged = new int[m + n];
//        //    merged = store1.Concat(store2).ToArray();
//        //    Array.Sort(merged);
//        //    int[] store=new int[m + n];
//        //    for (int item=0;item<merged.Length;item++)
//        //    {
//        //        store[item] = merged[item];
//        //    }
//        //    Console.WriteLine("[" + string.Join(", ", store) + "]");
//        //}
//            static void Main(string[] args)
//        {
//            //Console.WriteLine(RomanToInt("MCMXCIV"));
//            //    int[] nums1 = [1, 2, 3, 0, 0, 0];
//            //    int[] nums2 = [2, 5, 6];
//            //    Merge(nums1,3,nums2,3);
//            //int[] nu = [2,5,5,11];
//            //Console.WriteLine(TwoSum(nu, 10));
//            Student student = new ("Ziyad");
//            student.Name = "Mohammed";
//            student.age = 23;
//            Console.WriteLine(student.age);
//            Console.WriteLine(student.Name);
             
//        }
//    }
//}
