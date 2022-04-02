using AlgoSdk;
using AlgoSdk.Algod;
using NUnit.Framework;
using Unity.Collections;
using UnityEngine.TestTools;

public class PendingTransactionTest
{
    static readonly string[] msgPackCases = new[]
    {
        "hbFhcHBsaWNhdGlvbi1pbmRleMzBr2NvbmZpcm1lZC1yb3VuZD6yZ2xvYmFsLXN0YXRlLWRlbHRhl4Kja2V5qGMzUmhjblE9pXZhbHVlgqZhY3Rpb24CpHVpbnTPAdg74xYn7u6Co2tlebBZbWxrWDJGalkyOTFiblE9pXZhbHVlgqZhY3Rpb24BpWJ5dGVz2SxBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBPYKja2V5pFpXNWuldmFsdWWCpmFjdGlvbgKkdWludM8B2DvjFifvDIKja2V5sGJXbHVYMkpwWkY5cGJtTT2ldmFsdWWCpmFjdGlvbgKkdWludM4AAYaggqNrZXmoYm1aMFgybGuldmFsdWWCpmFjdGlvbgKkdWludMzAgqNrZXm0Y21WelpYSjJaVjloYlc5MWJuUT2ldmFsdWWCpmFjdGlvbgKkdWludM4AD0JAgqNrZXmoYzJWc2JHVnmldmFsdWWCpmFjdGlvbgGlYnl0ZXPZLEJqdVJNUWtoSjFGTzBMcnNnbDg3RWN1WUVzdS9KRlJMWUVKaG9jZjVHZ1U9qnBvb2wtZXJyb3Kgo3R4boKjc2lnxEBpni3Ksvqt3QlzLwUia6RRLv77/BUfs2ulVabjALR9UjfcNsmrzwlx4HSzZMiSx0JhUCRNXQi6mq+PEaI5R78Go3R4boukYXBhYZbEIAY7kTEJISdRTtC67IJfOxHLmBLLvyRUS2BCYaHH+RoFxAgAAAAAAAAAwMQIAdg74xYn7u7ECAHYO+MWJ+8MxAgAAAAAAA9CQMQIAAAAAAABhqCkYXBhcMUCLQUgAwEABCYJC2JpZF9hY2NvdW50Bm5mdF9pZAZzZWxsZXIKYmlkX2Ftb3VudAVzdGFydANlbmQOcmVzZXJ2ZV9hbW91bnQLbWluX2JpZF9pbmMIbnVtX2JpZHMxGCMSQAFCMRkjEkAAhTEZgQUSQAAVMRkiEjEZgQISETEZJBIRQAABACNDMgcnBGQMQABFJwVkMgcOQAACI0MoZDIDE0AADilkKmSIAToqZIgBayJDK2QnBmQPQAARKWQqZIgBIyhkK2SIAT1C/98pZChkiAESQv/VMQAqZBIxADIJEhFEKWQqZIgA/CpkiAEtIkM2GgCABXNldHVwEkAAkjYaAIADYmlkEkAAAQAyCilkcAA1ADUBNAA0ASMNECcEZDIHDhAyBycFZAwQMRYiCTgQIhIQMRYiCTgAMQASEDEWIgk4BzIKEhAxFiIJOAgyAA8QRDEWIgk4CCtkJwdkCA9AAAIjQyhkMgMTQAAaKzEWIgk4CGcoMRYiCTgAZycIJwhkIghnIkMoZCtkiAB5Qv/cMgcnBGQMRLEkshApZLIRMgqyFLMiQyo2GgBnKTYaARdnJwQ2GgIXZycFNhoDF2cnBjYaBBdnJwc2GgUXZygyA2cyBzYaAhcMNhoCFzYaAxcMEEQiQzUDNQIyCjQCcAA1BDUFNARBAA2xJLIQNAKyETQDshWziTUHNQaxIrIQNAcyAAmyCDQGsgeziTUIMgpgIxNBAAmxIrIQNAiyCbOJpGFwZ3OCo25icwKjbnVpB6RhcHN1xAQFgQFDo2ZlZc0D6KJmdj2jZ2VuqnNhbmRuZXQtdjGiZ2jEIHH3I2wqeW08RiatDDHpb2TP5U/7VEl86K3qq1eRcLFPomx2zQQlo3NuZMQgGE5QubNQfnSdelM2NNJzbqVlx837HThil8wdLWUVLz6kdHlwZaRhcHBs"
    };

    [Test, TestMustExpectAllLogs]
    public void DeserializingPendingTransactionShouldCauseNoLogs(
        [ValueSource(nameof(msgPackCases))] string msgPackBase64
    )
    {
        using var bytes = new NativeArray<byte>(System.Convert.FromBase64String(msgPackBase64), Allocator.Temp);
        AlgoApiSerializer.DeserializeMessagePack<PendingTransactionResponse>(bytes);
    }
}
