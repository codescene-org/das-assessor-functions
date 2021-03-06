namespace SFA.DAS.Assessor.Functions.Infrastructure
{
    public class AssessorApiAuthentication
    {
        public string Instance { get; set; }
        public string TenantId { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string ResourceId { get; set; }
        public string ApiBaseAddress { get; set; }
    }
}