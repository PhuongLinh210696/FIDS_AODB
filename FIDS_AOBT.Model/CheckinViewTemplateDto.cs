using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIDS_AOBT.Model;

public class CheckinViewTemplateDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ViewFile { get; set; }
    public string CssFile { get; set; }
    public string Background { get; set; }
    public string Fields { get; set; }
    public System.DateTime LastModifiedDate { get; set; }
}
