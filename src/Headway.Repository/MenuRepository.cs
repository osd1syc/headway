﻿using Headway.Core.Interface;
using Headway.Core.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Headway.Repository
{
    public class MenuRepository : IMenuRepository
    {
        private readonly List<MenuItem> menuItems = new()
        {
            new MenuItem
            {
                Id = 1,
                Name = "Home",
                ImageClass = "oi oi-home",
                Path = "/",
                ParentId = 0,
                OrderId = 1
            },
            new MenuItem
            {
                Id = 2,
                Name = "Counter",
                ImageClass = "oi oi-plus",
                Path = "counter",
                ParentId = 0,
                OrderId = 2
            },
            new MenuItem
            {
                Id = 3,
                Name = "Fetch data",
                ImageClass = "oi oi-list-rich",
                Path = "fetchdata",
                ParentId = 0,
                OrderId = 3
            },
            new MenuItem
            {
                Id = 4,
                Name = "Configuration",
                ImageClass = "oi oi-cog",
                Path = "configuration",
                ParentId = 0,
                OrderId = 4
            },
            new MenuItem
            {
                Id = 5,
                Name = "User",
                ImageClass = "oi oi-person",
                Path = "user",
                ParentId = 4,
                OrderId = 1
            }
        };

        public Task<IEnumerable<MenuItem>> GetMenuItemsAsync(string userName)
        {
            var groupedMenuItems = new List<MenuItem>();

            var orderedMenuItems = menuItems.OrderBy(mi => mi.ParentId).ThenBy(mi => mi.OrderId).ToList();
            foreach (var menuItem in orderedMenuItems)
            {
                if (menuItem.ParentId.Equals(0))
                {
                    groupedMenuItems.Add(menuItem);
                }
                else
                {
                    var parentMenuItem = orderedMenuItems.Single(mi => mi.Id.Equals(menuItem.ParentId));
                    parentMenuItem.MenuItems.Add(menuItem);
                }
            }

            return Task.FromResult<IEnumerable<MenuItem>>(groupedMenuItems);
        }
    }
}