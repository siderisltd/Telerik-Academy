namespace Monopoly.Interfaces
{
    public interface IDice
    {
        int FirstDiceValue { get; set; }
        int SecondDiceValue { get; set; }
        void Roll();
        void ThrowDices();
    }
}
