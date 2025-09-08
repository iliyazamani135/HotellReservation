public interface IMessage
{
    void Publish<T>(T @event);
}
