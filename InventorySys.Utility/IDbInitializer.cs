using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting; // IWebHostEnvironment icin gerekli olacak ayrica proje sayfasina framework referans eklenecek

namespace InventorySys.Repository
{
    public interface IDbInitializer
    {
        //void CreateRoles();
        void CreateSuperAdmin();
        Task SendEmail (string FromEmail,string FromName,string subject, string Message, string toEmail, string toName,string smtpUser,
            string smtpPassword, string smptHost,string smtpPort, bool smtpSSL );
        Task<string> UploadFile(List<IFormFile> files, IWebHostEnvironment env, string Directory);
    }
}