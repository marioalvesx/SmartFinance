namespace SmartFinance.Exception.ExceptionsBase;

public class ErrorOnValidationException : SmartFinancesException
{
    public List<string> Errors { get; set; }
    public ErrorOnValidationException(List<string> errorMessages)
    {
        Errors = errorMessages;
    }
}
