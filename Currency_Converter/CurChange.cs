namespace Currency_Converter
{
    public class CurChange
    {
        public int FiftyPound { get; }
        public int TwentyPound { get; }
        public int TenPound { get; }
        public int FivePound { get; }
        public int TwoPound { get; }
        public int OnePound { get; }
        public int FifyPence { get; }


        public CurChange(decimal price)
        {

            FiftyPound = (int)(price / 50);
            price %= 50;

            TwentyPound = (int)(price / 20);
            price %= 20;

            TenPound = (int)(price / 10);
            price %= 10;

            FivePound = (int)(price / 5);
            price %= 5;

            TwoPound = (int)(price / 2);
            price %= 2;

            OnePound = (int)(price / 1);
            price %= 1;

            FifyPence = (int)(price / .50m);
            price %= .50m;
        }
    }
}
