using Microsoft.AspNetCore.Mvc;
using Nvhlession03View.Models;
using System.Collections.Generic;


namespace Nvhlession03View.ViewComponents
{
    public class TvcDemoViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<category> categories = new List<category>()
            {
                new category {Id=1,Name="Điện tử" },
                new category {Id=2,Name="Điện Lạnh"},

                new category {Id=3,Name="Đồ gia dụng"},
                new category {Id=4,Name="Tiện ích"},
            };
            return View(categories);
        }
    }
}