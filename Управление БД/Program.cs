namespace Управление_БД
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Flyweigth
            ActorMikeMayers mike = new ActorMikeMayers();
            RoleAustinPowers austin = new RoleAustinPowers(mike);
            austin.Greeting("Hello! Im Austin Powers!");

            RoleDoctorEvil dr = new RoleDoctorEvil(mike);
            dr.Greeting("Hey! Im Dr Mike! ))");

        }
    }
}
