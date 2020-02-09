using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskProject
{
    public class MulitThreadTask
    {
        public object _lock = new object();

        public void ThreadTest()
        {
            Debug.WriteLine("開始");
            //ServicePointManager.DefaultConnectionLimit = 100;
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int workerThreads, completionPortThreads;
            ThreadPool.GetMaxThreads(out workerThreads, out completionPortThreads);
            //workerThreads = 32;
            //ThreadPool.SetMaxThreads(workerThreads, completionPortThreads);
            Debug.WriteLine(string.Format("workerThreads:{0} ,completionPortThreads:{1}", workerThreads, completionPortThreads));


            //List<Task> listTask = new List<Task>();
            //for (int i = 0; i < 100; i++)
            //{
            //    Debug.WriteLine("Thread run" + i);
            //    listTask.Add(Task.Run(() => ThreadSleep(10000)));
            //}
            //var taskWhenAll = Task.WhenAll(listTask);
            //taskWhenAll.Wait();


            //Parallel.For(0, 100, (t, state) =>
            //{
            //    //Debug.WriteLine("Thread run" + t);
            //    ThreadSleep();
            //});


            Task.Run(() =>
            {
                Thread task;
                for (int i = 0; i < 100; i++)
                {
                    task = new Thread(new ThreadStart(ThreadSleep));
                    task.Start();
                }
            }).Wait();

            sw.Stop();
            Debug.WriteLine(sw.ElapsedMilliseconds);
        }

        public void ThreadSleep()
        {
            //Thread.Sleep(5000);
            Debug.WriteLine($"id:{Thread.CurrentThread.ManagedThreadId},i:{0},Time:{DateTime.Now.ToString("HH:mm:ss.fff")}");
        }
    }
}