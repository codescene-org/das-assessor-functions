﻿using System.Net.Http;
using System.Threading.Tasks;

namespace SFA.DAS.Assessor.Functions.ApiClient
{
    public interface IAssessorServiceApiClient
    {
        Task<HttpResponseMessage> UpdateStandardSummary();
        HttpClient Client { get; }
    }
}