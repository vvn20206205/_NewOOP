 
using System;
using System.Threading;

class MyThread {
    public int count;
    public Thread thrd;

    public MyThread(string name) {
        count=0;
        thrd=new Thread(this.run);
        thrd.Name=name;
        thrd.Start();
    }

    void run() {
        Console.WriteLine(thrd.Name+" starting.");

        do {
            Thread.Sleep(500);
            Console.WriteLine("In "+thrd.Name+
            ", count is "+count);
            count++;
        } while(count<10);

        Console.WriteLine(thrd.Name+" terminating.");
    }
}


class MainClass {
    public static void Main() {
        Console.WriteLine("Main thread starting.");

        MyThread mt1 = new MyThread("Child #1");
        MyThread mt2 = new MyThread("Child #2");
        MyThread mt3 = new MyThread("Child #3");

        Thread.Sleep(10000);

        Console.WriteLine("Main thread ending.");
    }
}

