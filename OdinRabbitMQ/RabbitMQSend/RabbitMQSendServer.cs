using OdinPlugs.OdinNoSql.OdinRabbitMQ.Models.RabbitMQConfigModel;
using OdinPlugs.OdinNoSql.OdinRabbitMQ.Models.RabbitMQModel;

namespace OdinPlugs.OdinNoSql.OdinRabbitMQ.RabbitMQSend
{
    public class RabbitMQSendServer : AbstractRabbitMQSendServer
    {
        public override void SendToRabbitMQ(RabbitMQOptions rabbitMQ, RabbitMQSendModel sendModel)
        {
            base.SendJsonMessage(rabbitMQ, sendModel);
        }
    }
}