using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP03;

namespace TP03
{
    public class PackageService
    {
        public async Task<Package> GetPackageByTrackingNumberAsync(int trackingNumber)
        {
            return new Package
            {
                TrackingNumber = trackingNumber,
                Status = "Em trânsito",
                SendDate = DateTime.Now.AddDays(-3),
                ExpectedDeliveryDate = DateTime.Now.AddDays(2),
                Events = "O pacote foi recebido no centro de distribuição."
            };
        }
    }
}
