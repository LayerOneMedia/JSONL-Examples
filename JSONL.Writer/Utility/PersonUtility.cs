using JSONL.Model;

namespace JSONL.Writer.Utility
{
    internal class PersonUtility
    {
        public static Person GetRandomPerson()
        {
            return new Person
            {
                Id = Guid.NewGuid(),
                FirstName = NameUtility.GetRandomFirstName(),
                MiddleName = NameUtility.GetRandomFirstName(),
                LastName = NameUtility.GetRandomLastName(),
            };
        }

        public static IEnumerable<Person> GetRandomPeople(int count = 5)
        {
            var people = new List<Person>();
            for (int i = 0; i < count; i++)
            {
                people.Add(GetRandomPerson());
            }
            return people;
        }
    }
}
