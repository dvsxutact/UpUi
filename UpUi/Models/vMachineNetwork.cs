using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpUi.Models
{
    public class vMachineNetwork
    {
        public int Id { get; set; }

        /// <summary>
        /// ID of the vMachine that this network definition belongs to
        /// </summary>
        public int vMachineId { get; set; }
        
        /// <summary>
        /// Do we want this network to use dhcp?
        /// </summary>
        public bool Use_DHCP { get; set; }

        /// <summary>
        /// If Use_DHCP is set to false, then we can set a static IP for this Netwokr
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// We can also give our vMachine a custom static Mac Address
        /// </summary>
        public string MacAddress { get; set; }

        /// <summary>
        /// is this a public network??
        /// </summary>
        public bool IsPublic { get; set; }

        /// <summary>
        /// Hostname for this network
        /// </summary>
        public string Hostnmae { get; set; }

    }
}
