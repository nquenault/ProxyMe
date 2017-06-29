
namespace ProxyMe
{
    class MyIPAddressInfos
    {
        public string IP { get; private set; }
        public string City { get; private set; }
        public string ISP { get; private set; }

        public MyIPAddressInfos(string ip, string city, string isp)
        {
            IP = ip;
            City = city;
            ISP = isp;
        }
    }
}
