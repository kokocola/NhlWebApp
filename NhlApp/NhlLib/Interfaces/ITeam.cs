using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NhlLib.Interfaces
{
    public interface ITeam
    { 
        int Id { get; set; }

        string Name { get; set; }
        
        string Link { get; set; }
    }
}
