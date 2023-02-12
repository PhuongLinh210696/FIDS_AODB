namespace FIDS_AOBT.API.Models;

public class CheckinViewTemplateModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ViewFile { get; set; }
    public string CssFile { get; set; }
    public string Background { get; set; }
    public string Fields { get; set; }
    public System.DateTime LastModifiedDate { get; set; }
}
