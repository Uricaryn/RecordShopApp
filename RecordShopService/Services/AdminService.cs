using RechordShopApp.Concerete;
using RecordShopAppDAL.Interface;
using RecordShopService.DTOs;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace RecordShopService.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepo _adminRepo;

        public AdminService(IAdminRepo repo)
        {
            _adminRepo = repo;
        }

        public int Create(AdminCreateDto adminModel)
        {
            try
            {
                var admin = new Admin
                {
                    UserName = adminModel.Username,
                    Password = HashPassword(adminModel.Password)
                };
                return _adminRepo.Create(admin);
            }
            catch (ArgumentNullException ex)
            {
                throw new Exception("Invalid input: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Could not create admin: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error occurred: " + ex.Message);
            }
        }

        public int Delete(int id)
        {
            try
            {
                var admin = _adminRepo.GetById(id);
                if (admin != null)
                    return _adminRepo.Delete(admin);
                else
                    throw new Exception("User not found...");
            }
            catch (ArgumentException ex)
            {
                throw new Exception("Invalid ID: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Could not delete admin: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error occurred: " + ex.Message);
            }
        }

        public int Update(AdminCreateDto adminModel, int id)
        {
            try
            {
                var admin = _adminRepo.GetById(id);
                if (admin != null)
                {
                    admin.UserName = adminModel.Username;
                    admin.Password = HashPassword(adminModel.Password);
                    return _adminRepo.Update(admin);
                }
                else
                    throw new Exception("User not found...");
            }
            catch (ArgumentNullException ex)
            {
                throw new Exception("Invalid input: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                throw new Exception("Invalid ID: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Could not update admin: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error occurred: " + ex.Message);
            }
        }

        public bool ValidateUser(string userName, string password)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
                    throw new ArgumentException("Username or password cannot be empty.");

                var admin = _adminRepo.GetAll().SingleOrDefault(a => a.UserName == userName);
                if (admin != null)
                {
                    string hashedEnteredPassword = HashPassword(password);
                    return hashedEnteredPassword == admin.Password;
                }

                return false;
            }
            catch (ArgumentException ex)
            {
                throw new Exception("Invalid input: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("User validation failed: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error occurred: " + ex.Message);
            }
        }

        public static bool ValidatePassword(string password)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(password))
                    throw new ArgumentException("Password cannot be empty.");

                if (password.Length < 8 || password.Count(char.IsUpper) < 2 || password.Count(char.IsLower) < 3)
                    throw new ArgumentException("Password does not meet the criteria.");

                string specialChar = "!:+*";
                int specialsCount = password.Count(c => specialChar.Contains(c));
                if (specialsCount < 2)
                    throw new ArgumentException("Password must contain at least 2 special characters.");

                return true;
            }
            catch (ArgumentException ex)
            {
                throw new Exception("Password validation failed: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error occurred: " + ex.Message);
            }
        }

        public static string HashPassword(string password)
        {
            try
            {
                using (SHA256 hash = SHA256.Create())
                {
                    return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2")));
                }
            }
            catch (ArgumentNullException ex)
            {
                throw new Exception("Invalid password input: " + ex.Message);
            }
            catch (CryptographicException ex)
            {
                throw new Exception("Password hashing failed: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error occurred: " + ex.Message);
            }
        }
    }
}
