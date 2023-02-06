using System;
class IndexerExample
{
    public string[] StringList = new string[10];

    public string this[int index]
    {
        get
        {
            return StringList[index];
        }
        set
        {
            StringList[index] = value;
        }
    }

    public int[,] intList = new int[10, 3];

    public int this[int index1, int index2]
    {
        get
        {
            return intList[index1, index2];
        }
        set
        {
            intList[index1, index2] = value;
        }
    }


    class OvrldIndexers
    {
        static void Main()
        {
            IndexerExample indexTest = new IndexerExample();
            indexTest[0] = "Sam"; indexTest[0, 0] = 100; indexTest[0, 1] = 98; indexTest[0, 2] = 70; indexTest[1] = "Tom"; indexTest[1, 0] = 60; indexTest[1, 1] = 93; indexTest[1, 2] = 74;
            Console.WriteLine("indexTest[1] is {0}", indexTest[0]);
            Console.WriteLine("Mark 1 of {0} is {1}", indexTest[0], indexTest[0, 0]); Console.WriteLine("Mark 2 of {0} is {1}", indexTest[0], indexTest[0, 1]);
            Console.WriteLine("Mark 3 of {0} is {1}", indexTest[0], indexTest[0, 2]);

            Console.WriteLine("indexTest[2] is {0}", indexTest[1]); Console.WriteLine("Mark 1 of {0} is {1}", indexTest[1], indexTest[1, 0]);

            Console.WriteLine("Mark 2 of {0} is {1}", indexTest[1], indexTest[1, 1]);
            Console.WriteLine("Mark 3 of {0} is {1}", indexTest[1], indexTest[1, 2]);
            Console.ReadLine();
        }
    }



}