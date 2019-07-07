using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<int>
    {
        private Random rand;

        public RandomList()
        {
            rand = new Random();
        }
        public int RandomString()
        {
            int index = rand.Next(0, this.Count);

            var element = this[index];
            this.RemoveAt(index);

            return element;
        }
    }
}
