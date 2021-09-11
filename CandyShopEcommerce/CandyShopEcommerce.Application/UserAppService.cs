using CandyShopEcommerce.Application.Interfaces;
using CandyShopEcommerce.Domain.Entities;
using CandyShopEcommerce.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Application
{
    public class UserAppService : IUserAppService
    {
        private readonly IUserService _iUserService;
        AesCryptoServiceProvider cryptProvider;

        public UserAppService(IUserService iUserService)
        {
            _iUserService = iUserService;            
        }

        public string Decrypt(string encrypted)
        {
            string hash = "Password@2021$";

            byte[] data = Convert.FromBase64String(encrypted);

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            TripleDESCryptoServiceProvider tripDES = new TripleDESCryptoServiceProvider();

            tripDES.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripDES.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripDES.CreateDecryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

            return UTF8Encoding.UTF8.GetString(result);
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public string Encrypt(string decrypted)
        {
            string hash = "Password@2021$";

            byte[] data = UTF8Encoding.UTF8.GetBytes(decrypted);

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            TripleDESCryptoServiceProvider tripDES = new TripleDESCryptoServiceProvider();

            tripDES.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripDES.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripDES.CreateEncryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

            return Convert.ToBase64String(result);
        }

        public User Get(User entity)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll(User entity)
        {
            return _iUserService.GetAll(entity);
        }

        public User Login(User entity)
        {
            return _iUserService.Login(entity);
        }

        public int Save(User entity)
        {
            return _iUserService.Save(entity);
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
