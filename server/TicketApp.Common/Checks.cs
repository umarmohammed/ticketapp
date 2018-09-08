using System;

namespace TicketApp.Common
{
    public static class Checks
    {
        public static void NotNull(object item, string itemName)
        {
            if (item == null) throw new ArgumentNullException($"{itemName} cannot be null");
        }
    }
}
