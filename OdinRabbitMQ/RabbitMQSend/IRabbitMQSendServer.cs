using OdinPlugs.OdinInject.InjectInterface;
using OdinPlugs.OdinNoSql.OdinRabbitMQ.Models.RabbitMQConfigModel;
using OdinPlugs.OdinNoSql.OdinRabbitMQ.Models.RabbitMQModel;

namespace OdinPlugs.OdinNoSql.OdinRabbitMQ.RabbitMQSend
{
    public interface IRabbitMQSendServer : IAutoInject
    {
        void SendToRabbitMQ(RabbitMQOptions rabbitMQ, RabbitMQSendModel sendModel);
    }
}