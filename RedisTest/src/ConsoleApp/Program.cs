using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("connecting...");
            try
            {
                var multi = ConnectionMultiplexer.Connect("127.0.0.1");
                
                TestSimple(multi);
                TestPubSub(multi);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
            Console.Read();
        }

        public static void TestSimple(IConnectionMultiplexer multi)
        {
            var db = multi.GetDatabase(0);

            db.StringSet("key", "value");

            Console.WriteLine(db.StringGet("key"));
        }

        public static void TestPubSub(IConnectionMultiplexer multi)
        {
            var sub = multi.GetSubscriber();
            sub.Subscribe("myChannel", (c, v)=>
            {
                Console.WriteLine($"received {v}.");
            });

            sub.Publish("myChannel", "message");
        }
    }
}
