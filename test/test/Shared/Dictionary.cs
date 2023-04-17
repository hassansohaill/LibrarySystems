using static test.Pages.Homepage;

    public static class Globals
    {
        public static bool loginCondition { get; set; }
    }

    public static class ListHold
    {
        public static List<string> Strings { get; set; } = new List<string> { "Our Missing Hearts"};
    }

    public static class ListCart
    {
    public static List<string> StringsCart { get; set; } = new List<string>();
    }
    public static class ListOverdue
    {
    public static List<string> StringsOverdue{ get; set; } = new List<string> { "Outlive", "The Fifth Juror", "My Secret Sister" };
    public static string Fees = "7.49";
}

public struct creditCards
{
    public string name;
    public string number;
    public string expiry;
    public string cvv;
    public string postal;
    public string country;
}

public static class ListPaymentMethods
{
    public static List<creditCards> CreditList { get; set; } = new List<creditCards>();   
}

