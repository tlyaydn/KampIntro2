using System;
using System.Collections.Generic;
using System.Text;

namespace GeneriscIntro
{
    class MyList<T>// T Tipi bagsadersadece string degil cllas herşey koyabilşriz generic clas
    {
        T[] items;
        public MyList()//construvtor
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;//gecici dizi refarans tutat
            items = new T[items.Length + 1];//elaman sayısı 1 artur
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;

        }
    }
}
