using System;

namespace CustomRandomList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var myList = new RandomList();

            for (int i = 0; i < 50; i++)
            {
                myList.Add(i);
            }

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(myList.RandomString());
            }
        }
    }
}
