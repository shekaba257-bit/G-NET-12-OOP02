using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Session02_OOP
{
    internal struct SeatLocation
    {
        public int Row { get; set; }
        public int Number { get; set; }

        public SeatLocation(int row, int number)
        {
            Row = row;
            Number = number;
        }

        public override string ToString() => $"Row {Row}, Seat {Number}";
    }

}

