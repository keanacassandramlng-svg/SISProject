namespace SISProject.Utilities
{
    public static class IdGenerator
    {
        private static int counter = 104;

        public static string GenerateStudentNumber()
        {
            counter++;
            return $"2024-{counter:D5}-BN-0";
        }
    }
}
