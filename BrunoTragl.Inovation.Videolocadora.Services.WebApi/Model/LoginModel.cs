using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using System;
using System.Linq.Expressions;

namespace BrunoTragl.Inovation.Videolocadora.Services.WebApi.Model
{
    public class LoginModel
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        
        public bool IsValid()
        {
            return (!string.IsNullOrEmpty(Login) || !string.IsNullOrEmpty(Senha));
        }
    }
}
