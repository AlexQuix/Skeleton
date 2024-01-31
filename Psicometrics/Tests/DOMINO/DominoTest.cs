using Psicometrics.Abstract;

namespace Psicometrics.Tests.DOMINO;

public class DominoTest : ITest
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