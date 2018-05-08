using System;
using System.Collections.Generic;
using System.Text;

namespace NhlLib.Interfaces
{
    public interface IPlayer
    {
        int Id { get; set; }

        string FullName { get; set; }
    }
}
