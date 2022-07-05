using NhlLib.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace NhlLib.Interfaces
{
    public interface IPlayer
    {
        int Id { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        PositionType Position { get; set; }
    }
}
