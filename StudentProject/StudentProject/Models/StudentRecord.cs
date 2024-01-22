
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentProject.Models

{
    [Table("Student_Record")]
    public class StudentRecord
    {

        [Column("Student_id")]
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        [Column("Student_name")]
        public string Name { get; set; }

        [MaxLength(100)]
        [Column("Student_mobile")]
        public int Mobile{ get; set; }

        [MaxLength(100)]
        [Column("Student_email")]
        public string Email { get; set; }

        [MaxLength(100)]
        [Column("Student_dateofbirth")]
        public DateTime DateOfBirth {  get; set; }

        [MaxLength(100)]
        [Column("Student_course")]
        public string Course {  get; set; }

    }
}
