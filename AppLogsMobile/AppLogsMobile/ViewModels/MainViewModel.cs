using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogsMobile.ViewModels
{
    public class MainViewModel
    {
        #region Properties
        public ObservableCollection<MenuItemViewModel> Menu { get; set; }
        #endregion

        #region Contructors
        public MainViewModel()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();
            LoadMenu();
        }

        #endregion

        #region Methods

        private void LoadMenu()
        {
            AddItem("ic_home.png", "MasterPage", "Inicio");
            AddItem("ic_bam.png", "BamPage", "Logs Bam");
            AddItem("ic_ods.png", "OdsPage", "Logs Ods");

        }

        private void AddItem(string icon, string viewName, string title)
        {
            Menu.Add(new MenuItemViewModel(icon, viewName, title));
        }
        #endregion
    }
}
