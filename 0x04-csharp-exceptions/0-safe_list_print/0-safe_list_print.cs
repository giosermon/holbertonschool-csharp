using System;
using System.Collections.Generic;

    class List
    {
        public static int SafePrint(List<int> myList, int n)
        {
            int j = 0;
            try
            {
                for (int i = 0; i < myList.Count; i++)
                {
                    if (i < n)
                    {
                        Console.WriteLine(myList[i]);
                        j++;
                    }
                }  
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return (j);
        }
}
