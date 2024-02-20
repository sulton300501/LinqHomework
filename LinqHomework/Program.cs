using LinqHomework.Model;

namespace LinqHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var progLang = new List<ProgrammingLanguage>()
            { 
              new ProgrammingLanguage {Id=1, Name="C++",BuxgaltersId=1},
              new ProgrammingLanguage {Id=2,Name="Javascript",BuxgaltersId=2},
              new ProgrammingLanguage {Id=3,Name="Python", BuxgaltersId = 1}
            };



            var buxgalter = new List<Buxgalters>()
            {
              new Buxgalters {Id=1, BName="Sulton"},
              new Buxgalters {Id=2,BName="Adham"},
              new Buxgalters {Id=3,BName="Jamshid"}
            };



            var countLang = progLang.Join(buxgalter, prg => prg.BuxgaltersId,
             buxg => buxg.Id, (prg, buxg) => new { prg.Name, buxg.BName });

            Console.WriteLine("Count Lang: ");

            foreach (var item in countLang)
            {
                Console.WriteLine(item.Name + " " + item.BName);
            }






        }
    }
}
