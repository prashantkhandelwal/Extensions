using System;
using System.Collections;

namespace Extensions.Collections
{
    public static class CollectionExtensions
    {
        /// <summary>
        /// Removes duplicates from the ArrayList
        /// </summary>
        /// <param name="arrList"></param>
        /// <returns></returns>
        public static ArrayList RemoveDuplicates(this ArrayList arrList)
        {
            ArrayList list = new ArrayList();
            foreach (string item in arrList)
            {
                if (!list.Contains(item))
                {
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
