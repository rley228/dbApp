namespace dbApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Staff")]
    public partial class Staff
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idStaff { get; set; }

        [StringLength(50)]
        public string lastName { get; set; }

        [StringLength(50)]
        public string fisrtNAme { get; set; }

        [StringLength(50)]
        public string middleName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? birthday { get; set; }

        public int? idDivision { get; set; }

        [StringLength(50)]
        public string position { get; set; }

        [StringLength(50)]
        public string leader { get; set; }

        [StringLength(50)]
        public string assistant { get; set; }

        [StringLength(50)]
        public string workPhone { get; set; }

        [StringLength(50)]
        public string personalPhone { get; set; }

        [StringLength(50)]
        public string cabinet { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string otherInfo { get; set; }
    }
}
