using System;
using OdinPlugs.OdinNoSql.OdinRabbitMQ.Models.RabbitMQConfigModel;
using OdinPlugs.OdinNoSql.OdinRabbitMQ.Models.RabbitMQModel;

namespace OdinPlugs.OdinNoSql.OdinRabbitMQ.RabbitMQSend
{
    public abstract class AbstractRabbitMQSendServer : IRabbitMQSendServer
    {
        public abstract void SendToRabbitMQ(RabbitMQOptions rabbitMQ, RabbitMQSendModel sendModel);
        public void SendJsonMessage(RabbitMQOptions rabbitMQ, RabbitMQSendModel sendModel)
        {
            RabbitMQSendHelper.SendJsonMessage(rabbitMQ, sendModel);
        }

        public static AbstractRabbitMQSendServer GetRabbitMQClient(string assemblyFullName)
        {
            return Activator.CreateInstance(Type.GetType(assemblyFullName)) as AbstractRabbitMQSendServer;
        }
    }
}