using Monopoly.Cards;
namespace Monopoly.Interfaces
{
    public interface ICard
    {
        string Description { get; }
        CardType CardType { get; }
    }
}
