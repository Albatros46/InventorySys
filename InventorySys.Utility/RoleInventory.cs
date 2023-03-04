using InventorySys.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySys.Utility
{
    public class RoleInventory : IRoleInventory
    {
        private RoleManager<IdentityRole> _roleManager;
        private UserManager<AppUser> _userManager;

        public RoleInventory(RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task AddRoleAsync(string AppUserId)
        {
            var user = await _userManager.FindByIdAsync(AppUserId);
            var roles = _roleManager.Roles;
            List<string> StringRoles = new List<string>();
            if (user!=null)
            {
                foreach (var item in roles)
                {
                    StringRoles.Add(item.Name);
                }
                await _userManager.AddToRolesAsync(user, StringRoles);
            }
        }

        public async Task CreateNewRoleAsync()
        {//TopMenu class ini Identity icerisinde yenibir rol olarak tanimladik
            Type t = typeof(TopMenu);
            foreach (Type classObj in t.GetNestedTypes())
            {
                foreach (var objField in classObj.GetFields())
                {
                    if (objField.Name.Contains("RoleName"))
                    {
                        var roleName=(string)objField.GetValue(objField);
                        if(!await _roleManager.RoleExistsAsync(roleName))
                            await _roleManager.CreateAsync(new IdentityRole(roleName));
                        //https://www.youtube.com/watch?v=FiQTKjCN_6s&list=PLzHIrc5EQ2ssSJafgcf6JnfLx2wgOuIsh&index=5
                    }
                }
            }
        }
    }
}
