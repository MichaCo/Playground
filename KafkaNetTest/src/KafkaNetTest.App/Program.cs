using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kafka;
using Kafka.Client.Cfg;
using Kafka.Client.Producers;
using Kafka.Client.ZooKeeperIntegration;
using KafkaNET;

namespace KafkaNetTest.App
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ZooKeeperClient zkClient = new ZooKeeperClient("hortsrv",
                            ZooKeeperConfiguration.DefaultSessionTimeout, ZooKeeperStringSerializer.Serializer))
            {
                zkClient.Connect();

                var state = zkClient.GetClientState();
                var topics = zkClient.GetChildren(ZooKeeperClient.DefaultBrokerTopicsPath);
                var ids = zkClient.GetChildren(ZooKeeperClient.DefaultBrokerTopicsPath);
                var consumers = zkClient.GetChildren(ZooKeeperClient.DefaultConsumersPath);
            }

                //var brokerConfig = new BrokerConfiguration()
                //{
                //    BrokerId = 0,
                //    Host = "hortsrv",
                //    //Port = this.kafkaPort
                //};
                //var config = new ProducerConfiguration(new List<BrokerConfiguration> { brokerConfig });
                //var kafkaProducer = new Producer(config);
                //// here you construct your batch or a single message object
                //var batch = CreateMessages();
                //kafkaProducer.Send(batch);

            }

        static IEnumerable<ProducerData<string, Kafka.Client.Messages.Message>> CreateMessages()
        {
            return null;
        }
    }
}
