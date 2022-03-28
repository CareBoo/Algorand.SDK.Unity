using System;
using Unity.Collections;

namespace AlgoSdk
{
    [AlgoApiObject]
    public partial struct ApplicationsResponse
        : IEquatable<ApplicationsResponse>
        , IPaginatedIndexerResponse<Application>
    {
        [AlgoApiField("applications")]
        public Application[] Applications { get; set; }

        [AlgoApiField("current-round")]
        public ulong CurrentRound { get; set; }

        [AlgoApiField("next-token")]
        public FixedString128Bytes NextToken { get; set; }

        Application[] IPaginatedIndexerResponse<Application>.Results
        {
            get => Applications;
            set => Applications = value;
        }

        public bool Equals(ApplicationsResponse other)
        {
            return ArrayComparer.Equals(Applications, other.Applications)
                && CurrentRound.Equals(other.CurrentRound)
                && NextToken.Equals(other.NextToken)
                ;
        }
    }
}
