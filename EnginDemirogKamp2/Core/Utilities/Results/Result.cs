namespace Core.Utilities.Results
{
    public class Result:IResult
    {
        //result içerisinde her zaman mesaj yazmak istemiyorsak, successi kapsayan base'i yazıyoruz.
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }
        public string Message { get; }
    }
}