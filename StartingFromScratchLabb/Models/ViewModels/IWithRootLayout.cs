using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartingFromScratchLabb.Models.ViewModels
{
    public interface IWithRootLayout
    {
        RootLayoutViewModel Layout { get; set; }
    }
}
