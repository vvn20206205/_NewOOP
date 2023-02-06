using System;


using System.Collections;


class MainClass
{

    public static void Main()
    {

        SortedList mySortedList = new SortedList();
        mySortedList.Add("NY", "New York");
        mySortedList.Add("FL", "Florida");
        mySortedList.Add("AL", "Alabama");
        mySortedList.Add("WY", "Wyoming");
        mySortedList.Add("CA", "California");

        foreach (string myKey in mySortedList.Keys)
        {
            Console.WriteLine("myKey = " + myKey);

        }

        foreach (string myValue in mySortedList.Values)
        {
            Console.WriteLine("myValue = " + myValue);

        }

        Console.WriteLine("Getting the value list");
        IList myValueList = mySortedList.GetValueList();

        foreach (string myValue in myValueList)
        {
            Console.WriteLine("myValue = " + myValue);

        }

    }

}

