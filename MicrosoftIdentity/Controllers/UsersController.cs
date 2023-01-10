using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MicrosoftIdentity
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<User> _userManager=null;
        private readonly RoleManager<IdentityRole> _roleManager=null;
        private readonly Context dbContext;

        public UsersController(
            Context dbContext)
        {
            this.dbContext = dbContext;
            //SeedDb();
            var skillsList = new List<Guid>
            {
                new Guid("6E123DFC-F9E7-4DD2-BDE7-A72949959DFD"),
                new Guid("EDF0B86C-F4FB-4AEA-BB2C-67ABF2120C36"),
                new Guid("6FFAD3C5-A3C4-4C0F-BFEC-F2941C121D25")
            };

            var mentorWithSkills = this.dbContext.MentorSkills
                .GroupBy(
                    m => m.MentorId,
                    s => s.SkillId,
                    (m, s) => new { Mentor = m, Skills = s.ToList() })
                .ToList();
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(string userName, string password)
        { 
            var user = await _userManager.FindByNameAsync(userName);
            if(user != null && await _userManager.CheckPasswordAsync(user, password))
            {
                var userRoles = await _userManager.GetRolesAsync(user);

                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(ClaimTypes.OtherPhone,"1241412412")
                };

                foreach(var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }
                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("ee442f33-e195-4896-85b7-f6ce18bfdcab"));

                var token = new JwtSecurityToken(
                        issuer: "https://localhost:7242",
                        claims: authClaims,
                        expires: DateTime.Now.AddHours(3),
                        signingCredentials: new SigningCredentials(authSigningKey,SecurityAlgorithms.HmacSha256)
                    );

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                });
            }
            return Unauthorized();
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(string userName, string password)
        {
            var userExists = await _userManager.FindByNameAsync(userName);

            if (userExists != null)
                return BadRequest("User already exists");

            User user = new User
            {
                UserName = userName,
            };

            var result = await _userManager.CreateAsync(user, password);

            if(!result.Succeeded)
            {
                return BadRequest("failed to create user");
            }

            return Ok("User created successfully");
        }

        [HttpPost]
        [Route("assign-role")]
        public async Task<IActionResult> AddToRole(string userName, string roleName)
        {
            var userExists = await _userManager.FindByNameAsync(userName);

            if (userExists == null)
                return BadRequest("User does not exist");

            var role = await _roleManager.FindByNameAsync(roleName);

            if (role == null)
            {
                var roleAdded = await _roleManager.CreateAsync(new IdentityRole
                {
                    Name = roleName
                });
            }

            var addRoleToUser = await _userManager.AddToRoleAsync(userExists, roleName);

            if(!addRoleToUser.Succeeded)
            {
                return BadRequest("Failed to add user to role");
            }

            return Ok($"User added successfully to {roleName} role");
        }

        private void SeedDb()
        {
            var mentor = new Mentor
            {
                Id = Guid.NewGuid()
            };
            dbContext.Mentors.Add(mentor);

            var csharp = dbContext.Skills.Add(new Skill
            {
                Id = Guid.NewGuid(),
                Name = "C#"
            });

            var js = dbContext.Skills.Add(new Skill
            {
                Id = Guid.NewGuid(),
                Name = "Javascript"
            });

            var angular = dbContext.Skills.Add(new Skill
            {
                Id = Guid.NewGuid(),
                Name = "Angular"
            });

            dbContext.MentorSkills.Add(new MentorSkill
            {
                Mentor = mentor,
                Skill = angular.Entity,
            });

            dbContext.MentorSkills.Add(new MentorSkill
            {
                Mentor = mentor,
                Skill = csharp.Entity,
            });

            dbContext.MentorSkills.Add(new MentorSkill
            {
                Mentor = mentor,
                Skill = js.Entity,
            });

            dbContext.SaveChanges();
        }
    }
}
