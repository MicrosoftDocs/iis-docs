using System.Collections.Generic;
using ValidationResult = ServerValidator.ILog.ValidationResult;
 
namespace ServerValidator.Validators
{
    public class MyCustomValidator : ServerValidator.Validators.IValidator
    {
        private Dictionary<string, string> _context;
        private Server _server;
        private ServerValidationManager _serverValidationManager;
 
        public override void Initialize(Dictionary<string,string> context, Server server, ServerValidationManager serverValidationManager)
        {
            _context = context;
            _server = server;
            _serverValidationManager = serverValidationManager;
 
            _serverValidationManager.Reporter.Log(ILog.LogEvent.LogEventType.Informational, "Initialized my custom validator");
        
        }
 
        public override ValidationResult Validate()
        {
            _serverValidationManager.Reporter.Log(ILog.LogEvent.LogEventType.Informational, "Called Validate() in my custom validator");
            return ValidationResult.Pass;
        }
    }
}