using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookStore.Models;

public class RoleManagementVM
{
    public ApplicationUser ApplicationUser { get; set; }
    public IEnumerable<SelectListItem> RoleList { get; set; }
}