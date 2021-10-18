using System;

namespace OOPFundamentals.SRP
{
    public class RegisterServiceRefactored
    {
        private UserRepository _userRepository;
        private EmailService _emailService;

        public RegisterServiceRefactored()
        {
            _userRepository = new UserRepository();
            _emailService = new EmailService();
        }

        public void RegisterUser(string username)
        {
            if (username == "admin")
                throw new InvalidOperationException();

            _userRepository.Insert("");

            _emailService.Send("");
        }
    }
}
