namespace FamilyMember
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FamilyMember GrandFatherFirst = new FamilyMember()
            {
                Fullname = " - дедушка Иванов Алексей",
                Age = 60,
                Sex = Gender.man
            };
            FamilyMember GrandFatherSecond = new FamilyMember()
            {
                Fullname = " - дедушка Петров Андрей",
                Age = 66,
                Sex = Gender.man
            };
            FamilyMember GrandMotherFirst = new FamilyMember()
            {
                Fullname = " - бабушка Иванова Зоя",
                Age = 59,
                Sex = Gender.woman,
                Partner = GrandFatherFirst
            };
            FamilyMember GrandMotherSecond = new FamilyMember()
            {
                Fullname = " - бабушка Петрова Анна",
                Age = 65,
                Sex = Gender.woman,
                Partner = GrandFatherSecond
            };

            GrandFatherFirst.Partner = GrandMotherFirst;
            GrandFatherSecond.Partner = GrandMotherSecond;

            FamilyMember Mother = new FamilyMember()
            {
                Fullname = " - мама Иванова Мария",
                Age = 35,
                Sex = Gender.woman,
                Father = GrandFatherSecond,
                Mother = GrandMotherSecond,
                

            };
            FamilyMember Father = new FamilyMember()
            {
                Fullname = "- папа Иванов Александр",
                Age = 38,
                Sex = Gender.man,
                Father = GrandFatherFirst,
                Mother = GrandMotherFirst,
                Partner = Mother
            };
            FamilyMember Son = new FamilyMember()
            {
                Fullname = " - я Иванов Мирон",
                Age = 15,
                Sex = Gender.man,
                Mother = Mother,
                Father = Father
            };
            FamilyMember Daughter = new FamilyMember()
            {
                Fullname = "- сестра Иванова Мирослава",
                Age = 10,
                Sex = Gender.man,
                Mother = Mother,
                Father = Father

            };
            Mother.Partner = Father;

         

            GetPartner(GrandFatherFirst);
            Console.WriteLine();
            Console.WriteLine();
            GetPartnerAndParents(Mother);
            Console.WriteLine();

            void GetPartner(FamilyMember FamilyMember)
            {
                Console.WriteLine();
                Console.WriteLine(" _______________________________________________________________________________________________________ ");
                Console.WriteLine("|  Данные   |                Человек                |                     Супруг(а)                     |");
                Console.WriteLine("|_______________________________________________________________________________________________________|");
                Console.WriteLine();
                Console.WriteLine($"|   ФИО     |          {FamilyMember?.Fullname}         |            {FamilyMember?.Partner?.Fullname}               |");
                Console.WriteLine("|_______________________________________________________________________________________________________|");
                Console.WriteLine();
                Console.WriteLine($"|  Возраст  |                 {FamilyMember?.Age}                    |                        {FamilyMember?.Partner?.Age}                         |");
                Console.WriteLine("|_______________________________________________________________________________________________________|");
                Console.WriteLine();
                Console.WriteLine($"|    Пол    |                  {FamilyMember?.Sex}                  |                       {FamilyMember?.Partner?.Sex}                       |");
                Console.WriteLine("|_______________________________________________________________________________________________________|");
            }


            void GetPartnerAndParents(FamilyMember FamilyMembers)
            {
                Console.WriteLine(" __________________________________________________________________________________________________________________ ");
                Console.WriteLine();
                Console.WriteLine($"|     Человек     |  Ф.И.О.: {FamilyMembers.Fullname}         ->   Возраст: {FamilyMembers.Age}          ->   Пол: {FamilyMembers.Sex} ");
                Console.WriteLine("|__________________________________________________________________________________________________________________|");
                Console.WriteLine();
                Console.WriteLine($"|   Супруг(а):    |  Ф.И.О.: {FamilyMembers?.Partner?.Fullname}         ->   Возраст: {FamilyMembers?.Partner?.Age}         ->   Пол: {FamilyMembers?.Partner?.Sex}");
                Console.WriteLine("|__________________________________________________________________________________________________________________|");
                Console.WriteLine();
                Console.WriteLine($"|      Отец:      |  Ф.И.О.: {FamilyMembers?.Father?.Fullname}         ->   Возраст: {FamilyMembers?.Father?.Age}         ->   Пол: {FamilyMembers?.Father?.Sex}");
                Console.WriteLine("|__________________________________________________________________________________________________________________|");
                Console.WriteLine();
                Console.WriteLine($"|      Мать:      |  Ф.И.О.: {FamilyMembers?.Mother?.Fullname}         ->    Возраст: {FamilyMembers?.Mother?.Age}         ->   Пол: {FamilyMembers?.Mother?.Sex}");
                Console.WriteLine("|__________________________________________________________________________________________________________________|");
            }

        }
    }
}







       




