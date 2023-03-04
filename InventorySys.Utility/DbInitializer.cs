﻿using InventorySys.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting; // IWebHostEnvironment icin gerekli olacak ayrica proje sayfasina framework referans eklenecek
using InventorySys.Utility.HelperClass;
using Microsoft.Extensions.Options;
using InventorySys.Repository;
using System.Net.Mail;
using System.Net;

namespace InventorySys.Utility
{
    public class DbInitializer: IDbInitializer
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppUser> _roleManager;
        private SuperAdmin _superAdmin;
        private ApplicationDbContext _context;
        private IRoleInventory _roleInventory;

        public DbInitializer(ApplicationDbContext context, IRoleInventory roleInventory)
        {
            _context = context;
            _roleInventory = roleInventory;
        }

        public DbInitializer(UserManager<AppUser> userManager, RoleManager<AppUser> roleManager, IOptions<SuperAdmin> superAdmin, ApplicationDbContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _superAdmin = superAdmin.Value;
            _context = context;
        }

        public async Task  CreateSuperAdmin()
        {
            AppUser user = new AppUser();
            user.Email = "";
            user.UserName= "admin";
            user.EmailConfirmed= true;
            var response=await _userManager.CreateAsync(user,_superAdmin.Password);
            if (response.Succeeded)
            {
                UserProfile userProfile = new UserProfile();
                userProfile.FirstName = "Admin";
                userProfile.LastName="Admin";
                userProfile.Email = user.Email;
                userProfile.AppUserId=user.Id;
                await _context.UserProfiles.AddAsync(userProfile);
                await _context.SaveChangesAsync();
                await _roleInventory.AddRoleAsync(user.Id);
            }
        }

        public async Task SendEmail(string FromEmail, string FromName, string subject,string Message, string toEmail, string toName,
            string smtpUser, string smtpPassword, string smptHost, string smtpPort, bool smtpSSL)
        {
            var body = Message;
            var messageRequest = new MailMessage();
            messageRequest.To.Add(new MailAddress(toEmail,toName));
            messageRequest.From = new MailAddress(FromEmail, FromName);
            messageRequest.Subject=subject;
            messageRequest.Body=body;
            messageRequest.IsBodyHtml=true;
            using (var smtp = new SmtpClient())
            {
                var crediential = new NetworkCredential
                {
                    UserName = smtpUser,
                    Password = smtpPassword,
                };
                smtp.Credentials= crediential;
                smtp.Host = smptHost;
                smtp.Port = Convert.ToInt32(smtpPort);
                smtp.EnableSsl= smtpSSL;
                await smtp.SendMailAsync(messageRequest);
            }

        }


        public async Task<string> UploadFile(List<IFormFile> files, IWebHostEnvironment env, string Directory)
        {
            var response = string.Empty;
            var upload = Path.Combine(env.WebRootPath,Directory);
            var fileExtension=string.Empty;
            var filePath = string.Empty;
            var filename=string.Empty;
            foreach (var file in files)
            {
                if (file.Length>0)
                {
                    fileExtension = Path.GetExtension(file.FileName);
                    filename=Guid.NewGuid().ToString()+fileExtension;
                    filePath=Path.Combine(upload,filename);
                    using(var ms =new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(ms);
                    }
                    response = filename;
                }
            }
            return response;
        }

        void IDbInitializer.CreateSuperAdmin()
        {
            throw new NotImplementedException();
        }
    }
}
