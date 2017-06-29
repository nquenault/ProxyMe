
namespace ProxyMe
{
    interface IProxy
    {
        string IP { get; }
        int Port { get; }
        string ToString();
    }
}
