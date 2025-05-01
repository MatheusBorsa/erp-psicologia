using erp_psicologia_classes.Application.Interfaces;
using erp_psicologia_classes.Application.UseCases.Auth;
using erp_psicologia_classes.Application.UseCases.Auth.Dtos;
using erp_psicologia_classes.Infra.Contexts;
using Microsoft.AspNetCore.Mvc;
using erp_psicologia_classes.Domain.ValueObjects;
namespace erp_psicologia.Controllers
{
    public class LoginController : Controller
    {
        public AppDbContext Context { get; set; }
        public IPasswordHasher PasswordHasher { get; set; }
        public LoginController(AppDbContext context, IPasswordHasher passwordHasher)
        {
            Context = context;
            PasswordHasher = passwordHasher;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string licenseNumber, string password)
        {
            try
            {
                LoginUseCase useCase= new LoginUseCase(Context, PasswordHasher);
                LoginInputDto inputDto = new LoginInputDto(new LicenseNumber(licenseNumber), password);

                LoginOutputDto outputDto = useCase.Execute(inputDto);
                
                if(!outputDto.Logged)
                {
                    throw new Exception(outputDto.Error);                   
                }

                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "Ocorreu um erro ao tentar fazer login: " + ex.Message;
                return View("Index");
            }
        }
    }
}
