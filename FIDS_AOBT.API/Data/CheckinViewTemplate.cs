using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIDS_AOBT.API.Data;

[Table("CheckinViewTemplate")]
public class CheckinViewTemplate
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string ViewFile { get; set; }
    public string CssFile { get; set; }
    public string Background { get; set; }
    public string Fields { get; set; }
    public System.DateTime LastModifiedDate { get; set; }
}
