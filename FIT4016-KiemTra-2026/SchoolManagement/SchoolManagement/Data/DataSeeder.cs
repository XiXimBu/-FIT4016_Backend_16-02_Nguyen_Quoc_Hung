//using Bogus;
//using SchoolManagement.Models;

//namespace SchoolManagement.Data
//{
//    public static class DataSeeder
//    {
//        public static void Seed(SchoolDbContext context)
//        {
//            if (!context.Schools.Any())
//            {
//                var schools = new Faker<School>()
//                    .RuleFor(s => s.Name, f => f.Company.CompanyName())
//                    .RuleFor(s => s.Principal, f => f.Name.FullName())
//                    .RuleFor(s => s.Address, f => f.Address.FullAddress())
//                    .Generate(10);

//                context.Schools.AddRange(schools);
//                context.SaveChanges();
//            }

//            if (!context.Students.Any())
//            {
//                var schoolIds = context.Schools.Select(s => s.Id).ToList();

//                var students = new Faker<Student>()
//                    .RuleFor(s => s.FullName, f => f.Name.FullName())
//                    .RuleFor(s => s.StudentCode, f => f.Random.AlphaNumeric(8))
//                    .RuleFor(s => s.Email, f => f.Internet.Email())
//                    .RuleFor(s => s.Phone, f => f.Random.ReplaceNumbers("0#########"))
//                    .RuleFor(s => s.SchoolId, f => f.PickRandom(schoolIds))
//                    .Generate(20);

//                context.Students.AddRange(students);
//                context.SaveChanges();
//            }
//        }
//    }
//}
