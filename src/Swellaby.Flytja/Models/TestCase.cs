
namespace Swellaby.Flytja.Models
{
    public class TestCase
    {
        public string Title { get; set; }

        public string TestStepsXml { get; set; }

        public string TestParameters { get; set; }

        public string LocalDataSource { get; set; }

        public string AutomatedTestName { get; set; }

        public string AutomatedTestStorage { get; set; }

        public string AutomatedTestId { get; set; }

        public string AutomatedTestType { get; set; }

        public string AutomationStatus { get; set; }

        public string Description { get; set; }
    }
}
