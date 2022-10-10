using System;

namespace RoadBook.CsharpBasic.Chapter05.Works
{
    public class Exam002
    {
        public void Run()
        {
            Examples.Model.Board board = new Examples.Model.Board();
            Console.WriteLine("Input Title: ");
            board.Title = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Input Contents: ");
            board.Contents = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Input Writer: ");
            board.Writer = Convert.ToString(Console.ReadLine());

            Examples.Service.BoardService boardService = new Examples.Service.BoardService(board);
            boardService.Read();

        }
    }
}
