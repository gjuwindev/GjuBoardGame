namespace GjuBoardGame.Pages
{
    public partial class BoardGame
    {
        int rowClicked = 0;
        int columnClicked = 0;

        private void SquareCliked(int row, int col)
        {
            rowClicked = row;
            columnClicked = col;
        }
    }
}