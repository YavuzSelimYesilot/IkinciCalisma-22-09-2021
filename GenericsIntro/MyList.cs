using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;

        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items;                              //Geçici olarak listemizdeki bilgileri başka bir array e aktarıyoruz
            items = new T[items.Length + 1];                    //şimdi ise yine items adında yeni bir array oluşturuyoruz bu sayede
                                                                //hem bir tane eleman eklenmiş oluyor hemde boyutu 1 artan bir array
                                                                //elimize geçmiş oluyor.

            for (int i = 0; i < tempArray.Length; i++)          //geri aktarma işlemi
            {
                items[i] = tempArray[i];
            }

            //-1 denmesinin sebebi: eleman sayısı-1 = index' olmasından kaynaklıdır. 
            items[items.Length - 1] = item;

        }

        public int Length
        {
            get { return items.Length; }
        }

        public  T[] Items
        {
            get { return items; }
        }
           

    }
}
