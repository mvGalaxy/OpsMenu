namespace OpsMenu.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OpsLink:IOpsData
    {
        public int Id { get; set; }

        [Required]
        [StringLength(450)]
        public string AppName { get; set; }

        [Required]
        public string PathToApplication { get; set; }

        [Required]
        [StringLength(450)]
        public string GroupName { get; set; }
    }
}
