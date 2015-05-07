namespace Monopoly.Interfaces
{
    using Monopoly.Players;

    public interface IDrawingEngine
    {
        void ClearScreen();

        void DrawDices(int firstValue, int secondValue);

        void DrawText(int x, int y, string text);

        void DrawPlayer(Player player,Position oldPosition);

        void DrawField();
    }
}
