using System;
using System.Collections.Generic;
using System.Text;

namespace LoodosQ1
{
    public class ComparePermutation : IComparePermutation
    {
        public bool Compare(string str1, string str2)
        {
            List<string> strPermutationList1 = new List<string>();
            List<string> strPermutationList2 = new List<string>();

            if (string.IsNullOrEmpty(str1))
                throw new Exception("First string is null or empty! Please send valid string!");

            if (string.IsNullOrEmpty(str2))
                throw new Exception("Second string is null or empty! Please send valid string!");

            permute(str1, 0, (str1.Length) - 1, strPermutationList1);
            permute(str2, 0, (str2.Length) - 1, strPermutationList2);

            return ComparePermutations(strPermutationList1, strPermutationList2, str1.Length, str2.Length);
        }

        private static bool ComparePermutations(List<string> strList1, List<string> strList2, int str1Length, int str2Length)
        {
            List<string> bigPermutationList;
            List<string> smallPermutationList;

            if (str1Length > str2Length)
            {
                bigPermutationList = strList1;
                smallPermutationList = strList2;
            }
            else
            {
                bigPermutationList = strList2;
                smallPermutationList = strList1;
            }

            foreach (var small in smallPermutationList)
            {
                foreach (var big in bigPermutationList)
                {
                    if (big.Contains(small))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /**
        * permutation function
        * @param str string to
        * calculate permutation for
        * @param l starting index
        * @param r end index
        **/
        private static void permute(string str, int lIndex, int rIndex, List<string> strList)
        {
            if (lIndex == rIndex)
                strList.Add(str);
            else
            {
                for (int i = lIndex; i <= rIndex; i++)
                {
                    str = swap(str, lIndex, i);
                    permute(str, lIndex + 1, rIndex, strList);
                    str = swap(str, lIndex, i);
                }
            }
        }

        /**
        * Swap Characters at position
        * @param a string value
        * @param i position 1
        * @param j position 2
        * @return swapped string
        **/
        private static string swap(string a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
