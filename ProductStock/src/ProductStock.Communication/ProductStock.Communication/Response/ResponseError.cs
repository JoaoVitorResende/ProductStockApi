namespace ProductStock.Communication.Response
{
    public class ResponseError
    {
        public List<string> Errors { get; set; }
        public ResponseError(List<string> errors) => Errors = errors;
    }
}
