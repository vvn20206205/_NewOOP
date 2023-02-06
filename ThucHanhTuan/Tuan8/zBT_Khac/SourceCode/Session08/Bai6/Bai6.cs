using System;
using System.Threading;

class MyThread {
    public int count;
    public Thread thrd;

    public MyThread(string name) {
        count=0;
        thrd=new Thread(this.run);
        thrd.Name=name;
    }

    void run() {
        Console.WriteLine(thrd.Name+" starting.");
        do {
            count++;

            Console.WriteLine("In "+thrd.Name);

        } while(count<5);

        Console.WriteLine(thrd.Name+" terminating.");
    }
}

class PriorityDemo {
    public static void Main() {
        MyThread mt1 = new MyThread("High Priority");
        MyThread mt2 = new MyThread("Low Priority");

        mt1.thrd.Priority=ThreadPriority.AboveNormal;
        mt2.thrd.Priority=ThreadPriority.BelowNormal;

        mt1.thrd.Start();
        mt2.thrd.Start();

        mt1.thrd.Join();
        mt2.thrd.Join();

        Console.WriteLine();
        Console.WriteLine(mt1.thrd.Name+" thread counted to "+
        mt1.count);
        Console.WriteLine(mt2.thrd.Name+" thread counted to "+
        mt2.count);
        Console.ReadLine();
    }
}

