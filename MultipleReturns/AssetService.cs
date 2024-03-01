using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleReturns
{
    /// <summary>
    /// Service to load assets for contacts
    /// </summary>
    public class AssetService : IAssetService
    {
        public List<Tuple<int, byte[]>> GetAssignedAssets(List<int> contactIDs)
        {
            var result = new List<Tuple<int, byte[]>>();
            // load assets for the given Contacts form a storage
            // add the assets, with the contactID to the result list

            return result;
        }
    }
}
