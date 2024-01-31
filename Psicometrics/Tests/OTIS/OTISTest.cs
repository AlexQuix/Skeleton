using Psicometrics.Abstract;

namespace Psicometrics.Tests.OTIS;

public class OTISTest : ITest
{
    public TestResult CalculateResult( object answers )
    {
        // ... logic here
        
        return new TestResult
        {
            CorrectAnswers = 7,
            TotalAnswers = 10,
            Score = 13
        };
    }
}