using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 方仓DAM测试系统
{
    public enum ThreadStyle
    {
        默认,
        测试线程,
        校准线程,
        UI线程,
    }
    public class ThreadHelper
    {
        public static List<Thread> Threads = new List<Thread>();
        public static void Start(ThreadStart start, ThreadStyle name = ThreadStyle.默认)
        {
            Thread thread = new Thread(start);
            thread.IsBackground = true;
            thread.Name = name.ToString();
            thread.Start();
            Threads.Add(thread);
        }
        public static void Abort(ThreadStyle name)
        {
            for (int i = 0; i < Threads.Count; i++)
            {
                if (Threads[i].Name == name.ToString())
                {
                    try
                    {
                        if (name == ThreadStyle.测试线程)
                        {
                           //TestTaskDispatcher.IsStop = true;
                        }
                        else
                        {
                            Threads[i].Abort();
                        }
                        Threads.Remove(Threads[i]);
                    }
                    
                    catch (Exception)
                    {

                    }
                }
            }
        }
        public static void Close()
        {
            for (int i = 0; i < Threads.Count; i++)
            {
                if (Threads[i].IsAlive)
                {
                    try
                    {
                        Threads[i].Abort();
                    }
                    catch (Exception)
                    {

                    }
                }           
            }
        }
    }
}
