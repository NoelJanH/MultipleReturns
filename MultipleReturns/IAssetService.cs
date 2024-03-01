using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleReturns
{   
    public interface IAssetService
    {
        List<Tuple<int, byte[]>> GetAssignedAssets(List<int> contactIDs);
    }
}
