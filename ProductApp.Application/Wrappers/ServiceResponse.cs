namespace ProductApp.Application.Wrappers
{
    public class ServiceResponse<T>
    {
        public T Value { get; set; }
        public bool IsSuccess { get; private set; }
        public ServiceResponse() { }
        public ServiceResponse(T value)
        {
            Value = value;
            IsSuccess = true;
        }
    }
}
