using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogsMobile.ViewModels
{
    public class MenuItemViewModel
    {
        public string Icon { get; set; }

        public string Title { get; set; }

        public string ViewName { get; set; }

        public MenuItemViewModel(string icon, string viewName, string title)
        {
            this.Icon = icon;
            this.ViewName = viewName;
            this.Title = title;
        }
    }
}
