namespace StudentAPI.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message) { }
        public NotFoundException(string name, int id)
            : base($"{name} with ID {id} was not found.") { }
    }
}