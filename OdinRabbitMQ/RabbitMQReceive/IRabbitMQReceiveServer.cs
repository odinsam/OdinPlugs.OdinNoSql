using System;
using OdinPlugs.OdinInject.InjectInterface;
using OdinPlugs.OdinNoSql.OdinRabbitMQ.Models.RabbitMQConfigModel;
using OdinPlugs.OdinNoSql.OdinRabbitMQ.Models.RabbitMQModel;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace OdinPlugs.OdinNoSql.OdinRabbitMQ.RabbitMQReceive
{
    public interface IRabbitMQReceiveServer : IAutoInject
    {
        void ReceiveJsonMessage(RabbitMQOptions rabbitMQ, RabbitMQReceivedModel[] receivedModel);
        void ReceiveJsonMessageByEvent(RabbitMQOptions rabbitMQ, RabbitMQReceivedModel[] receivedModel);
    }
}