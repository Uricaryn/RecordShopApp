using RecordShopService.DTOs;

namespace RecordShopService.Services
{
    public class LoginService
    {
        private readonly AdminService _adminService;

        public LoginService(AdminService adminService)
        {
            _adminService = adminService;
        }

        public bool RegisterUser(string userName, string password)
        {
            try
            {
                return _adminService.Create(new AdminCreateDto { Username = userName, Password = password }) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error occurred during user registration: " + ex.Message);
            }
        }

        public bool ValidateUser(string userName, string password)
        {
            try
            {
                return _adminService.ValidateUser(userName, password);
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error occurred during user validation: " + ex.Message);
            }
        }
    }
}
