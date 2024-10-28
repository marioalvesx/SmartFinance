using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFinance.Communication.Responses;

public class ResponseErrorJson
{
    public List<string> ErrorMessage { get; set; }

    public ResponseErrorJson(string errorMessage)
    { ErrorMessage = [errorMessage]; }

    public ResponseErrorJson(List<string> errorMessage) 
    {
        ErrorMessage = errorMessage;
    }

}
