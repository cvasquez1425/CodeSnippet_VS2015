using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaDomain.Classes.Interfaces
{
    public interface IModificationHistory
    {
        DateTime DateModified { get; set; }  // I want to make sure that all my classes have this information on them.
        DateTime DateCreated  { get; set; }  // these two properties will be persisted in the db. 
        bool     IsDirty       { get; set; }  // for this example, it won't be persisted in the database, it is available to me on the client side ONLY
    }
}
