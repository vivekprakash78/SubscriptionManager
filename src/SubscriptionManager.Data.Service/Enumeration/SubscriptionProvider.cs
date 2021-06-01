namespace SubscriptionManager.Data.Enumeration
{
    /// <summary>
    /// Subscription Providers
    /// </summary>
    public enum SubscriptionProvider
    {
        //Video streaming service (1xx)
        Netflix = 100,
        DisneyHotstar = 101,
        AmazonPrime = 102,
        SonyLiv = 103,
        Zee5 = 104,
        YouTubePremium = 105,

        //Audio streaming service (2xx)
        Spotify = 201,
        Gaana = 202,
        Saavn = 203,
        Audible = 204,

        //Other service (3xx)
        Zomato = 301,
        Swiggy = 302,
        PayTMFirst = 303
    }
}
