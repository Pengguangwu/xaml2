using System.Collections.Generic;


namespace RestaurantManager.Models
{
    public class OrderDataManager : DataManager
    {
        
        protected override void OnDataLoaded()

        {

   
            this.MenuItems = base.Repository.StandardMenuItems;

            this.CurrentlySelectedMenuItems = new List<MenuItem>
            {
                this.MenuItems[3],
                this.MenuItems[5]
            };
        }
        

        public List<MenuItem> MenuItems
        {
            get {
                return base.Repository.StandardMenuItems;
            }

            set { OnPropertyChanged(); }
        }

        public List<MenuItem> CurrentlySelectedMenuItems
        {
            get
            {
                this.MenuItems = base.Repository.StandardMenuItems;
                if (MenuItems != null)
                {
                    return new List<MenuItem>
            {
                this.MenuItems[3],
                this.MenuItems[5]
            };
                }
                else
                    return null;
            }
            
            set { OnPropertyChanged(); }
        }  
           
       
    }
}
