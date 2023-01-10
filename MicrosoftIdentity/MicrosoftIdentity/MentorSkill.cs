namespace MicrosoftIdentity
{
    public class MentorSkill
    {
        public Guid Id { get; set; }
        public Skill? Skill { get; set; }
        public Mentor? Mentor { get; set; }
        public Guid SkillId { get; set; }
        public Guid MentorId { get; set; }
    }
}
