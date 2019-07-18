using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace License_Management
{
    class LicEntityRefresh
    {
        public static void Refresh(LicenseEntity db)
        {
            var context = ((IObjectContextAdapter)db).ObjectContext;
            var refreshableObjects = db.ChangeTracker.Entries().Select(c => c.Entity).ToList();
            context.Refresh(RefreshMode.StoreWins, refreshableObjects);
        }
    }
}

