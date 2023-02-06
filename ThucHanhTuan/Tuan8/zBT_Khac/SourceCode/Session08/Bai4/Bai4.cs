using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading;

public class MainClass {
    public static void Main() {
        int threadCount = 5;
        Thread[] threads = new Thread[threadCount];

        for(int i = 0;i<threadCount;i++) {
            int idx = i;
            threads[i]=new Thread(delegate ()
            { Console.WriteLine("Worker {0}",idx); });
        }

        Array.ForEach(threads,delegate (Thread t) { t.Start(); });
    }
}

