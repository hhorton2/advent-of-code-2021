using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoreLinq;

namespace AdventOfCode2021.Day04.Models
{
    public class BingoBoard
    {
        private readonly IList<IList<BingoSpace>> _columns;
        private readonly IList<IList<BingoSpace>> _rows;

        public BingoBoard(int[,] boardInput)
        {
            _rows = new List<IList<BingoSpace>>
            {
                new List<BingoSpace>(),
                new List<BingoSpace>(),
                new List<BingoSpace>(),
                new List<BingoSpace>(),
                new List<BingoSpace>()
            };
            _columns = new List<IList<BingoSpace>>
            {
                new List<BingoSpace>(),
                new List<BingoSpace>(),
                new List<BingoSpace>(),
                new List<BingoSpace>(),
                new List<BingoSpace>()
            };
            InitializeBoard(boardInput);
        }

        private void InitializeBoard(int[,] boardInput)
        {
            for (var i = 0; i < boardInput.GetLength(0); i++)
            for (var j = 0; j < boardInput.GetLength(1); j++)
            {
                _columns[i].Add(new BingoSpace
                {
                    Value = boardInput[i, j]
                });
                _rows[i].Add(new BingoSpace
                {
                    Value = boardInput[j, i]
                });
            }
        }

        public bool IsSolved()
        {
            return IsSolvedRow() ||
                   IsSolvedColumn();
        }

        private bool IsSolvedColumn()
        {
            return _columns.Any(r => r.All(s => s.Marked));
        }

        private bool IsSolvedRow()
        {
            return _rows.Any(r => r.All(s => s.Marked));
        }

        public void PlaceMark(int value)
        {
            var rowSpaceToMark = _rows.FirstOrDefault(r => r.Any(s => s.Value == value))
                ?.First(s => s.Value == value);
            var columnSpaceToMark = _columns.FirstOrDefault(r => r.Any(s => s.Value == value))
                ?.First(s => s.Value == value);
            if (rowSpaceToMark != null)
            {
                rowSpaceToMark.Marked = true;
            }

            if (columnSpaceToMark != null)
            {
                columnSpaceToMark.Marked = true;
            }
        }

        public int GetUnmarkedSum()
        {
            var sum = 0;
            foreach (var row in _rows)
            foreach (var bingoSpace in row)
            {
                if (!bingoSpace.Marked)
                {
                    sum += bingoSpace.Value;
                }
            }

            return sum;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            _rows.ForEach(row =>
            {
                row.ForEach(space =>
                {
                    sb.Append(space.Value)
                        .Append(' ');
                });
                sb.AppendLine();
            });
            return sb.ToString();
        }
    }
}