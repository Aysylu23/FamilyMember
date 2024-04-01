namespace FamilyMember
{
    public enum Gender { man, woman }
    public class FamilyMember
    {
        public int Age { get; set; }
        public Gender Sex { get; set; }

        public string Fullname { get; set; }
        public FamilyMember Mother { get; set; }
        public FamilyMember Father { get; set; }

        public FamilyMember Partner { get; set; }


        public FamilyMember[] GetGrandMotherName()
        {
            return new FamilyMember[] { Mother?.Mother, Father?.Mother };
        }

        public FamilyMember[] GetGrandFatherName()
        {
            return new FamilyMember[] { Mother?.Mother, Father?.Mother };
        }
    }
}

     