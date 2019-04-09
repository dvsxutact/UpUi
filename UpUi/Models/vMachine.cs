using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpUi.Models
{
    /// <summary>
    /// This class will be dedicated to the "Vagrant Machine" or otherwise known as "Virtual Machine" (I.e this is the machine we'll be creating using a vagrant file)
    /// </summary>
    public class vMachine
    {
        public int Id { get; set; }

        /// <summary>
        /// Unique name for this vMachine
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Box value, this will be found on the vagrant box's page
        /// </summary>
        public string Box { get; set; }

        /// <summary>
        /// This should indicate where we want to store the vMachine files
        /// </summary>
        public string StorageLocation { get; set; }

        /// <summary>
        /// how many cpu's does this vMachine need?
        /// </summary>
        public int CpuCount { get; set; }

        /// <summary>
        /// Whats the maximum amount of memory for this vMachine?
        /// </summary>
        public int MaxMemory { get; set; }

        /// <summary>
        /// Should we use / show the Ui for this vMachine?
        /// </summary>
        public bool UseGui { get; set; }

        /// <summary>
        /// Deletion protection, if this is true, then you cannot delete the vMachine. you must disable this first.
        /// </summary>
        public bool DeletionProtection { get; set; }

        /// <summary>
        /// Network Configuration information for this vMachine.
        /// </summary>
        public virtual ICollection<vMachineNetwork> NetworkConfiguration { get; set; }
    }
}
