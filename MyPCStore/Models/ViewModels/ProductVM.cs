using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MyPCStore.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }
        public IEnumerable<SelectListItem> CategorySelectList { get; set; }
        public IEnumerable<SelectListItem> ManufacturerSelectList { get; set; }
    }
}
