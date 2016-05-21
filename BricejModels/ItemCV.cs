using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BricejModels
{
    public interface ItemCV
    {
        int Id { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        string Dates { get; set; }
    }
}
