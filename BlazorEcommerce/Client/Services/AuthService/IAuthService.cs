namespace BlazorEcommerce.Client.Services.AuthService
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> Register(UserRegister register);
        Task<ServiceResponse<string>> Login(UserLogin request);
    }
}
